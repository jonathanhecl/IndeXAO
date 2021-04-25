using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;

namespace IndeXAO
{
    public partial class Form1 : Form
    {

        string configFile = "config.ini";
        IConfigurationRoot ini;
        string DirGraphics;
        string FileIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGraficos_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                txtGraficos.Text = folderBrowserDialog.SelectedPath;
                //ini.IniWriteValue("INIT", "DirGraphics", txtGraficos.Text);
                string[] files = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath);
                int grh = 0;
                //listGraficos.BeginUpdate();
                listGraficos.Items.Clear();
                foreach (string file in files)
                {
                    string name = System.IO.Path.GetFileName(file);
                    if (name.EndsWith(".bmp") || name.EndsWith(".png"))
                    {
                        string first = System.IO.Path.GetFileNameWithoutExtension(name);
                        bool isNumeric = int.TryParse(first, out _);
                        if (isNumeric) {
                            listGraficos.Items.Add(name);
                            grh++;
                        }
                    }
                }
                //listGraficos.EndUpdate();
                lblGraficos.Text = "Gráficos: " + grh.ToString();
                /*
                if (File.Exists(Path.Combine(folderBrowserDialog.SelectedPath, "archivo.ini")))
                {
                    label7.Text = "Carpeta válida";
                }
                else
                {
                    label7.Text = "Carpeta invalida";
                }
                */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ini = new ConfigurationBuilder().
            //    SetBasePath(System.IO.Directory.GetCurrentDirectory()).
            //    AddIniFile(configFile).Build();
            //txtGraficos.Text = ini.IniReadValue("INIT", "DirGraficos");
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
                txtIndice.Text = openFileDialog.FileName;
                CargarIndice(txtIndice.Text);
            }

        }

        System.IO.MemoryStream fileMemory = new System.IO.MemoryStream();

        public void CargarIndice(string filepath)
        {
            string name = System.IO.Path.GetFileName(filepath);
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

                lstIndices.BeginUpdate();
                lstIndices.Items.Clear();
                for (int i = 1; i <= BitConverter.ToInt32(maxGrh); i++)
                {
                    lstIndices.Items.Add(i.ToString());
                }
                lstIndices.EndUpdate();


                bool exit = false;
                do
                {
                    // Grh number
                    var number = new byte[4];
                    fileMemory.Read(number, 0, (int)number.Length);

                    // Frames
                    var frames = new byte[2];
                    fileMemory.Read(frames, 0, (int)frames.Length);

                    if (BitConverter.ToInt16(frames) == 1)
                    {
                        var image = new byte[4];
                        fileMemory.Read(image, 0, (int)image.Length);
                        
                        var posX = new byte[2];
                        fileMemory.Read(posX, 0, (int)posX.Length);
                        var posY = new byte[2];
                        fileMemory.Read(posY, 0, (int)posY.Length);
                        var ancho = new byte[2];
                        fileMemory.Read(ancho, 0, (int)ancho.Length);
                        var alto = new byte[2];
                        fileMemory.Read(alto, 0, (int)alto.Length);

                        /*
                        lstIndices.Items.Add("Grh" + BitConverter.ToInt32(number).ToString() +
                            "=" + BitConverter.ToInt16(frames).ToString() + "-"+ 
                            BitConverter.ToInt32(image).ToString() + "-" +
                            BitConverter.ToInt16(posX).ToString() + "-" +
                            BitConverter.ToInt16(posY).ToString() + "-" +
                            BitConverter.ToInt16(ancho).ToString() + "-" +
                            BitConverter.ToInt16(alto).ToString());
                        */
                    }
                    else if (BitConverter.ToInt16(frames) > 1)
                    {
                        short maxFrames = BitConverter.ToInt16(frames);
                        string tempStr = "";
                        do
                        {
                            var grh = new byte[4];
                            fileMemory.Read(grh, 0, (int)grh.Length);
                            tempStr = tempStr + "-" + BitConverter.ToInt32(grh).ToString();
                            maxFrames--;
                        } while (maxFrames > 0);

                        var speed = new byte[4];
                        fileMemory.Read(speed, 0, (int)speed.Length);

                        /*
                        lstIndices.Items.Add("Grh" + BitConverter.ToInt32(number).ToString() +
                            "=" + BitConverter.ToInt16(frames).ToString() + 
                            tempStr + "-" + BitConverter.ToSingle(speed).ToString());
                        */
                    } else
                    {
                        exit = true;
                    }
                } while (!exit || fileMemory.Position > fileMemory.Length);

            } else if (name.EndsWith(".ini"))
            {
                MessageBox.Show("Es indice ini");
            } else
            {
                //
            }
        }
    }
}
