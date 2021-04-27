
namespace IndeXAO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGraficos = new System.Windows.Forms.TextBox();
            this.cmdGraficos = new System.Windows.Forms.Button();
            this.cmdIndice = new System.Windows.Forms.Button();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.lblGraficos = new System.Windows.Forms.Label();
            this.listGraficos = new System.Windows.Forms.ListView();
            this.lblIndice = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.lstIndices = new System.Windows.Forms.ListBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGraficos
            // 
            this.txtGraficos.Location = new System.Drawing.Point(153, 12);
            this.txtGraficos.Name = "txtGraficos";
            this.txtGraficos.ReadOnly = true;
            this.txtGraficos.Size = new System.Drawing.Size(485, 31);
            this.txtGraficos.TabIndex = 0;
            // 
            // cmdGraficos
            // 
            this.cmdGraficos.Location = new System.Drawing.Point(11, 12);
            this.cmdGraficos.Name = "cmdGraficos";
            this.cmdGraficos.Size = new System.Drawing.Size(136, 31);
            this.cmdGraficos.TabIndex = 1;
            this.cmdGraficos.Text = "Dir. &Gráficos";
            this.cmdGraficos.UseVisualStyleBackColor = true;
            this.cmdGraficos.Click += new System.EventHandler(this.cmdGraficos_Click);
            // 
            // cmdIndice
            // 
            this.cmdIndice.Location = new System.Drawing.Point(12, 49);
            this.cmdIndice.Name = "cmdIndice";
            this.cmdIndice.Size = new System.Drawing.Size(136, 31);
            this.cmdIndice.TabIndex = 3;
            this.cmdIndice.Text = "&Ind. Gráficos";
            this.cmdIndice.UseVisualStyleBackColor = true;
            this.cmdIndice.Click += new System.EventHandler(this.cmdIndice_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(154, 49);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(484, 31);
            this.txtIndice.TabIndex = 2;
            // 
            // lblGraficos
            // 
            this.lblGraficos.AutoSize = true;
            this.lblGraficos.Location = new System.Drawing.Point(644, 15);
            this.lblGraficos.Name = "lblGraficos";
            this.lblGraficos.Size = new System.Drawing.Size(95, 25);
            this.lblGraficos.TabIndex = 4;
            this.lblGraficos.Text = "Graficos: 0";
            // 
            // listGraficos
            // 
            this.listGraficos.AutoArrange = false;
            this.listGraficos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listGraficos.HideSelection = false;
            this.listGraficos.LabelWrap = false;
            this.listGraficos.Location = new System.Drawing.Point(612, 94);
            this.listGraficos.MultiSelect = false;
            this.listGraficos.Name = "listGraficos";
            this.listGraficos.ShowGroups = false;
            this.listGraficos.Size = new System.Drawing.Size(167, 339);
            this.listGraficos.TabIndex = 5;
            this.listGraficos.TileSize = new System.Drawing.Size(128, 32);
            this.listGraficos.UseCompatibleStateImageBehavior = false;
            this.listGraficos.View = System.Windows.Forms.View.Tile;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(644, 52);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(86, 25);
            this.lblIndice.TabIndex = 6;
            this.lblIndice.Text = "Indices: 0";
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(538, 94);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(68, 31);
            this.txtVer.TabIndex = 7;
            // 
            // lstIndices
            // 
            this.lstIndices.FormattingEnabled = true;
            this.lstIndices.ItemHeight = 25;
            this.lstIndices.Location = new System.Drawing.Point(18, 98);
            this.lstIndices.Name = "lstIndices";
            this.lstIndices.Size = new System.Drawing.Size(233, 329);
            this.lstIndices.TabIndex = 8;
            this.lstIndices.SelectedIndexChanged += new System.EventHandler(this.lstIndices_SelectedIndexChanged);
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.Lime;
            this.picImg.Location = new System.Drawing.Point(257, 98);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(275, 278);
            this.picImg.TabIndex = 9;
            this.picImg.TabStop = false;
            // 
            // zoomBar
            // 
            this.zoomBar.Location = new System.Drawing.Point(257, 382);
            this.zoomBar.Minimum = 1;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(273, 69);
            this.zoomBar.TabIndex = 10;
            this.zoomBar.Value = 1;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.lstIndices);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.listGraficos);
            this.Controls.Add(this.lblGraficos);
            this.Controls.Add(this.cmdIndice);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cmdGraficos);
            this.Controls.Add(this.txtGraficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndeXAO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGraficos;
        private System.Windows.Forms.Button cmdGraficos;
        private System.Windows.Forms.Button cmdIndice;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label lblGraficos;
        private System.Windows.Forms.ListView listGraficos;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.ListBox lstIndices;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.TrackBar zoomBar;
    }
}

