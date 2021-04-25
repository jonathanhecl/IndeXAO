
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
            this.lstIndices = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtGraficos
            // 
            this.txtGraficos.Location = new System.Drawing.Point(184, 14);
            this.txtGraficos.Margin = new System.Windows.Forms.Padding(4);
            this.txtGraficos.Name = "txtGraficos";
            this.txtGraficos.ReadOnly = true;
            this.txtGraficos.Size = new System.Drawing.Size(581, 35);
            this.txtGraficos.TabIndex = 0;
            // 
            // cmdGraficos
            // 
            this.cmdGraficos.Location = new System.Drawing.Point(13, 14);
            this.cmdGraficos.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGraficos.Name = "cmdGraficos";
            this.cmdGraficos.Size = new System.Drawing.Size(163, 37);
            this.cmdGraficos.TabIndex = 1;
            this.cmdGraficos.Text = "Dir. &Gráficos";
            this.cmdGraficos.UseVisualStyleBackColor = true;
            this.cmdGraficos.Click += new System.EventHandler(this.cmdGraficos_Click);
            // 
            // cmdIndice
            // 
            this.cmdIndice.Location = new System.Drawing.Point(14, 59);
            this.cmdIndice.Margin = new System.Windows.Forms.Padding(4);
            this.cmdIndice.Name = "cmdIndice";
            this.cmdIndice.Size = new System.Drawing.Size(163, 37);
            this.cmdIndice.TabIndex = 3;
            this.cmdIndice.Text = "&Ind. Gráficos";
            this.cmdIndice.UseVisualStyleBackColor = true;
            this.cmdIndice.Click += new System.EventHandler(this.cmdIndice_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(185, 59);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(580, 35);
            this.txtIndice.TabIndex = 2;
            // 
            // lblGraficos
            // 
            this.lblGraficos.AutoSize = true;
            this.lblGraficos.Location = new System.Drawing.Point(773, 18);
            this.lblGraficos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGraficos.Name = "lblGraficos";
            this.lblGraficos.Size = new System.Drawing.Size(110, 30);
            this.lblGraficos.TabIndex = 4;
            this.lblGraficos.Text = "Graficos: 0";
            // 
            // listGraficos
            // 
            this.listGraficos.AutoArrange = false;
            this.listGraficos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listGraficos.HideSelection = false;
            this.listGraficos.LabelWrap = false;
            this.listGraficos.Location = new System.Drawing.Point(734, 113);
            this.listGraficos.Margin = new System.Windows.Forms.Padding(4);
            this.listGraficos.MultiSelect = false;
            this.listGraficos.Name = "listGraficos";
            this.listGraficos.ShowGroups = false;
            this.listGraficos.Size = new System.Drawing.Size(200, 406);
            this.listGraficos.TabIndex = 5;
            this.listGraficos.TileSize = new System.Drawing.Size(128, 32);
            this.listGraficos.UseCompatibleStateImageBehavior = false;
            this.listGraficos.View = System.Windows.Forms.View.Tile;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(773, 62);
            this.lblIndice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(100, 30);
            this.lblIndice.TabIndex = 6;
            this.lblIndice.Text = "Indices: 0";
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(646, 113);
            this.txtVer.Margin = new System.Windows.Forms.Padding(4);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(81, 35);
            this.txtVer.TabIndex = 7;
            // 
            // lstIndices
            // 
            this.lstIndices.AutoArrange = false;
            this.lstIndices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstIndices.HideSelection = false;
            this.lstIndices.LabelWrap = false;
            this.lstIndices.Location = new System.Drawing.Point(15, 104);
            this.lstIndices.Margin = new System.Windows.Forms.Padding(4);
            this.lstIndices.MultiSelect = false;
            this.lstIndices.Name = "lstIndices";
            this.lstIndices.ShowGroups = false;
            this.lstIndices.Size = new System.Drawing.Size(138, 406);
            this.lstIndices.TabIndex = 8;
            this.lstIndices.TileSize = new System.Drawing.Size(128, 32);
            this.lstIndices.UseCompatibleStateImageBehavior = false;
            this.lstIndices.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndeXAO";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListView lstIndices;
    }
}

