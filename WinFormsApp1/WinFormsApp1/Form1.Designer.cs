namespace WinFormsApp1
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
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.btnBaglantiTest = new System.Windows.Forms.Button();
            this.btnVerileriListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYeniKategoriAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtEskiKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtGuncelKategoriAdi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSilinecekKategoriAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 15;
            this.lstKategoriler.Location = new System.Drawing.Point(12, 42);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(184, 244);
            this.lstKategoriler.TabIndex = 0;
            // 
            // btnBaglantiTest
            // 
            this.btnBaglantiTest.Location = new System.Drawing.Point(415, 12);
            this.btnBaglantiTest.Name = "btnBaglantiTest";
            this.btnBaglantiTest.Size = new System.Drawing.Size(113, 43);
            this.btnBaglantiTest.TabIndex = 1;
            this.btnBaglantiTest.Text = "Bağlantı Test";
            this.btnBaglantiTest.UseVisualStyleBackColor = true;
            this.btnBaglantiTest.Click += new System.EventHandler(this.btnBaglantiTest_Click);
            // 
            // btnVerileriListele
            // 
            this.btnVerileriListele.Location = new System.Drawing.Point(202, 42);
            this.btnVerileriListele.Name = "btnVerileriListele";
            this.btnVerileriListele.Size = new System.Drawing.Size(158, 23);
            this.btnVerileriListele.TabIndex = 2;
            this.btnVerileriListele.Text = "Verileri Listele";
            this.btnVerileriListele.UseVisualStyleBackColor = true;
            this.btnVerileriListele.Click += new System.EventHandler(this.btnVerileriListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategoriler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtYeniKategoriAdi);
            this.groupBox1.Location = new System.Drawing.Point(202, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ekleme";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(77, 62);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYeniKategoriAdi
            // 
            this.txtYeniKategoriAdi.Location = new System.Drawing.Point(6, 33);
            this.txtYeniKategoriAdi.Name = "txtYeniKategoriAdi";
            this.txtYeniKategoriAdi.PlaceholderText = "Kategori Adı";
            this.txtYeniKategoriAdi.Size = new System.Drawing.Size(146, 23);
            this.txtYeniKategoriAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.txtEskiKategoriAdi);
            this.groupBox2.Controls.Add(this.txtGuncelKategoriAdi);
            this.groupBox2.Location = new System.Drawing.Point(202, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori Güncelleme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(77, 80);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtEskiKategoriAdi
            // 
            this.txtEskiKategoriAdi.Location = new System.Drawing.Point(6, 22);
            this.txtEskiKategoriAdi.Name = "txtEskiKategoriAdi";
            this.txtEskiKategoriAdi.PlaceholderText = "Eski Kategori Adı";
            this.txtEskiKategoriAdi.Size = new System.Drawing.Size(146, 23);
            this.txtEskiKategoriAdi.TabIndex = 0;
            // 
            // txtGuncelKategoriAdi
            // 
            this.txtGuncelKategoriAdi.Location = new System.Drawing.Point(6, 51);
            this.txtGuncelKategoriAdi.Name = "txtGuncelKategoriAdi";
            this.txtGuncelKategoriAdi.PlaceholderText = "Güncel Kategori Adı";
            this.txtGuncelKategoriAdi.Size = new System.Drawing.Size(146, 23);
            this.txtGuncelKategoriAdi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.txtSilinecekKategoriAdi);
            this.groupBox3.Location = new System.Drawing.Point(366, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 109);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kategori Silme";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(81, 80);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSilinecekKategoriAdi
            // 
            this.txtSilinecekKategoriAdi.Location = new System.Drawing.Point(6, 22);
            this.txtSilinecekKategoriAdi.Name = "txtSilinecekKategoriAdi";
            this.txtSilinecekKategoriAdi.PlaceholderText = "Silinecek Kategori Adı";
            this.txtSilinecekKategoriAdi.Size = new System.Drawing.Size(150, 23);
            this.txtSilinecekKategoriAdi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 295);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerileriListele);
            this.Controls.Add(this.btnBaglantiTest);
            this.Controls.Add(this.lstKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstKategoriler;
        private Button btnBaglantiTest;
        private Button btnVerileriListele;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnEkle;
        private TextBox txtYeniKategoriAdi;
        private GroupBox groupBox2;
        private Button btnKaydet;
        private TextBox txtEskiKategoriAdi;
        private TextBox txtGuncelKategoriAdi;
        private GroupBox groupBox3;
        private Button btnSil;
        private TextBox txtSilinecekKategoriAdi;
    }
}