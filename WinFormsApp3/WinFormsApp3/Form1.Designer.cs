namespace WinFormsApp3
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
            this.btnDataAdapter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReporter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDataAdapter
            // 
            this.btnDataAdapter.Location = new System.Drawing.Point(12, 12);
            this.btnDataAdapter.Name = "btnDataAdapter";
            this.btnDataAdapter.Size = new System.Drawing.Size(122, 41);
            this.btnDataAdapter.TabIndex = 0;
            this.btnDataAdapter.Text = "Data Adapter ile Veri Çekme";
            this.btnDataAdapter.UseVisualStyleBackColor = true;
            this.btnDataAdapter.Click += new System.EventHandler(this.btnDataAdapter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(648, 416);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnReporter
            // 
            this.btnReporter.Location = new System.Drawing.Point(12, 405);
            this.btnReporter.Name = "btnReporter";
            this.btnReporter.Size = new System.Drawing.Size(122, 23);
            this.btnReporter.TabIndex = 2;
            this.btnReporter.Text = "Reporter";
            this.btnReporter.UseVisualStyleBackColor = true;
            this.btnReporter.Click += new System.EventHandler(this.btnReporter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDataAdapter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDataAdapter;
        private DataGridView dataGridView1;
        private Button btnReporter;
    }
}