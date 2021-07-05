
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
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdIndice = new System.Windows.Forms.Button();
            this.cmdGraficos = new System.Windows.Forms.Button();
            this.txtGraficos = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btnSaveIND = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGraficos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGrhFilter = new System.Windows.Forms.TextBox();
            this.lstIndices = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdEditGrh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtImageNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lstFrames = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoStatic = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.txtGrhNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoAnim = new System.Windows.Forms.RadioButton();
            this.cmdAplicarIndice = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdCambiarFondo = new System.Windows.Forms.Button();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAnim
            // 
            this.timerAnim.Tick += new System.EventHandler(this.timerAnim_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(990, 76);
            this.panel1.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.28033F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.71968F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(978, 64);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.9434F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.0566F));
            this.tableLayoutPanel3.Controls.Add(this.cmdIndice, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmdGraficos, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtGraficos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtIndice, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(746, 64);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // cmdIndice
            // 
            this.cmdIndice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdIndice.Location = new System.Drawing.Point(2, 32);
            this.cmdIndice.Margin = new System.Windows.Forms.Padding(2);
            this.cmdIndice.Name = "cmdIndice";
            this.cmdIndice.Size = new System.Drawing.Size(152, 30);
            this.cmdIndice.TabIndex = 22;
            this.cmdIndice.Text = "&Ind. Gráficos";
            this.cmdIndice.UseVisualStyleBackColor = true;
            this.cmdIndice.Click += new System.EventHandler(this.cmdIndice_Click);
            // 
            // cmdGraficos
            // 
            this.cmdGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdGraficos.Location = new System.Drawing.Point(2, 2);
            this.cmdGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGraficos.Name = "cmdGraficos";
            this.cmdGraficos.Size = new System.Drawing.Size(152, 26);
            this.cmdGraficos.TabIndex = 21;
            this.cmdGraficos.Text = "&Dir. Gráficos";
            this.cmdGraficos.UseVisualStyleBackColor = true;
            this.cmdGraficos.Click += new System.EventHandler(this.cmdGraficos_Click);
            // 
            // txtGraficos
            // 
            this.txtGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGraficos.Location = new System.Drawing.Point(158, 2);
            this.txtGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.txtGraficos.Name = "txtGraficos";
            this.txtGraficos.ReadOnly = true;
            this.txtGraficos.Size = new System.Drawing.Size(586, 23);
            this.txtGraficos.TabIndex = 20;
            this.txtGraficos.TextChanged += new System.EventHandler(this.txtGraficos_TextChanged);
            this.txtGraficos.DoubleClick += new System.EventHandler(this.txtGraficos_DoubleClick);
            // 
            // txtIndice
            // 
            this.txtIndice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIndice.Location = new System.Drawing.Point(158, 32);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(586, 23);
            this.txtIndice.TabIndex = 23;
            this.txtIndice.DoubleClick += new System.EventHandler(this.txtIndice_DoubleClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.6F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.4F));
            this.tableLayoutPanel5.Controls.Add(this.lblIndice, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnSaveIND, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblGraficos, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(759, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(219, 64);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(2, 39);
            this.lblIndice.Margin = new System.Windows.Forms.Padding(2, 7, 2, 0);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(56, 15);
            this.lblIndice.TabIndex = 24;
            this.lblIndice.Text = "Indices: 0";
            // 
            // btnSaveIND
            // 
            this.btnSaveIND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveIND.Location = new System.Drawing.Point(145, 34);
            this.btnSaveIND.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveIND.Name = "btnSaveIND";
            this.btnSaveIND.Size = new System.Drawing.Size(72, 28);
            this.btnSaveIND.TabIndex = 25;
            this.btnSaveIND.Text = "&Guardar Indice";
            this.btnSaveIND.UseVisualStyleBackColor = true;
            this.btnSaveIND.Click += new System.EventHandler(this.btnSaveIND_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(146, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Consola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGraficos
            // 
            this.lblGraficos.AutoSize = true;
            this.lblGraficos.Location = new System.Drawing.Point(2, 7);
            this.lblGraficos.Margin = new System.Windows.Forms.Padding(2, 7, 2, 0);
            this.lblGraficos.Name = "lblGraficos";
            this.lblGraficos.Size = new System.Drawing.Size(62, 15);
            this.lblGraficos.TabIndex = 23;
            this.lblGraficos.Text = "Graficos: 0";
            this.lblGraficos.Click += new System.EventHandler(this.lblGraficos_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(212, 503);
            this.panel2.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 493);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.tableLayoutPanel11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel6.Size = new System.Drawing.Size(202, 463);
            this.panel6.TabIndex = 25;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.txtGrhFilter, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.lstIndices, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(196, 460);
            this.tableLayoutPanel11.TabIndex = 4;
            // 
            // txtGrhFilter
            // 
            this.txtGrhFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGrhFilter.Location = new System.Drawing.Point(3, 3);
            this.txtGrhFilter.Name = "txtGrhFilter";
            this.txtGrhFilter.Size = new System.Drawing.Size(190, 23);
            this.txtGrhFilter.TabIndex = 3;
            this.txtGrhFilter.TextChanged += new System.EventHandler(this.txtGrhFilter_TextChanged);
            this.txtGrhFilter.DoubleClick += new System.EventHandler(this.txtGrhFilter_DoubleClick);
            // 
            // lstIndices
            // 
            this.lstIndices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIndices.FormattingEnabled = true;
            this.lstIndices.ItemHeight = 15;
            this.lstIndices.Location = new System.Drawing.Point(3, 33);
            this.lstIndices.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lstIndices.Name = "lstIndices";
            this.lstIndices.Size = new System.Drawing.Size(190, 425);
            this.lstIndices.TabIndex = 2;
            this.lstIndices.SelectedIndexChanged += new System.EventHandler(this.lstIndices_SelectedIndexChanged);
            this.lstIndices.DoubleClick += new System.EventHandler(this.lstIndices_DoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmdEditGrh, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 463);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(202, 30);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // cmdEditGrh
            // 
            this.cmdEditGrh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEditGrh.Location = new System.Drawing.Point(3, 2);
            this.cmdEditGrh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdEditGrh.Name = "cmdEditGrh";
            this.cmdEditGrh.Size = new System.Drawing.Size(95, 26);
            this.cmdEditGrh.TabIndex = 19;
            this.cmdEditGrh.Text = "&Editar";
            this.cmdEditGrh.UseVisualStyleBackColor = true;
            this.cmdEditGrh.Click += new System.EventHandler(this.cmdEditGrh_Click);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.AutoScroll = true;
            this.panel3.AutoScrollMinSize = new System.Drawing.Size(212, 477);
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.tableLayoutPanel10);
            this.panel3.Controls.Add(this.tableLayoutPanel9);
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Controls.Add(this.cmdAplicarIndice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(684, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.MinimumSize = new System.Drawing.Size(306, 477);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 8);
            this.panel3.Size = new System.Drawing.Size(306, 503);
            this.panel3.TabIndex = 21;
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.AllowDrop = true;
            this.tableLayoutPanel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.picImage, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(5, 81);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.11156F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.88844F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(296, 388);
            this.tableLayoutPanel10.TabIndex = 50;
            this.tableLayoutPanel10.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.tableLayoutPanel10.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(2, 2);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(292, 235);
            this.picImage.TabIndex = 42;
            this.picImage.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AllowDrop = true;
            this.tableLayoutPanel7.AutoScroll = true;
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.txtImageNum, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.txtPosX, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.txtHeight, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.txtPosY, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.txtWidth, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel7.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 248);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.MinimumSize = new System.Drawing.Size(0, 140);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel10.SetRowSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(296, 140);
            this.tableLayoutPanel7.TabIndex = 47;
            this.tableLayoutPanel7.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.tableLayoutPanel7.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // txtImageNum
            // 
            this.txtImageNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImageNum.Location = new System.Drawing.Point(59, 2);
            this.txtImageNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageNum.Name = "txtImageNum";
            this.txtImageNum.Size = new System.Drawing.Size(234, 23);
            this.txtImageNum.TabIndex = 35;
            this.txtImageNum.TextChanged += new System.EventHandler(this.txtImageNum_TextChanged);
            this.txtImageNum.DoubleClick += new System.EventHandler(this.txtImageNum_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Imagen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "PosX:";
            // 
            // txtPosX
            // 
            this.txtPosX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosX.Location = new System.Drawing.Point(59, 29);
            this.txtPosX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(234, 23);
            this.txtPosX.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "PosY:";
            // 
            // txtHeight
            // 
            this.txtHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeight.Location = new System.Drawing.Point(59, 110);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(234, 23);
            this.txtHeight.TabIndex = 41;
            // 
            // txtPosY
            // 
            this.txtPosY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosY.Location = new System.Drawing.Point(59, 56);
            this.txtPosY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(234, 23);
            this.txtPosY.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "Alto:";
            // 
            // txtWidth
            // 
            this.txtWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWidth.Location = new System.Drawing.Point(59, 83);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(234, 23);
            this.txtWidth.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ancho:";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AllowDrop = true;
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.lstFrames, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(5, 81);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(296, 388);
            this.tableLayoutPanel9.TabIndex = 49;
            this.tableLayoutPanel9.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.tableLayoutPanel9.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // lstFrames
            // 
            this.lstFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFrames.FormattingEnabled = true;
            this.lstFrames.ItemHeight = 15;
            this.lstFrames.Location = new System.Drawing.Point(3, 2);
            this.lstFrames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFrames.Name = "lstFrames";
            this.lstFrames.Size = new System.Drawing.Size(290, 295);
            this.lstFrames.TabIndex = 26;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AllowDrop = true;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.txtSpeed, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.cmdRemove, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.cmdDown, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.cmdAdd, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.cmdUp, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 299);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(296, 89);
            this.tableLayoutPanel8.TabIndex = 48;
            this.tableLayoutPanel8.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.tableLayoutPanel8.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(115, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Vel.";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpeed.Location = new System.Drawing.Point(151, 61);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(142, 23);
            this.txtSpeed.TabIndex = 29;
            // 
            // cmdRemove
            // 
            this.cmdRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmdRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdRemove.Location = new System.Drawing.Point(151, 32);
            this.cmdRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(142, 25);
            this.cmdRemove.TabIndex = 27;
            this.cmdRemove.Text = "&Remover";
            this.cmdRemove.UseVisualStyleBackColor = false;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDown.Location = new System.Drawing.Point(3, 32);
            this.cmdDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(142, 25);
            this.cmdDown.TabIndex = 31;
            this.cmdDown.Text = "&Bajar";
            this.cmdDown.UseVisualStyleBackColor = true;
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmdAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdAdd.Location = new System.Drawing.Point(151, 2);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(142, 26);
            this.cmdAdd.TabIndex = 32;
            this.cmdAdd.Text = "&Añadir Grh Sel.";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdUp.Location = new System.Drawing.Point(3, 2);
            this.cmdUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(142, 26);
            this.cmdUp.TabIndex = 30;
            this.cmdUp.Text = "&Subir";
            this.cmdUp.UseVisualStyleBackColor = true;
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AllowDrop = true;
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.rdoStatic, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtVer, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtGrhNum, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.rdoAnim, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.35484F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.64516F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(296, 76);
            this.tableLayoutPanel6.TabIndex = 46;
            this.tableLayoutPanel6.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.tableLayoutPanel6.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // rdoStatic
            // 
            this.rdoStatic.AutoSize = true;
            this.rdoStatic.Checked = true;
            this.rdoStatic.Location = new System.Drawing.Point(3, 51);
            this.rdoStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoStatic.Name = "rdoStatic";
            this.rdoStatic.Size = new System.Drawing.Size(65, 19);
            this.rdoStatic.TabIndex = 50;
            this.rdoStatic.TabStop = true;
            this.rdoStatic.Text = "Estatica";
            this.rdoStatic.UseVisualStyleBackColor = true;
            this.rdoStatic.CheckedChanged += new System.EventHandler(this.rdoStatic_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Versión de Indices:";
            // 
            // txtVer
            // 
            this.txtVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVer.Location = new System.Drawing.Point(151, 2);
            this.txtVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(142, 23);
            this.txtVer.TabIndex = 47;
            // 
            // txtGrhNum
            // 
            this.txtGrhNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGrhNum.Location = new System.Drawing.Point(151, 24);
            this.txtGrhNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrhNum.Name = "txtGrhNum";
            this.txtGrhNum.Size = new System.Drawing.Size(142, 23);
            this.txtGrhNum.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 27);
            this.label8.TabIndex = 48;
            this.label8.Text = "Número de Indice:";
            // 
            // rdoAnim
            // 
            this.rdoAnim.AutoSize = true;
            this.rdoAnim.Location = new System.Drawing.Point(151, 51);
            this.rdoAnim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoAnim.Name = "rdoAnim";
            this.rdoAnim.Size = new System.Drawing.Size(83, 19);
            this.rdoAnim.TabIndex = 51;
            this.rdoAnim.Text = "Animación";
            this.rdoAnim.UseVisualStyleBackColor = true;
            this.rdoAnim.CheckedChanged += new System.EventHandler(this.rdoAnim_CheckedChanged);
            // 
            // cmdAplicarIndice
            // 
            this.cmdAplicarIndice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdAplicarIndice.Location = new System.Drawing.Point(5, 469);
            this.cmdAplicarIndice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAplicarIndice.Name = "cmdAplicarIndice";
            this.cmdAplicarIndice.Size = new System.Drawing.Size(296, 26);
            this.cmdAplicarIndice.TabIndex = 43;
            this.cmdAplicarIndice.Text = "A&plicar";
            this.cmdAplicarIndice.UseVisualStyleBackColor = true;
            this.cmdAplicarIndice.Click += new System.EventHandler(this.cmdAplicarIndice_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(212, 76);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.MinimumSize = new System.Drawing.Size(472, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(472, 503);
            this.panel4.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picImg);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(462, 455);
            this.panel7.TabIndex = 19;
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.White;
            this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImg.Location = new System.Drawing.Point(3, 3);
            this.picImg.Margin = new System.Windows.Forms.Padding(2);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(456, 449);
            this.picImg.TabIndex = 14;
            this.picImg.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.72549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.27451F));
            this.tableLayoutPanel1.Controls.Add(this.cmdCambiarFondo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zoomBar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 460);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 38);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // cmdCambiarFondo
            // 
            this.cmdCambiarFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCambiarFondo.Location = new System.Drawing.Point(297, 2);
            this.cmdCambiarFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCambiarFondo.Name = "cmdCambiarFondo";
            this.cmdCambiarFondo.Size = new System.Drawing.Size(162, 34);
            this.cmdCambiarFondo.TabIndex = 17;
            this.cmdCambiarFondo.Text = "Cambiar Fondo";
            this.cmdCambiarFondo.UseVisualStyleBackColor = true;
            this.cmdCambiarFondo.Click += new System.EventHandler(this.cmdCambiarFondo_Click);
            // 
            // zoomBar
            // 
            this.zoomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomBar.Location = new System.Drawing.Point(2, 2);
            this.zoomBar.Margin = new System.Windows.Forms.Padding(2);
            this.zoomBar.Minimum = 1;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(290, 34);
            this.zoomBar.TabIndex = 16;
            this.zoomBar.Value = 1;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 579);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndeXAO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.RadioButton rdo;
        private System.Windows.Forms.RadioButton Radio;
        private System.Windows.Forms.Timer timerAnim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdAplicarIndice;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Button cmdUp;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.ListBox lstFrames;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdCambiarFondo;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cmdEditGrh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button cmdIndice;
        private System.Windows.Forms.Button cmdGraficos;
        private System.Windows.Forms.TextBox txtGraficos;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblGraficos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtImageNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rdoStatic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.TextBox txtGrhNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoAnim;
        private System.Windows.Forms.Button btnSaveIND;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGrhFilter;
        private System.Windows.Forms.ListBox lstIndices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button cmdAdd;
    }
}

