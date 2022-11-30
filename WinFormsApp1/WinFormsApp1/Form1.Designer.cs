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
            this.SuspendLayout();
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 15;
            this.lstKategoriler.Location = new System.Drawing.Point(12, 42);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(184, 259);
            this.lstKategoriler.TabIndex = 0;
            // 
            // btnBaglantiTest
            // 
            this.btnBaglantiTest.Location = new System.Drawing.Point(458, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerileriListele);
            this.Controls.Add(this.btnBaglantiTest);
            this.Controls.Add(this.lstKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstKategoriler;
        private Button btnBaglantiTest;
        private Button btnVerileriListele;
        private Label label1;
    }
}