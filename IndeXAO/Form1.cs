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
            imgSelected = grhNumber;
            LoadImg(grhNumber);
        }

        int imgSelected = 0;
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

            if (picImg.Image != null)
            {
                picImg.Image.Dispose();
                picImg.Image = null;
                picImg.Update();
            }

            string dirPath = ConfigINI["INIT"]["DirGraficos"];

            if (index.NumFrames == 1)
            {
                string filePath = System.IO.Path.Combine(dirPath, index.ImageNum.ToString());
                if (System.IO.File.Exists(filePath + ".png"))
                    filePath += ".png";
                else if (System.IO.File.Exists(filePath + ".png"))
                    filePath += ".png";
                else
                    return;
                Bitmap myImg = new Bitmap(filePath);
                myImg.MakeTransparent();
                var newImg = myImg.Clone(new Rectangle { X = index.PosX, Y = index.PosY, Width = index.Width, Height = index.Height }, myImg.PixelFormat);
                if (picImg.Width < index.Width)
                {
                    index.Width = picImg.Width;
                    index.Height = picImg.Height; // TODO: Falta formula
                }
                else if (picImg.Height < index.Height)
                {
                    index.Height = picImg.Height;
                    index.Width = picImg.Width; // TODO: Falta formula
                }
                int newWidth = index.Width * zoomBar.Value;
                int newHeight = index.Height * zoomBar.Value;
                newImg = resizeImage(newImg, new Size(newWidth, newHeight));
                picImg.Image = newImg;
            }
        }

        private static System.Drawing.Bitmap resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Bitmap)b;
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            LoadImg(imgSelected);
        }
    }
}
