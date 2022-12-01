namespace WinFormsApp3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbReportName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReportListRefresh = new System.Windows.Forms.Button();
            this.btnDataRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportName
            // 
            this.cmbReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReportName.FormattingEnabled = true;
            this.cmbReportName.Location = new System.Drawing.Point(446, 12);
            this.cmbReportName.Name = "cmbReportName";
            this.cmbReportName.Size = new System.Drawing.Size(249, 23);
            this.cmbReportName.TabIndex = 0;
            this.cmbReportName.SelectedIndexChanged += new System.EventHandler(this.cmbReportName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapor Seçiniz :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(722, 454);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnReportListRefresh
            // 
            this.btnReportListRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportListRefresh.Image = global::WinFormsApp3.Properties.Resources.bx_sync_icon;
            this.btnReportListRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportListRefresh.Location = new System.Drawing.Point(701, 12);
            this.btnReportListRefresh.Name = "btnReportListRefresh";
            this.btnReportListRefresh.Size = new System.Drawing.Size(33, 23);
            this.btnReportListRefresh.TabIndex = 3;
            this.btnReportListRefresh.UseVisualStyleBackColor = true;
            this.btnReportListRefresh.Click += new System.EventHandler(this.btnReportListRefresh_Click);
            // 
            // btnDataRefresh
            // 
            this.btnDataRefresh.Image = global::WinFormsApp3.Properties.Resources.bx_sync_icon;
            this.btnDataRefresh.Location = new System.Drawing.Point(12, 2);
            this.btnDataRefresh.Name = "btnDataRefresh";
            this.btnDataRefresh.Size = new System.Drawing.Size(98, 33);
            this.btnDataRefresh.TabIndex = 4;
            this.btnDataRefresh.Text = "Yenile";
            this.btnDataRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataRefresh.UseVisualStyleBackColor = true;
            this.btnDataRefresh.Click += new System.EventHandler(this.btnDataRefresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 507);
            this.Controls.Add(this.btnDataRefresh);
            this.Controls.Add(this.btnReportListRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReportName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbReportName;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnReportListRefresh;
        private Button btnDataRefresh;
    }
}