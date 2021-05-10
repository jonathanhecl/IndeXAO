
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
            this.components = new System.ComponentModel.Container();
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
            this.cmdCambiarFondo = new System.Windows.Forms.Button();
            this.grpBoxIndex = new System.Windows.Forms.GroupBox();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdUp = new System.Windows.Forms.Button();
            this.txtGrhNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAplicarIndice = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.lstFrames = new System.Windows.Forms.ListBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoStatic = new System.Windows.Forms.RadioButton();
            this.rdoAnim = new System.Windows.Forms.RadioButton();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdEditGrh = new System.Windows.Forms.Button();
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.grpBoxIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGraficos
            // 
            this.txtGraficos.Location = new System.Drawing.Point(122, 10);
            this.txtGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.txtGraficos.Name = "txtGraficos";
            this.txtGraficos.ReadOnly = true;
            this.txtGraficos.Size = new System.Drawing.Size(389, 27);
            this.txtGraficos.TabIndex = 0;
            // 
            // cmdGraficos
            // 
            this.cmdGraficos.Location = new System.Drawing.Point(9, 10);
            this.cmdGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGraficos.Name = "cmdGraficos";
            this.cmdGraficos.Size = new System.Drawing.Size(109, 25);
            this.cmdGraficos.TabIndex = 1;
            this.cmdGraficos.Text = "Dir. &Gráficos";
            this.cmdGraficos.UseVisualStyleBackColor = true;
            this.cmdGraficos.Click += new System.EventHandler(this.cmdGraficos_Click);
            // 
            // cmdIndice
            // 
            this.cmdIndice.Location = new System.Drawing.Point(10, 39);
            this.cmdIndice.Margin = new System.Windows.Forms.Padding(2);
            this.cmdIndice.Name = "cmdIndice";
            this.cmdIndice.Size = new System.Drawing.Size(109, 25);
            this.cmdIndice.TabIndex = 3;
            this.cmdIndice.Text = "&Ind. Gráficos";
            this.cmdIndice.UseVisualStyleBackColor = true;
            this.cmdIndice.Click += new System.EventHandler(this.cmdIndice_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(123, 39);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(388, 27);
            this.txtIndice.TabIndex = 2;
            // 
            // lblGraficos
            // 
            this.lblGraficos.AutoSize = true;
            this.lblGraficos.Location = new System.Drawing.Point(515, 12);
            this.lblGraficos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraficos.Name = "lblGraficos";
            this.lblGraficos.Size = new System.Drawing.Size(78, 20);
            this.lblGraficos.TabIndex = 4;
            this.lblGraficos.Text = "Graficos: 0";
            // 
            // listGraficos
            // 
            this.listGraficos.AutoArrange = false;
            this.listGraficos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listGraficos.HideSelection = false;
            this.listGraficos.LabelWrap = false;
            this.listGraficos.Location = new System.Drawing.Point(637, 440);
            this.listGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.listGraficos.MultiSelect = false;
            this.listGraficos.Name = "listGraficos";
            this.listGraficos.ShowGroups = false;
            this.listGraficos.Size = new System.Drawing.Size(134, 102);
            this.listGraficos.TabIndex = 5;
            this.listGraficos.TileSize = new System.Drawing.Size(128, 32);
            this.listGraficos.UseCompatibleStateImageBehavior = false;
            this.listGraficos.View = System.Windows.Forms.View.Tile;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(515, 42);
            this.lblIndice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(70, 20);
            this.lblIndice.TabIndex = 6;
            this.lblIndice.Text = "Indices: 0";
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(881, 42);
            this.txtVer.Margin = new System.Windows.Forms.Padding(2);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(55, 27);
            this.txtVer.TabIndex = 7;
            // 
            // lstIndices
            // 
            this.lstIndices.FormattingEnabled = true;
            this.lstIndices.ItemHeight = 20;
            this.lstIndices.Location = new System.Drawing.Point(14, 78);
            this.lstIndices.Margin = new System.Windows.Forms.Padding(2);
            this.lstIndices.Name = "lstIndices";
            this.lstIndices.Size = new System.Drawing.Size(172, 424);
            this.lstIndices.TabIndex = 8;
            this.lstIndices.SelectedIndexChanged += new System.EventHandler(this.lstIndices_SelectedIndexChanged);
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.Lime;
            this.picImg.Location = new System.Drawing.Point(206, 78);
            this.picImg.Margin = new System.Windows.Forms.Padding(2);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(387, 402);
            this.picImg.TabIndex = 9;
            this.picImg.TabStop = false;
            // 
            // zoomBar
            // 
            this.zoomBar.Location = new System.Drawing.Point(206, 494);
            this.zoomBar.Margin = new System.Windows.Forms.Padding(2);
            this.zoomBar.Minimum = 1;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(218, 56);
            this.zoomBar.TabIndex = 10;
            this.zoomBar.Value = 1;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // cmdCambiarFondo
            // 
            this.cmdCambiarFondo.Location = new System.Drawing.Point(429, 494);
            this.cmdCambiarFondo.Name = "cmdCambiarFondo";
            this.cmdCambiarFondo.Size = new System.Drawing.Size(164, 34);
            this.cmdCambiarFondo.TabIndex = 12;
            this.cmdCambiarFondo.Text = "Cambiar Fondo";
            this.cmdCambiarFondo.UseVisualStyleBackColor = true;
            this.cmdCambiarFondo.Click += new System.EventHandler(this.cmdCambiarFondo_Click);
            // 
            // grpBoxIndex
            // 
            this.grpBoxIndex.Controls.Add(this.cmdDown);
            this.grpBoxIndex.Controls.Add(this.cmdUp);
            this.grpBoxIndex.Controls.Add(this.txtGrhNum);
            this.grpBoxIndex.Controls.Add(this.label8);
            this.grpBoxIndex.Controls.Add(this.cmdAplicarIndice);
            this.grpBoxIndex.Controls.Add(this.txtSpeed);
            this.grpBoxIndex.Controls.Add(this.label7);
            this.grpBoxIndex.Controls.Add(this.cmdRemove);
            this.grpBoxIndex.Controls.Add(this.lstFrames);
            this.grpBoxIndex.Controls.Add(this.picImage);
            this.grpBoxIndex.Controls.Add(this.txtHeight);
            this.grpBoxIndex.Controls.Add(this.txtWidth);
            this.grpBoxIndex.Controls.Add(this.txtPosY);
            this.grpBoxIndex.Controls.Add(this.txtPosX);
            this.grpBoxIndex.Controls.Add(this.label4);
            this.grpBoxIndex.Controls.Add(this.label5);
            this.grpBoxIndex.Controls.Add(this.label3);
            this.grpBoxIndex.Controls.Add(this.label2);
            this.grpBoxIndex.Controls.Add(this.txtImageNum);
            this.grpBoxIndex.Controls.Add(this.label1);
            this.grpBoxIndex.Controls.Add(this.rdoStatic);
            this.grpBoxIndex.Controls.Add(this.rdoAnim);
            this.grpBoxIndex.Location = new System.Drawing.Point(607, 80);
            this.grpBoxIndex.Name = "grpBoxIndex";
            this.grpBoxIndex.Size = new System.Drawing.Size(328, 344);
            this.grpBoxIndex.TabIndex = 13;
            this.grpBoxIndex.TabStop = false;
            this.grpBoxIndex.Text = "Indice";
            this.grpBoxIndex.DragDrop += new System.Windows.Forms.DragEventHandler(this.grpBoxIndex_DragDrop);
            this.grpBoxIndex.DragEnter += new System.Windows.Forms.DragEventHandler(this.grpBoxIndex_DragEnter);
            this.grpBoxIndex.Enter += new System.EventHandler(this.grpBoxIndex_Enter);
            // 
            // cmdDown
            // 
            this.cmdDown.Location = new System.Drawing.Point(245, 116);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(65, 33);
            this.cmdDown.TabIndex = 24;
            this.cmdDown.Text = "&Bajar";
            this.cmdDown.UseVisualStyleBackColor = true;
            this.cmdDown.Visible = false;
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.Location = new System.Drawing.Point(170, 116);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(65, 33);
            this.cmdUp.TabIndex = 23;
            this.cmdUp.Text = "&Subir";
            this.cmdUp.UseVisualStyleBackColor = true;
            this.cmdUp.Visible = false;
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // txtGrhNum
            // 
            this.txtGrhNum.Location = new System.Drawing.Point(187, 23);
            this.txtGrhNum.Name = "txtGrhNum";
            this.txtGrhNum.Size = new System.Drawing.Size(121, 27);
            this.txtGrhNum.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Número de Indice:";
            // 
            // cmdAplicarIndice
            // 
            this.cmdAplicarIndice.Location = new System.Drawing.Point(182, 290);
            this.cmdAplicarIndice.Name = "cmdAplicarIndice";
            this.cmdAplicarIndice.Size = new System.Drawing.Size(127, 35);
            this.cmdAplicarIndice.TabIndex = 20;
            this.cmdAplicarIndice.Text = "A&plicar";
            this.cmdAplicarIndice.UseVisualStyleBackColor = true;
            this.cmdAplicarIndice.Click += new System.EventHandler(this.cmdAplicarIndice_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(208, 155);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(102, 27);
            this.txtSpeed.TabIndex = 19;
            this.txtSpeed.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Vel.";
            this.label7.Visible = false;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(170, 86);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(140, 32);
            this.cmdRemove.TabIndex = 17;
            this.cmdRemove.Text = "&Remover";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Visible = false;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // lstFrames
            // 
            this.lstFrames.FormattingEnabled = true;
            this.lstFrames.ItemHeight = 20;
            this.lstFrames.Location = new System.Drawing.Point(15, 86);
            this.lstFrames.Name = "lstFrames";
            this.lstFrames.Size = new System.Drawing.Size(149, 104);
            this.lstFrames.TabIndex = 13;
            this.lstFrames.Visible = false;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.Location = new System.Drawing.Point(15, 196);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(149, 130);
            this.picImage.TabIndex = 12;
            this.picImage.TabStop = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(231, 155);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(79, 27);
            this.txtHeight.TabIndex = 11;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(231, 126);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(79, 27);
            this.txtWidth.TabIndex = 10;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(66, 155);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(79, 27);
            this.txtPosY.TabIndex = 9;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(66, 126);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(79, 27);
            this.txtPosX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "PosY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PosX:";
            // 
            // txtImageNum
            // 
            this.txtImageNum.Location = new System.Drawing.Point(90, 93);
            this.txtImageNum.Name = "txtImageNum";
            this.txtImageNum.Size = new System.Drawing.Size(220, 27);
            this.txtImageNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagen:";
            // 
            // rdoStatic
            // 
            this.rdoStatic.AutoSize = true;
            this.rdoStatic.Location = new System.Drawing.Point(15, 53);
            this.rdoStatic.Name = "rdoStatic";
            this.rdoStatic.Size = new System.Drawing.Size(81, 24);
            this.rdoStatic.TabIndex = 1;
            this.rdoStatic.TabStop = true;
            this.rdoStatic.Text = "Estatica";
            this.rdoStatic.UseVisualStyleBackColor = true;
            this.rdoStatic.CheckedChanged += new System.EventHandler(this.rdoStatic_CheckedChanged);
            // 
            // rdoAnim
            // 
            this.rdoAnim.AutoSize = true;
            this.rdoAnim.Location = new System.Drawing.Point(170, 53);
            this.rdoAnim.Name = "rdoAnim";
            this.rdoAnim.Size = new System.Drawing.Size(101, 24);
            this.rdoAnim.TabIndex = 0;
            this.rdoAnim.TabStop = true;
            this.rdoAnim.Text = "Animación";
            this.rdoAnim.UseVisualStyleBackColor = true;
            this.rdoAnim.CheckedChanged += new System.EventHandler(this.rdoAnim_CheckedChanged);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(120, 507);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(66, 33);
            this.cmdAdd.TabIndex = 16;
            this.cmdAdd.Text = "&Añadir";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEditGrh
            // 
            this.cmdEditGrh.Location = new System.Drawing.Point(16, 507);
            this.cmdEditGrh.Name = "cmdEditGrh";
            this.cmdEditGrh.Size = new System.Drawing.Size(103, 34);
            this.cmdEditGrh.TabIndex = 14;
            this.cmdEditGrh.Text = "&Editar";
            this.cmdEditGrh.UseVisualStyleBackColor = true;
            this.cmdEditGrh.Click += new System.EventHandler(this.cmdEditGrh_Click);
            // 
            // timerAnim
            // 
            this.timerAnim.Tick += new System.EventHandler(this.timerAnim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 556);
            this.Controls.Add(this.cmdEditGrh);
            this.Controls.Add(this.grpBoxIndex);
            this.Controls.Add(this.cmdCambiarFondo);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.lstIndices);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.listGraficos);
            this.Controls.Add(this.lblGraficos);
            this.Controls.Add(this.cmdIndice);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.cmdGraficos);
            this.Controls.Add(this.txtGraficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndeXAO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.grpBoxIndex.ResumeLayout(false);
            this.grpBoxIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
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
        private System.Windows.Forms.Button cmdCambiarFondo;
        private System.Windows.Forms.GroupBox grpBoxIndex;
        private System.Windows.Forms.RadioButton rdoStatic;
        private System.Windows.Forms.RadioButton rdoAnim;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo;
        private System.Windows.Forms.RadioButton Radio;
        private System.Windows.Forms.TextBox txtImageNum;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ListBox lstFrames;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAplicarIndice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGrhNum;
        private System.Windows.Forms.Button cmdEditGrh;
        private System.Windows.Forms.Timer timerAnim;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Button cmdUp;
    }
}

