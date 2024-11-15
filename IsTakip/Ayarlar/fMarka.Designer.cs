namespace IsTakip.Ayarlar
{
    partial class fMarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMarka));
            this.tMarkaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.btnMarkaKaydet = new System.Windows.Forms.Button();
            this.gridMarkalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarkalar)).BeginInit();
            this.SuspendLayout();
            // 
            // tMarkaAdi
            // 
            this.tMarkaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tMarkaAdi.Location = new System.Drawing.Point(102, 26);
            this.tMarkaAdi.Name = "tMarkaAdi";
            this.tMarkaAdi.Size = new System.Drawing.Size(154, 23);
            this.tMarkaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnMarkaSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnModelEkle);
            this.splitContainer1.Panel1.Controls.Add(this.btnMarkaKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.tMarkaAdi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridMarkalar);
            this.splitContainer1.Size = new System.Drawing.Size(447, 430);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 9;
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkaSil.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMarkaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaSil.ForeColor = System.Drawing.Color.Crimson;
            this.btnMarkaSil.Location = new System.Drawing.Point(283, 70);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(76, 37);
            this.btnMarkaSil.TabIndex = 2;
            this.btnMarkaSil.Text = "Sil";
            this.btnMarkaSil.UseVisualStyleBackColor = false;
            this.btnMarkaSil.Click += new System.EventHandler(this.btnMarkaSil_Click);
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModelEkle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnModelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModelEkle.Location = new System.Drawing.Point(12, 70);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(94, 37);
            this.btnModelEkle.TabIndex = 1;
            this.btnModelEkle.Text = "Model Ekle";
            this.btnModelEkle.UseVisualStyleBackColor = false;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // btnMarkaKaydet
            // 
            this.btnMarkaKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkaKaydet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMarkaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMarkaKaydet.Location = new System.Drawing.Point(365, 70);
            this.btnMarkaKaydet.Name = "btnMarkaKaydet";
            this.btnMarkaKaydet.Size = new System.Drawing.Size(76, 37);
            this.btnMarkaKaydet.TabIndex = 1;
            this.btnMarkaKaydet.Text = "Kaydet";
            this.btnMarkaKaydet.UseVisualStyleBackColor = false;
            this.btnMarkaKaydet.Click += new System.EventHandler(this.btnMarkaKaydet_Click);
            // 
            // gridMarkalar
            // 
            this.gridMarkalar.AllowUserToAddRows = false;
            this.gridMarkalar.AllowUserToDeleteRows = false;
            this.gridMarkalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMarkalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMarkalar.Location = new System.Drawing.Point(0, 0);
            this.gridMarkalar.Name = "gridMarkalar";
            this.gridMarkalar.ReadOnly = true;
            this.gridMarkalar.RowHeadersVisible = false;
            this.gridMarkalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMarkalar.Size = new System.Drawing.Size(447, 310);
            this.gridMarkalar.TabIndex = 0;
            // 
            // fMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(447, 430);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 469);
            this.Name = "fMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKA";
            this.Load += new System.EventHandler(this.fMarka_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMarkalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tMarkaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridMarkalar;
        private System.Windows.Forms.Button btnMarkaKaydet;
        private System.Windows.Forms.Button btnMarkaSil;
        private System.Windows.Forms.Button btnModelEkle;
    }
}