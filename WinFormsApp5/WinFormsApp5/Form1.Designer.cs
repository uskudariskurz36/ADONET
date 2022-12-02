namespace WinFormsApp5
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
            this.lsvGaleriler = new System.Windows.Forms.ListView();
            this.clmID = new System.Windows.Forms.ColumnHeader();
            this.clmAdi = new System.Windows.Forms.ColumnHeader();
            this.clmAciklama = new System.Windows.Forms.ColumnHeader();
            this.btnGaleriSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpResimler = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGaleriAciklama = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnGaleriKaydet = new System.Windows.Forms.Button();
            this.btnGaleriExcelExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGaleriAdi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnResmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvGaleriler
            // 
            this.lsvGaleriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvGaleriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmAdi,
            this.clmAciklama});
            this.lsvGaleriler.FullRowSelect = true;
            this.lsvGaleriler.Location = new System.Drawing.Point(12, 12);
            this.lsvGaleriler.MultiSelect = false;
            this.lsvGaleriler.Name = "lsvGaleriler";
            this.lsvGaleriler.Size = new System.Drawing.Size(286, 436);
            this.lsvGaleriler.TabIndex = 0;
            this.lsvGaleriler.UseCompatibleStateImageBehavior = false;
            this.lsvGaleriler.View = System.Windows.Forms.View.Details;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 30;
            // 
            // clmAdi
            // 
            this.clmAdi.Text = "Adı";
            this.clmAdi.Width = 120;
            // 
            // clmAciklama
            // 
            this.clmAciklama.Text = "Açıklama";
            this.clmAciklama.Width = 200;
            // 
            // btnGaleriSil
            // 
            this.btnGaleriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGaleriSil.Location = new System.Drawing.Point(12, 454);
            this.btnGaleriSil.Name = "btnGaleriSil";
            this.btnGaleriSil.Size = new System.Drawing.Size(96, 23);
            this.btnGaleriSil.TabIndex = 1;
            this.btnGaleriSil.Text = "Galeri Sil";
            this.btnGaleriSil.UseVisualStyleBackColor = true;
            this.btnGaleriSil.Click += new System.EventHandler(this.btnGaleriSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flpResimler);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(304, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galeri Bilgileri ve Resimler";
            // 
            // flpResimler
            // 
            this.flpResimler.AutoScroll = true;
            this.flpResimler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResimler.Location = new System.Drawing.Point(197, 19);
            this.flpResimler.Name = "flpResimler";
            this.flpResimler.Padding = new System.Windows.Forms.Padding(10);
            this.flpResimler.Size = new System.Drawing.Size(410, 414);
            this.flpResimler.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGaleriAciklama);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnResimEkle);
            this.panel1.Controls.Add(this.btnGaleriKaydet);
            this.panel1.Controls.Add(this.btnGaleriExcelExport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtGaleriAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(194, 414);
            this.panel1.TabIndex = 0;
            // 
            // txtGaleriAciklama
            // 
            this.txtGaleriAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGaleriAciklama.Location = new System.Drawing.Point(10, 43);
            this.txtGaleriAciklama.Multiline = true;
            this.txtGaleriAciklama.Name = "txtGaleriAciklama";
            this.txtGaleriAciklama.PlaceholderText = "Galeri Açıklama";
            this.txtGaleriAciklama.Size = new System.Drawing.Size(174, 282);
            this.txtGaleriAciklama.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 10);
            this.panel3.TabIndex = 5;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResimEkle.Location = new System.Drawing.Point(10, 335);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(174, 23);
            this.btnResimEkle.TabIndex = 4;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnGaleriKaydet
            // 
            this.btnGaleriKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGaleriKaydet.Location = new System.Drawing.Point(10, 358);
            this.btnGaleriKaydet.Name = "btnGaleriKaydet";
            this.btnGaleriKaydet.Size = new System.Drawing.Size(174, 23);
            this.btnGaleriKaydet.TabIndex = 3;
            this.btnGaleriKaydet.Text = "Galeri Kaydet";
            this.btnGaleriKaydet.UseVisualStyleBackColor = true;
            this.btnGaleriKaydet.Click += new System.EventHandler(this.btnGaleriKaydet_Click);
            // 
            // btnGaleriExcelExport
            // 
            this.btnGaleriExcelExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGaleriExcelExport.Location = new System.Drawing.Point(10, 381);
            this.btnGaleriExcelExport.Name = "btnGaleriExcelExport";
            this.btnGaleriExcelExport.Size = new System.Drawing.Size(174, 23);
            this.btnGaleriExcelExport.TabIndex = 2;
            this.btnGaleriExcelExport.Text = "Galeri Excel Export";
            this.btnGaleriExcelExport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 10);
            this.panel2.TabIndex = 1;
            // 
            // txtGaleriAdi
            // 
            this.txtGaleriAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGaleriAdi.Location = new System.Drawing.Point(10, 10);
            this.txtGaleriAdi.Name = "txtGaleriAdi";
            this.txtGaleriAdi.PlaceholderText = "Galeri Adı";
            this.txtGaleriAdi.Size = new System.Drawing.Size(174, 23);
            this.txtGaleriAdi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResmiSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // btnResmiSil
            // 
            this.btnResmiSil.Name = "btnResmiSil";
            this.btnResmiSil.Size = new System.Drawing.Size(121, 22);
            this.btnResmiSil.Text = "Resmi Sil";
            this.btnResmiSil.Click += new System.EventHandler(this.btnResmiSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGaleriSil);
            this.Controls.Add(this.lsvGaleriler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeri Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lsvGaleriler;
        private Button btnGaleriSil;
        private GroupBox groupBox1;
        private FlowLayoutPanel flpResimler;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtGaleriAdi;
        private Button btnResimEkle;
        private Button btnGaleriKaydet;
        private Button btnGaleriExcelExport;
        private Panel panel3;
        private TextBox txtGaleriAciklama;
        private ColumnHeader clmID;
        private ColumnHeader clmAdi;
        private ColumnHeader clmAciklama;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem btnResmiSil;
    }
}