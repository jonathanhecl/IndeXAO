using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndeXAO
{
    public partial class Form1 : Form
    {
        string ConfigFile = "config.ini";
        IniParser.Model.IniData ConfigINI = new IniParser.Model.IniData();
        string DirGraphics;
        string FileIndex;

        public class IndexStruct
        {
            public int GrhNum { get; set; }
            public int NumFrames { get; set; }
            public int[] Frames { get; set; } // Si NumFrames>1
            public Single Speed { get; set; } // Si NumFrames>1
            public int ImageNum { get; set; }
            public int PosX { get; set; }
            public int PosY { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        List<IndexStruct> indexList = new List<IndexStruct>();

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(grpBoxIndex_DragEnter);
            this.DragDrop += new DragEventHandler(grpBoxIndex_DragDrop);
        }

        private void cmdGraficos_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                var parser = new IniParser.FileIniDataParser();
                ConfigINI["INIT"]["DirGraficos"] = folderBrowserDialog.SelectedPath;
                parser.WriteFile(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), ConfigFile), ConfigINI);
                CargarDirGraficos(folderBrowserDialog.SelectedPath);
            }
        }

        private void CargarDirGraficos(string dirGraficos)
        {
            txtGraficos.Text = dirGraficos;
            string[] files = System.IO.Directory.GetFiles(dirGraficos);
            int grh = 0;
            listGraficos.BeginUpdate();
            listGraficos.Items.Clear();
            foreach (string file in files)
            {
                string name = System.IO.Path.GetFileName(file);
                if (name.EndsWith(".bmp") || name.EndsWith(".png"))
                {
                    string first = System.IO.Path.GetFileNameWithoutExtension(name);
                    bool isNumeric = int.TryParse(first, out _);
                    if (isNumeric)
                    {
                        listGraficos.Items.Add(name);
                        grh++;
                    }
                }
            }
            listGraficos.EndUpdate();
            lblGraficos.Text = "Gráficos: " + grh.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var parser = new IniParser.FileIniDataParser();
            ConfigINI = parser.ReadFile(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), ConfigFile));
            if (System.IO.Directory.Exists(ConfigINI["INIT"]["DirGraficos"])) { 
                CargarDirGraficos(ConfigINI["INIT"]["DirGraficos"]);
            }
            if (System.IO.File.Exists(ConfigINI["INIT"]["DirIndice"]))
            {
                CargarIndice(ConfigINI["INIT"]["DirIndice"]);
            }
        }

        private void cmdIndice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Abrir indice";
            openFileDialog.DefaultExt = "";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Archivo de indice (*.ini;*.ind)|*.ini;*.ind|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var parser = new IniParser.FileIniDataParser();
                ConfigINI["INIT"]["DirIndice"] = openFileDialog.FileName;
                parser.WriteFile(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), ConfigFile), ConfigINI);
                CargarIndice(openFileDialog.FileName);
            }

        }

        System.IO.MemoryStream fileMemory = new System.IO.MemoryStream();

        public void CargarIndice(string filepath)
        {
            txtIndice.Text = filepath;
            string name = System.IO.Path.GetFileName(filepath);

            indexList.Clear();
            if (name.EndsWith(".ind")) {
                System.IO.FileInfo fi = new System.IO.FileInfo(filepath);
                lblIndice.Text = fi.Length.ToString();
                fileMemory.Dispose();
                fileMemory = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = System.IO.File.OpenRead(filepath))
                {
                    fs.CopyTo(fileMemory);
                }

                fileMemory.Seek(0x00, System.IO.SeekOrigin.Begin);

                // Version
                var ver = new byte[4];
                fileMemory.Read(ver, 0, (int)ver.Length);
                txtVer.Text = BitConverter.ToInt32(ver).ToString();

                // MaxGrh
                var maxGrh = new byte[4];
                fileMemory.Read(maxGrh, 0, (int)maxGrh.Length);
                lblIndice.Text = "Indices: " + BitConverter.ToInt32(maxGrh).ToString();

                bool exit = false;
                
                do
                {
                    IndexStruct newIndex = new IndexStruct();

                    // Grh number
                    var number = new byte[4];
                    fileMemory.Read(number, 0, (int)number.Length);
                    newIndex.GrhNum = BitConverter.ToInt32(number);

                    // Frames
                    var frames = new byte[2];
                    fileMemory.Read(frames, 0, (int)frames.Length);
                    newIndex.NumFrames = BitConverter.ToInt16(frames);

                    if (newIndex.NumFrames == 1)
                    {
                        var image = new byte[4];
                        fileMemory.Read(image, 0, (int)image.Length);
                        newIndex.ImageNum = BitConverter.ToInt32(image);
                        var posX = new byte[2];
                        fileMemory.Read(posX, 0, (int)posX.Length);
                        newIndex.PosX = BitConverter.ToInt16(posX);
                        var posY = new byte[2];
                        fileMemory.Read(posY, 0, (int)posY.Length);
                        newIndex.PosY = BitConverter.ToInt16(posY);
                        var width = new byte[2];
                        fileMemory.Read(width, 0, (int)width.Length);
                        newIndex.Width = BitConverter.ToInt16(width);
                        var height = new byte[2];
                        fileMemory.Read(height, 0, (int)height.Length);
                        newIndex.Height = BitConverter.ToInt16(height);
                    }
                    else if (BitConverter.ToInt16(frames) > 1)
                    {
                        short maxFrames = BitConverter.ToInt16(frames);
                        newIndex.Frames = new int[maxFrames];
                        int i = 0;
                        do
                        {
                            var grh = new byte[4];
                            fileMemory.Read(grh, 0, (int)grh.Length);
                            newIndex.Frames[i] = BitConverter.ToInt32(grh);
                            i++;
                        } while (i < maxFrames);

                        var speed = new byte[4];
                        fileMemory.Read(speed, 0, (int)speed.Length);
                        newIndex.Speed = BitConverter.ToSingle(speed);
                    } else
                    {
                        exit = true;
                    }
                    if (newIndex.GrhNum > 0) { 
                        indexList.Add(newIndex);
                    }
                } while (!exit || fileMemory.Position > fileMemory.Length);
            } else if (name.EndsWith(".ini"))
            {
                MessageBox.Show("Es indice ini");
            } else
            {
                //
            }

            lstIndices.BeginUpdate();
            lstIndices.Items.Clear();
            for (int i = 0; i < indexList.Count; i++)
            {
                string tag = "";
                if (indexList[i].NumFrames == 0)
                {
                    tag = "[VACIO]";
                }
                else if (indexList[i].NumFrames == 1)
                {
                    tag = indexList[i].ImageNum.ToString();
                }
                else if (indexList[i].NumFrames > 1)
                {
                    tag = "[Animación] x" + indexList[i].NumFrames.ToString();
                }
                lstIndices.Items.Add(indexList[i].GrhNum.ToString() + "\t" + tag);
            }
            lstIndices.EndUpdate();
        }

        private void lstIndices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grhNumber = Convert.ToInt32(lstIndices.SelectedItem.ToString().Split("\t")[0]);
            if (picImg.Image != null)
            {
                picImg.Image.Dispose();
                picImg.Image = null;
                picImg.Update();
            }
            imgSelected = grhNumber;
            numFrame = 0;
            LoadImg(grhNumber);
        }

        string cacheFile;
        Bitmap cacheImage;
        int imgSelected = 0;
        int numFrame = 0;


        private void LoadIndice(int grhNumber)
        {
            IndexStruct index = new IndexStruct();
            foreach (IndexStruct i in indexList)
            {
                if (i.GrhNum == grhNumber)
                {
                    index = i;
                    break;
                }
            }
            txtGrhNum.Text = grhNumber.ToString();
            if (index.NumFrames == 1)
            {
                rdoStatic.Checked = true;
                txtImageNum.Text = index.ImageNum.ToString();
                txtPosX.Text = index.PosX.ToString();
                txtPosY.Text = index.PosY.ToString();
                txtWidth.Text = index.Width.ToString();
                txtHeight.Text = index.Height.ToString();
                string dirPath = ConfigINI["INIT"]["DirGraficos"];
                string filePath = System.IO.Path.Combine(dirPath, index.ImageNum.ToString());
                if (System.IO.File.Exists(filePath + ".bmp"))
                    filePath += ".bmp";
                else if (System.IO.File.Exists(filePath + ".png"))
                    filePath += ".png";
                else
                    return;
                if(cacheFile != filePath)
                {
                    Bitmap myImg = new Bitmap(filePath);
                    myImg.MakeTransparent();
                    cacheImage = myImg;
                    cacheFile = filePath;
                }                
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Image = cacheImage;
            } else if (index.NumFrames > 1)
            {
                rdoAnim.Checked = true;
                lstFrames.Items.Clear();
                foreach (int frame in index.Frames)
                {
                    lstFrames.Items.Add(frame.ToString());
                }
                txtSpeed.Text = index.Speed.ToString();
            }
        }
        private void LoadImg(int grhNumber)
        {
            IndexStruct index = new IndexStruct();
            foreach (IndexStruct i in indexList)
            {
                if (i.GrhNum == grhNumber)
                {
                    index = i;
                    break;
                }
            }

            string dirPath = ConfigINI["INIT"]["DirGraficos"];

            if (index.NumFrames == 1)
            {
                string filePath = System.IO.Path.Combine(dirPath, index.ImageNum.ToString());
                if (System.IO.File.Exists(filePath + ".bmp"))
                    filePath += ".bmp";
                else if (System.IO.File.Exists(filePath + ".png"))
                    filePath += ".png";
                else
                    return;
                if (cacheFile != filePath)
                {
                    Bitmap myImg = new Bitmap(filePath);
                    myImg.MakeTransparent();
                    cacheImage = myImg;
                    cacheFile = filePath;
                }
                var newImg = cacheImage.Clone(new Rectangle { X = index.PosX, Y = index.PosY, Width = index.Width, Height = index.Height }, cacheImage.PixelFormat);
                int newWidth = index.Width * zoomBar.Value;
                int newHeight = index.Height * zoomBar.Value;
                newImg = new Bitmap(newImg, new Size(newWidth, newHeight));
                if (newImg.Height > picImg.Height || newImg.Width > picImg.Width)
                    picImg.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    picImg.SizeMode = PictureBoxSizeMode.Normal;
                picImg.Image = newImg;
            } else if (index.NumFrames > 1)
            {
                timerAnim.Enabled = false;
                timerAnim.Tag = imgSelected;
                int speed = Convert.ToInt32(index.Speed);
                if (speed <= 10)
                    speed = speed * 200;
                speed = speed / 2;
                timerAnim.Interval = speed;
                timerAnim.Enabled = true;
            }
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            LoadImg(imgSelected);
        }

        private void cmdCambiarFondo_Click(object sender, EventArgs e)
        {
            var nc = new ColorDialog();
            nc.ShowDialog();
            picImg.BackColor = nc.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            imgSelected = -1;
        }

        private void rdoAnim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAnim.Checked)
            {
                rdoStatic.Checked = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                txtImageNum.Visible = false;
                txtPosX.Visible = false;
                txtPosY.Visible = false;
                txtWidth.Visible = false;
                txtHeight.Visible = false;
                label7.Visible = true;
                lstFrames.Visible = true;
                cmdAdd.Enabled = true;
                cmdRemove.Visible = true;
                txtSpeed.Visible = true;
                cmdUp.Visible = true;
                cmdDown.Visible = true;
            }
        }

        private void rdoStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStatic.Checked)
            {
                rdoAnim.Checked = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtImageNum.Visible = true;
                txtPosX.Visible = true;
                txtPosY.Visible = true;
                txtWidth.Visible = true;
                txtHeight.Visible = true;
                label7.Visible = false;
                lstFrames.Visible = false;
                cmdAdd.Enabled = false;
                cmdRemove.Visible = false;
                txtSpeed.Visible = false;
                cmdUp.Visible = false;
                cmdDown.Visible = false;
            }
        }

        private void grpBoxIndex_Enter(object sender, EventArgs e)
        {

        }

        private void grpBoxIndex_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void grpBoxIndex_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0) {
                var ext = System.IO.Path.GetExtension(files[0]);
                if (ext == ".bmp" || ext == ".png")
                {
                    var filename = System.IO.Path.GetFileNameWithoutExtension(files[0]);
                    bool isNumeric = int.TryParse(filename, out _);
                    if (isNumeric)
                    {
                        txtImageNum.Text = filename;
                        string dirPath = ConfigINI["INIT"]["DirGraficos"];
                        string filePath = System.IO.Path.Combine(dirPath, txtImageNum.Text);
                        if (System.IO.File.Exists(filePath + ".bmp"))
                            filePath += ".bmp";
                        else if (System.IO.File.Exists(filePath + ".png"))
                            filePath += ".png";
                        else
                            return;
                        Bitmap myImg = new Bitmap(filePath);
                        myImg.MakeTransparent();
                        picImage.SizeMode = PictureBoxSizeMode.Zoom;
                        picImage.Image = myImg;
                    }                    
                }
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            int prevIndex = lstFrames.SelectedIndex;
            lstFrames.Items.Remove(lstFrames.SelectedItem);
            if (prevIndex==lstFrames.Items.Count) {
                if (prevIndex == 0)
                    return;
                lstFrames.SelectedIndex = prevIndex - 1;
            } else
            {
                lstFrames.SelectedIndex = prevIndex;
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
           lstFrames.Items.Add(imgSelected);
        }

        private void cmdEditGrh_Click(object sender, EventArgs e)
        {
            LoadIndice(imgSelected);
        }

        private void cmdAplicarIndice_Click(object sender, EventArgs e)
        {
            int grhNumber;
            bool isNumeric = int.TryParse(txtGrhNum.Text, out grhNumber);
            if (isNumeric)
            {
                foreach (IndexStruct i in indexList)
                {
                    if (i.GrhNum == grhNumber)
                    {
                        i.NumFrames = 0;
                        i.Frames = new int[0];
                        i.Speed = 0;
                        i.ImageNum = 0;
                        i.PosX = 0;
                        i.PosY = 0;
                        i.Width = 0;
                        i.Height = 0;
                        if(rdoStatic.Checked)
                        {
                            int imageNum;
                            int.TryParse(txtImageNum.Text, out imageNum);
                            if (imageNum > 0)
                            {
                                i.NumFrames = 1;
                                i.ImageNum = imageNum;
                                int posX;
                                int.TryParse(txtPosX.Text, out posX);
                                i.PosX = posX;
                                int posY;
                                int.TryParse(txtPosY.Text, out posY);
                                i.PosY = posY;
                                int width;
                                int.TryParse(txtWidth.Text, out width);
                                i.Width = width;
                                int height;
                                int.TryParse(txtHeight.Text, out height);
                                i.Height = height;
                            }
                        } else if(rdoAnim.Checked)
                        {
                            int numFrames = lstFrames.Items.Count;
                            if (numFrames > 0 )
                            {
                                i.NumFrames = numFrames;
                                i.Frames = new int[numFrames];
                                int n = 0;
                                do
                                {
                                    int grh;
                                    int.TryParse(lstFrames.Items[n].ToString(), out grh);
                                    i.Frames[n] = grh;
                                    n++;
                                } while (n < numFrames);
                                int speed;
                                int.TryParse(txtSpeed.Text, out speed);
                                i.Speed = speed;
                            }
                        }
                        LoadImg(imgSelected);
                        break;
                    }
                }
            }
        }

        private void timerAnim_Tick(object sender, EventArgs e)
        {
            
            int actualGrh = Convert.ToInt32(timerAnim.Tag);
            if (actualGrh != imgSelected) {
                timerAnim.Enabled = false;
                return;
            }
            IndexStruct index = new IndexStruct();
            foreach (IndexStruct i in indexList)
            {
                if (i.GrhNum == actualGrh)
                {
                    index = i;
                    break;
                }
            }
            if (numFrame >= index.NumFrames)
            {
                numFrame = 0;
            }
            if (index.NumFrames == 0)
                return;
            LoadImg(index.Frames[numFrame]);
            numFrame++;
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            int prevIndex = lstFrames.SelectedIndex;
            if (prevIndex == 0)
                return;
            object item = lstFrames.SelectedItem;
            lstFrames.Items.Remove(item);
            lstFrames.Items.Insert(prevIndex-1,item);
            lstFrames.SelectedIndex = prevIndex-1;
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            int prevIndex = lstFrames.SelectedIndex;
            if (prevIndex == lstFrames.Items.Count-1)
                return;
            object item = lstFrames.SelectedItem;
            lstFrames.Items.Remove(item);
            lstFrames.Items.Insert(prevIndex + 1, item);
            lstFrames.SelectedIndex = prevIndex + 1;
        }
    }
}
