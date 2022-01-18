﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndeXAO
{
    public partial class Form1 : Form
    {
        string ConfigFile = "config.ini";
        Form2 frmConsole = new Form2();
        IniParser.Model.IniData ConfigINI = new IniParser.Model.IniData();
        string DirGraphics;
        string FileIndex;

        int MaxGrh;
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

        public class MainJsonStruct
        {
            public int MaxGrh;
            public int Version;
            public List<IndexStruct> Graphics = new List<IndexStruct>();
        }

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            tableLayoutPanel10.Visible = false;
            tableLayoutPanel9.Visible = false;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("enter");
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("drop");
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                var ext = System.IO.Path.GetExtension(files[0]);
                if (ext == ".bmp" || ext == ".png")
                {
                    var filename = System.IO.Path.GetFileNameWithoutExtension(files[0]);
                    bool isNumeric = int.TryParse(filename, out _);
                    if (isNumeric)
                    {
                        txtImageNum.Text = filename;
                        /*
                        string dirPath = ConfigINI["INIT"]["DirGraficos"];
                        string filePath = System.IO.Path.Combine(dirPath, txtImageNum.Text);
                        if (System.IO.File.Exists(filePath + ".png"))
                            filePath += ".png";
                        else if (System.IO.File.Exists(filePath + ".png"))
                            filePath += ".png";
                        else
                            return;
                        */
                        string filePath = GetImageFilename(Int32.Parse(txtImageNum.Text));
                        if (filePath.Length == 0)
                        {
                            return;
                        }
                        Bitmap myImg = new Bitmap(filePath);
                        myImg.MakeTransparent();
                        picImage.SizeMode = PictureBoxSizeMode.Zoom;
                        picImage.Image = myImg;
                    }
                }
            }
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
            //listGraficos.BeginUpdate();
            //listGraficos.Items.Clear();
            foreach (string file in files)
            {
                string name = System.IO.Path.GetFileName(file);
                if (name.EndsWith(".bmp") || name.EndsWith(".png"))
                {
                    string first = System.IO.Path.GetFileNameWithoutExtension(name);
                    bool isNumeric = int.TryParse(first, out _);
                    if (isNumeric)
                    {
                        //listGraficos.Items.Add(name);
                        grh++;
                    }
                }
            }
            //listGraficos.EndUpdate();
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
            openFileDialog.Filter = "Archivo de indice (*.ini;*.ind;*.json)|*.ini;*.ind;*.json|Todos los archivos (*.*)|*.*";
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
            lblIndice.Text = "Indices: ...";
            Application.DoEvents();

            indexList.Clear();
            if (name.EndsWith(".ind")) {
                System.IO.FileInfo fi = new System.IO.FileInfo(filepath);
                fileMemory.Dispose();
                fileMemory = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = System.IO.File.OpenRead(filepath))
                {
                    fs.CopyTo(fileMemory);
                }

                fileMemory.Seek(0x00, System.IO.SeekOrigin.Begin);

                // Exists Cabecera 9.9 old school?
                var cabecera = new byte[255];
                fileMemory.Read(cabecera, 0, (int)cabecera.Length);
                if (cabecera.All(b => b >= 32 && b <= 127))
                {
                    //string tDesc = Encoding.Default.GetString(cabecera);
                    var tLong = new byte[4];
                    fileMemory.Read(tLong, 0, (int)tLong.Length);
                    fileMemory.Read(tLong, 0, (int)tLong.Length);
                    var tInt = new byte[2];
                    fileMemory.Read(tInt, 0, (int)tInt.Length);
                    fileMemory.Read(tInt, 0, (int)tInt.Length);
                    fileMemory.Read(tInt, 0, (int)tInt.Length);
                    fileMemory.Read(tInt, 0, (int)tInt.Length);
                    fileMemory.Read(tInt, 0, (int)tInt.Length);
                    txtVer.Text = "0";
                    MaxGrh = 0;
                } else
                {
                    fileMemory.Seek(0x00, System.IO.SeekOrigin.Begin);
                    // Version
                    var ver = new byte[4];
                    fileMemory.Read(ver, 0, (int)ver.Length);
                    txtVer.Text = BitConverter.ToInt32(ver).ToString();

                    // MaxGrh
                    var maxGrh = new byte[4];
                    fileMemory.Read(maxGrh, 0, (int)maxGrh.Length);
                    MaxGrh = BitConverter.ToInt32(maxGrh);
                }

                bool exit = false;
                bool isGrhInt = false;
                Int32 maxGrhLoaded = 0;

                do
                {
                    IndexStruct newIndex = new IndexStruct();

                    // Grh number
                    if (isGrhInt == false) { 
                        var number = new byte[4];
                        fileMemory.Read(number, 0, (int)number.Length);
                        newIndex.GrhNum = BitConverter.ToInt32(number);
                        if (newIndex.GrhNum > 32000 && maxGrhLoaded==0)
                        {
                            fileMemory.Seek(-4, System.IO.SeekOrigin.Current);
                            var tInt = new byte[2];
                            fileMemory.Read(tInt, 0, (int)tInt.Length);
                            newIndex.GrhNum = BitConverter.ToInt16(tInt);
                            isGrhInt = true;
                        }
                    } else if (isGrhInt==true)
                    {
                        var tInt = new byte[2];
                        fileMemory.Read(tInt, 0, (int)tInt.Length);
                        newIndex.GrhNum = BitConverter.ToInt16(tInt);
                    }
                    if (maxGrhLoaded< newIndex.GrhNum) {
                        maxGrhLoaded = newIndex.GrhNum;
                    }

                    // Frames
                    var frames = new byte[2];
                    fileMemory.Read(frames, 0, (int)frames.Length);
                    newIndex.NumFrames = BitConverter.ToInt16(frames);

                    if (newIndex.NumFrames == 1)
                    {
                        if (isGrhInt == true)
                        {
                            var image = new byte[2];
                            fileMemory.Read(image, 0, (int)image.Length);
                            newIndex.ImageNum = BitConverter.ToInt16(image);
                        } else
                        {
                            var image = new byte[4];
                            fileMemory.Read(image, 0, (int)image.Length);
                            newIndex.ImageNum = BitConverter.ToInt32(image);
                        }
                        // Debug
                        string filePath = GetImageFilename(newIndex.ImageNum);
                        if (filePath.Length == 0)
                        {
                            frmConsole.ConsoleText = "El Grh " + newIndex.GrhNum.ToString() + " hace referencia a una imagen faltante " + newIndex.ImageNum.ToString();
                        }
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
                            if (isGrhInt == true)
                            {
                                var grh = new byte[2];
                                fileMemory.Read(grh, 0, (int)grh.Length);
                                newIndex.Frames[i] = BitConverter.ToInt16(grh);
                            } else
                            {
                                var grh = new byte[4];
                                fileMemory.Read(grh, 0, (int)grh.Length);
                                newIndex.Frames[i] = BitConverter.ToInt32(grh);
                            }
                            i++;
                        } while (i < maxFrames);
                        if (isGrhInt==true)
                        {
                            var speed = new byte[2];
                            fileMemory.Read(speed, 0, (int)speed.Length);
                            newIndex.Speed = BitConverter.ToInt16(speed);
                        } else { 
                            var speed = new byte[4];
                            fileMemory.Read(speed, 0, (int)speed.Length);
                            newIndex.Speed = BitConverter.ToSingle(speed);
                        }
                    } else
                    {
                        exit = true;
                    }
                    if (newIndex.GrhNum > 0) { 
                        indexList.Add(newIndex);
                    }
                } while (!exit || fileMemory.Position > fileMemory.Length);
                if (MaxGrh == 0 || MaxGrh < maxGrhLoaded) {
                    MaxGrh = maxGrhLoaded;
                }
            } else if (name.EndsWith(".json"))
            {
                MainJsonStruct IndJson = new MainJsonStruct();
                string jsonString = File.ReadAllText(filepath);

                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                settings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore;

                IndJson = Newtonsoft.Json.JsonConvert.DeserializeObject< MainJsonStruct>(jsonString);

                MaxGrh = IndJson.MaxGrh;
                txtVer.Text = IndJson.Version.ToString();
                indexList = IndJson.Graphics;

            } else
            {
                var parser = new IniParser.FileIniDataParser();
                IniParser.Model.IniData IndINI = new IniParser.Model.IniData();
                IndINI = parser.ReadFile(filepath);
                MaxGrh = Convert.ToInt32(IndINI["INIT"]["NumGrh"]);
                txtVer.Text = IndINI["INIT"]["Version"];
                for (int i = 0; i <= MaxGrh; i++)
                {
                    if (IndINI["Graphics"]["Grh" + i.ToString()] != null)
                    {
                        IndexStruct newIndex = new IndexStruct();
                        string grhLine = IndINI["Graphics"]["Grh" + i.ToString()];
                        if (!grhLine.Contains("-"))
                            continue;
                        string[] grhSplit = grhLine.Split("-");
                        if (grhSplit[0] == "" || grhSplit[0] == "0")
                            continue;
                        else if (grhSplit[0] == "1")
                        {
                            if (grhSplit.Length != 6)
                                continue;
                            newIndex.NumFrames = 1;
                            newIndex.ImageNum = Convert.ToInt32(grhSplit[1]);
                            newIndex.PosX = Convert.ToInt32(grhSplit[2]);
                            newIndex.PosY = Convert.ToInt32(grhSplit[3]);
                            newIndex.Width = Convert.ToInt32(grhSplit[4]);
                            newIndex.Height = Convert.ToInt32(grhSplit[5]);
                        } else
                        {
                            int maxFrames = Convert.ToInt32(grhSplit[0]);
                            if (grhSplit.Length != maxFrames + 2)
                                continue;
                            newIndex.NumFrames = maxFrames;
                            newIndex.Frames = new int[maxFrames];
                            int f = 0;
                            do
                            {
                                newIndex.Frames[f] = Convert.ToInt32(grhSplit[f+1]);
                                f++;
                            } while (f < maxFrames);
                            newIndex.Speed = Convert.ToSingle(grhSplit[maxFrames + 1]);
                        }
                        newIndex.GrhNum = i;
                        indexList.Add(newIndex);
                    }
                }
            }

            FilterIndices();
            /*
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
            */

            lblIndice.Text = "Indices: " + MaxGrh.ToString();

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
                tableLayoutPanel10.Visible = true;
                tableLayoutPanel9.Visible = false;
                txtImageNum.Text = index.ImageNum.ToString();
                txtPosX.Text = index.PosX.ToString();
                txtPosY.Text = index.PosY.ToString();
                txtWidth.Text = index.Width.ToString();
                txtHeight.Text = index.Height.ToString();
                /*
                string dirPath = ConfigINI["INIT"]["DirGraficos"];
                string filePath = System.IO.Path.Combine(dirPath, index.ImageNum.ToString());
                if (System.IO.File.Exists(filePath + ".bmp"))
                    filePath += ".bmp";
                else if (System.IO.File.Exists(filePath + ".png"))
                    filePath += ".png";
                else
                    return;
                */
                string filePath = GetImageFilename(index.ImageNum);
                if (filePath.Length == 0)
                {
                    return;
                } else if (cacheFile != filePath)
                {
                    Bitmap myImg = new Bitmap(filePath);
                    myImg.MakeTransparent();
                    cacheImage = myImg;
                    cacheFile = filePath;
                }
                // Dibujar frame
                Bitmap tmpImage;
                tmpImage = new Bitmap(cacheImage);
                using (Graphics G = Graphics.FromImage(tmpImage))
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    int tmpWidth = index.Width;
                    int tmpHeight = index.Height;
                    if (index.Width >= tmpWidth)
                    {
                        tmpWidth = index.Width - 1;
                    }
                    if (index.Height >= tmpHeight)
                    {
                        tmpHeight = index.Height - 1;
                    }
                    G.DrawRectangle(pen, index.PosX, index.PosY, tmpWidth, tmpHeight);
                }
                picImage.Image = tmpImage;
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
            } else if (index.NumFrames > 1)
            {
                rdoAnim.Checked = true;
                tableLayoutPanel9.Visible = true;
                tableLayoutPanel10.Visible = false;
                lstFrames.Items.Clear();
                foreach (int frame in index.Frames)
                {
                    lstFrames.Items.Add(frame.ToString());
                }
                txtSpeed.Text = index.Speed.ToString();
            }
        }

        private string GetImageFilename(int ImageNum)
        {
            string dirPath = ConfigINI["INIT"]["DirGraficos"];
            string filePath = System.IO.Path.Combine(dirPath, ImageNum.ToString());
            if (System.IO.File.Exists(filePath + ".bmp"))
                filePath += ".bmp";
            else if (System.IO.File.Exists(filePath + ".png"))
                filePath += ".png";
            else
                return "";
            return filePath;
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
                /*
                string filePath = System.IO.Path.Combine(dirPath, index.ImageNum.ToString());
                if (System.IO.File.Exists(filePath + ".bmp"))
                    filePath += ".bmp";
                else if (System.IO.File.Exists(filePath + ".png"))
                    filePath += ".png";
                else
                    return;
                */
                string filePath = GetImageFilename(index.ImageNum);
                if (filePath.Length == 0)
                {
                    return;
                }
                else if (cacheFile != filePath)
                {
                    Bitmap myImg = new Bitmap(filePath);
                    myImg.MakeTransparent();
                    cacheImage = myImg;
                    cacheFile = filePath;  
                }
                if (timerAnim.Enabled==false) { 
                    if (index.PosX < 0)
                    {
                        MessageBox.Show("El movimiento horizontal debe ser positivo.");
                        return;
                    } else if (index.PosY< 0)
                    {
                        MessageBox.Show("El movimiento vertical debe ser positivo.");
                        return;
                    }
                    if (cacheImage.Width < index.Width + index.PosX)
                    {
                        MessageBox.Show("Se esta desplazando fuera de la imagen horizontalmente.");
                        return;
                    } else if (cacheImage.Height < index.Height + index.PosY)
                    {
                        MessageBox.Show("Se esta desplazando fuera de la imagen verticalmente.");
                        return;
                    }
                }
                var newImg = cacheImage.Clone(new Rectangle { X = index.PosX, Y = index.PosY, Width = index.Width, Height = index.Height }, cacheImage.PixelFormat);
                int newWidth = index.Width * zoomBar.Value;
                int newHeight = index.Height * zoomBar.Value;
                Bitmap resizedImg = new Bitmap(newWidth, newHeight);
                using (Graphics gr = Graphics.FromImage(resizedImg))
                {
                    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    gr.DrawImage(newImg, new Rectangle(0, 0, newWidth, newHeight));
                };
                if (newWidth > picImg.Height || newHeight > picImg.Width)
                    picImg.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    picImg.SizeMode = PictureBoxSizeMode.Normal;
                picImg.Image = resizedImg;
            } else if (index.NumFrames > 1)
            {
                timerAnim.Enabled = false;
                timerAnim.Tag = imgSelected;
                int speed = Convert.ToInt32(index.Speed);
                if (speed <= 10)
                    speed = speed * 200;
                speed = speed / 2;
                if (speed<=0)
                    speed = 1;
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
                tableLayoutPanel10.Visible = false;
                tableLayoutPanel9.Visible = true;
            }
        }

        private void rdoStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStatic.Checked)
            {
                rdoAnim.Checked = false;
                tableLayoutPanel10.Visible = true;
                tableLayoutPanel9.Visible = false;
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

        private void UpdateIndex(int i, IndexStruct s)
        {
            indexList[i] = s;
            LoadIndice(imgSelected);
            LoadImg(imgSelected);
        }

        private void cmdAplicarIndice_Click(object sender, EventArgs e)
        {
            IndexStruct s = new IndexStruct();
            int grhNumber;
            bool isNumeric = int.TryParse(txtGrhNum.Text, out grhNumber);
            if (isNumeric && grhNumber>0) 
            {
                // Armar Struct
                s.NumFrames = 0;
                s.Frames = new int[0];
                s.Speed = 0;
                s.ImageNum = 0;
                s.PosX = 0;
                s.PosY = 0;
                s.Width = 0;
                s.Height = 0;
                if (rdoStatic.Checked)
                {
                    int imageNum;
                    int.TryParse(txtImageNum.Text, out imageNum);
                    if (imageNum > 0)
                    {
                        s.NumFrames = 1;
                        s.ImageNum = imageNum;
                        int posX;
                        int.TryParse(txtPosX.Text, out posX);
                        s.PosX = posX;
                        int posY;
                        int.TryParse(txtPosY.Text, out posY);
                        s.PosY = posY;
                        int width;
                        int.TryParse(txtWidth.Text, out width);
                        s.Width = width;
                        int height;
                        int.TryParse(txtHeight.Text, out height);
                        s.Height = height;
                    }
                }
                else if (rdoAnim.Checked)
                {
                    int numFrames = lstFrames.Items.Count;
                    if (numFrames > 0)
                    {
                        s.NumFrames = numFrames;
                        s.Frames = new int[numFrames];
                        int n = 0;
                        do
                        {
                            int grh;
                            int.TryParse(lstFrames.Items[n].ToString(), out grh);
                            s.Frames[n] = grh;
                            n++;
                        } while (n < numFrames);
                        Single speed;
                        txtSpeed.Text = txtSpeed.Text.Replace(".", ","); // Fix comma
                        float.TryParse(txtSpeed.Text, out speed);
                        s.Speed = speed;
                    }
                }
                // Intentar actualizar
                bool updated = false;
                int maxGrhUsed = 0;
                for (int i = 0; i < indexList.Count; i++)
                {
                    if (indexList[i].GrhNum == grhNumber)
                    {
                        updated = true;
                        s.GrhNum = grhNumber;
                        UpdateIndex(i, s);
                        LoadImg(imgSelected);
                        break;
                    }
                }
                if (updated == false)
                {
                    if (grhNumber> indexList.Count) {
                        if (MaxGrh < grhNumber)
                        {
                            MaxGrh = grhNumber;
                        }
                        s.GrhNum = grhNumber;
                        indexList.Add(s);
                        imgSelected = s.GrhNum;
                        LoadIndice(imgSelected);
                    }
                }
                updated = false;
                for (int i = 0; i < lstIndices.Items.Count; i++)
                {
                    string actual = lstIndices.Items[i].ToString();
                    if (actual.StartsWith(grhNumber.ToString()+"\t"))
                    {
                        string tag = TagIndice(indexList[i]);
                        lstIndices.Items.Add(tag);
                        break;
                    }
                }
                if (updated==false)
                {
                    FilterIndices();
                }
                MaxGrhUsed();
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
            if (index.Frames.Length == 0)
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

        void MaxGrhUsed()
        {
            int maxGrhUsed = 0;
            foreach (IndexStruct i in indexList)
            {
                if (i.NumFrames > 0)
                {
                    if (maxGrhUsed < i.GrhNum)
                    {
                        maxGrhUsed = i.GrhNum;
                    }
                }
            }
            MaxGrh = maxGrhUsed;
            lblIndice.Text = "Indices: " + MaxGrh.ToString();
        }

        private void btnSaveIND_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar indice";
            saveFileDialog.DefaultExt = "";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Archivo de indice INI (*.ini)|*.ini|Archivo de indice JSON (*.json)|*.json|Archivo de indice IND (Nuevo) (*.ind)|*.ind|Archivo de indice IND (Viejo) (*._ind)|*._ind|Todos los archivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            string filepath = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
            }
            if (filepath.Length == 0)
            {
                return;
            }

            MaxGrhUsed();

                string name = System.IO.Path.GetFileName(filepath);
            if (name.EndsWith(".ind"))
            {
                using (BinaryWriter binWriter = new BinaryWriter(File.Open(filepath, FileMode.Create)))
                {
                    binWriter.Write(Convert.ToInt32(txtVer.Text));
                    binWriter.Write(MaxGrh);
                    foreach (IndexStruct i in indexList)
                    {
                        if (i.NumFrames > 0)
                        {
                            binWriter.Write(i.GrhNum);
                            if (i.NumFrames > 1)
                            {
                                binWriter.Write(Convert.ToInt16(i.Frames.Length));
                                for (int t = 0; t < i.NumFrames; t++)
                                {
                                    binWriter.Write(i.Frames[t]);
                                }
                                binWriter.Write(Convert.ToSingle(i.Speed));
                            }
                            else
                            {
                                binWriter.Write(Convert.ToInt16(i.NumFrames));
                                binWriter.Write(i.ImageNum);
                                binWriter.Write(Convert.ToInt16(i.PosX));
                                binWriter.Write(Convert.ToInt16(i.PosY));
                                binWriter.Write(Convert.ToInt16(i.Width));
                                binWriter.Write(Convert.ToInt16(i.Height));
                            }
                        }

                    }
                }
            }
            else if (name.EndsWith("._ind"))
            {
                foreach (IndexStruct i in indexList)
                {
                    if (i.GrhNum > 32767)
                    {
                        MessageBox.Show("El Grh " + i.GrhNum.ToString() + " no es compatible con el formato.");
                        return;
                    }
                    if (i.NumFrames > 1)
                    {
                        for (int t = 0; t < i.NumFrames; t++)
                        {
                            if (i.Frames[t] > 32767)
                            {
                                MessageBox.Show("La animación Grh " + i.GrhNum.ToString() + " tiene un cuadro no compatible con el formato.");
                                return;
                            }
                        }
                        if (i.Speed > 32767)
                        {
                            MessageBox.Show("La animación Grh " + i.GrhNum.ToString() + " tiene una velocidad no compatible con el formato.");
                            return;
                        }
                    } else { 
                        if (i.ImageNum > 32767)
                        {
                            MessageBox.Show("El Grh " + i.GrhNum.ToString() + " tiene una imagen de valor no es compatible con el formato.");
                            return;
                        }
                    }
                }
                using (BinaryWriter binWriter = new BinaryWriter(File.Open(filepath, FileMode.Create)))
                {
                    byte[] cabecera = Encoding.ASCII.GetBytes("IndeXAO by ^[GS]^ - www.gs-zone.org IndeXAO by ^[GS]^ - www.gs-zone.org IndeXAO by ^[GS]^ - www.gs-zone.org IndeXAO by ^[GS]^ - www.gs-zone.org IndeXAO by ^[GS]^ - www.gs-zone.org IndeXAO by ^[GS]^ - www.gs-zone.org                                        "); // 255 fixed
                    binWriter.Write(cabecera);
                    var tLong = new byte[4];
                    binWriter.Write(tLong);
                    binWriter.Write(tLong);
                    var tInt = new byte[2];
                    binWriter.Write(tInt);
                    binWriter.Write(tInt);
                    binWriter.Write(tInt);
                    binWriter.Write(tInt);
                    binWriter.Write(tInt);
                    foreach (IndexStruct i in indexList)
                    {
                        if (i.NumFrames > 0)
                        {
                            binWriter.Write(Convert.ToInt16(i.GrhNum));
                            if (i.NumFrames > 1)
                            {
                                binWriter.Write(Convert.ToInt16(i.Frames.Length));
                                for (int t = 0; t < i.NumFrames; t++)
                                {
                                    binWriter.Write(Convert.ToInt16(i.Frames[t]));
                                }
                                binWriter.Write(Convert.ToInt16(i.Speed));
                            }
                            else
                            {
                                binWriter.Write(Convert.ToInt16(i.NumFrames));
                                binWriter.Write(Convert.ToInt16(i.ImageNum));
                                binWriter.Write(Convert.ToInt16(i.PosX));
                                binWriter.Write(Convert.ToInt16(i.PosY));
                                binWriter.Write(Convert.ToInt16(i.Width));
                                binWriter.Write(Convert.ToInt16(i.Height));
                            }
                        }

                    }
                }
            }
            else if (name.EndsWith(".json"))
            {
                MainJsonStruct IndJson = new MainJsonStruct();
                IndJson.MaxGrh = MaxGrh;
                IndJson.Version = Convert.ToInt32(txtVer.Text);
                IndJson.Graphics = indexList;

                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                settings.DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore;
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(IndJson, settings);

                File.WriteAllTextAsync(filepath, jsonString);
            }
            else
            {
                var parser = new IniParser.FileIniDataParser();
                IniParser.Model.IniData IndINI = new IniParser.Model.IniData();
                IndINI["INIT"]["NumGrh"] = MaxGrh.ToString();
                IndINI["INIT"]["Version"] = txtVer.Text;
                foreach (IndexStruct i in indexList)
                {
                    string grhLine = "";
                    if (i.NumFrames > 0)
                    {
                        if (i.NumFrames > 1)
                        {
                            grhLine = i.Frames.Length.ToString() + "-";
                            for (int t = 0; t < i.NumFrames; t++)
                            {
                                grhLine += i.Frames[t].ToString() + "-";
                            }
                            grhLine += i.Speed.ToString();
                        }
                        else
                        {
                            grhLine = i.NumFrames.ToString() + "-";
                            grhLine += i.ImageNum.ToString() + "-";
                            grhLine += i.PosX.ToString() + "-";
                            grhLine += i.PosY.ToString() + "-";
                            grhLine += i.Width.ToString() + "-";
                            grhLine += i.Height.ToString();
                        }
                    }
                    IndINI["Graphics"]["Grh" + i.GrhNum.ToString()] = grhLine;
                }
                parser.WriteFile(filepath, IndINI);
            }
            MessageBox.Show("El Indice " + filepath + " ha sido exportado con exito.");
        }

        private void txtGraficos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGraficos_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", ConfigINI["INIT"]["DirGraficos"].ToString());
        }

        private void txtIndice_DoubleClick(object sender, EventArgs e)
        {
            if (System.IO.Path.GetExtension(ConfigINI["INIT"]["DirIndice"].ToString()) == ".ini")
            {
                System.Diagnostics.Process.Start("explorer.exe", ConfigINI["INIT"]["DirIndice"].ToString());
            } else
            {
                string path = System.IO.Path.GetDirectoryName(ConfigINI["INIT"]["DirIndice"].ToString());
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
            
        }

        private void txtImageNum_DoubleClick(object sender, EventArgs e)
        {
            String filePath = ConfigINI["INIT"]["DirGraficos"].ToString();
            if (System.IO.File.Exists(System.IO.Path.Combine(filePath, txtImageNum.Text + ".bmp")))
                filePath = System.IO.Path.Combine(filePath, txtImageNum.Text + ".bmp");
            else if (System.IO.File.Exists(System.IO.Path.Combine(filePath, txtImageNum.Text + ".png")))
                filePath = System.IO.Path.Combine(filePath, txtImageNum.Text + ".png");
            System.Diagnostics.Process.Start("explorer.exe", filePath);              
        }

        private void txtImageNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsole.Visible = !frmConsole.Visible;
        }

        private string TagIndice(IndexStruct i)
        {
            string tag = "";
            if (i.NumFrames == 0)
            {
                tag = "[VACIO]";
            }
            else if (i.NumFrames == 1)
            {
                tag = i.ImageNum.ToString();
            }
            else if (i.NumFrames > 1)
            {
                tag = "[Animación] x" + i.NumFrames.ToString();
            }
            tag = i.GrhNum.ToString() + "\t" + tag;
            return tag;
        }

        void FilterIndices()
        {
            // (GRH)
            // [BMP]
            if (txtGrhFilter.Text.Length < 2)
            {
                if (lstIndices.Items.Count != indexList.Count)
                {
                    lstIndices.BeginUpdate();
                    lstIndices.Items.Clear();
                    for (int i = 0; i < indexList.Count; i++)
                    {
                        string tag = TagIndice(indexList[i]);
                        lstIndices.Items.Add(tag);
                    }
                    lstIndices.EndUpdate();
                    for (int i = 0; i < lstIndices.Items.Count; i++)
                    {
                        int val = Convert.ToInt32(lstIndices.Items[i].ToString().Split("\t")[0]);
                        if (val == imgSelected)
                        {
                            lstIndices.SelectedItem = lstIndices.Items[i];
                            break;
                        }
                    }
                }
                return;
            }
            lstIndices.BeginUpdate();
            lstIndices.Items.Clear();
            for (int i = 0; i < indexList.Count; i++)
            {
                Boolean found = false;
                string key = txtGrhFilter.Text.ToLower();
                string tag = "";

                if (indexList[i].NumFrames == 0)
                {
                    tag = "[VACIO]";
                }
                else if (indexList[i].NumFrames == 1)
                {
                    tag = indexList[i].ImageNum.ToString();
                    if (key.StartsWith("[") && key.EndsWith("]"))
                    {
                        found = (tag.ToLower().Contains(key.Substring(1, key.Length - 2)));
                    }
                }
                else if (indexList[i].NumFrames > 1)
                {
                    tag = "[Animación] x" + indexList[i].NumFrames.ToString();
                }
                string val = indexList[i].GrhNum.ToString();
                if (key.StartsWith("(") && key.EndsWith(")"))
                {
                    found = (val.ToLower().Contains(key.Substring(1, key.Length - 2)));
                }
                val += "\t" + tag;

                if (!(key.Contains("[") || key.Contains("(")))
                {
                    found = (val.ToLower().Contains(key));
                }
                if (found)
                {
                    lstIndices.Items.Add(val);
                }
            }
            lstIndices.EndUpdate();
            for (int i = 0; i < lstIndices.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstIndices.Items[i].ToString().Split("\t")[0]);
                if (val == imgSelected)
                {
                    lstIndices.SelectedItem = lstIndices.Items[i];
                    break;
                }
            }
        }

        private void txtGrhFilter_TextChanged(object sender, EventArgs e)
        {
            FilterIndices();
        }

        private void lstIndices_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtGrhFilter_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < lstIndices.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstIndices.Items[i].ToString().Split("\t")[0]);
                if (val == imgSelected)
                {
                    if (i > 0) { 
                    lstIndices.SelectedItem = lstIndices.Items[i-1];
                    } else if (i < lstIndices.Items.Count) 
                    {
                        lstIndices.SelectedItem = lstIndices.Items[i + 1];
                    }
                    lstIndices.SelectedItem = lstIndices.Items[i];
                    break;
                }
            }
        }

        private void lblGraficos_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(ConfigINI["INIT"]["DirGraficos"]))
            {
                CargarDirGraficos(ConfigINI["INIT"]["DirGraficos"]);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            IndexStruct newIndex = new IndexStruct();
            MaxGrh++;
            lblIndice.Text = "Indices: " + MaxGrh.ToString();
            newIndex.GrhNum = MaxGrh;
            newIndex.NumFrames = 1;
            indexList.Add(newIndex);
            FilterIndices();
        }
    }
}
