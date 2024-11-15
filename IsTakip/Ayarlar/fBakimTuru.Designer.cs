namespace IsTakip.Ayarlar
{
    partial class fBakimTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBakimTuru));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTuruSil = new System.Windows.Forms.Button();
            this.btnTuruKaydet = new System.Windows.Forms.Button();
            this.tTurAdi = new System.Windows.Forms.TextBox();
            this.lgrupadi = new System.Windows.Forms.Label();
            this.listBakimTuru = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnTuruSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnTuruKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.tTurAdi);
            this.splitContainer1.Panel1.Controls.Add(this.lgrupadi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBakimTuru);
            this.splitContainer1.Size = new System.Drawing.Size(447, 430);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnTuruSil
            // 
            this.btnTuruSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTuruSil.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTuruSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuruSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTuruSil.ForeColor = System.Drawing.Color.Crimson;
            this.btnTuruSil.Location = new System.Drawing.Point(287, 80);
            this.btnTuruSil.Name = "btnTuruSil";
            this.btnTuruSil.Size = new System.Drawing.Size(76, 37);
            this.btnTuruSil.TabIndex = 3;
            this.btnTuruSil.Text = "Sil";
            this.btnTuruSil.UseVisualStyleBackColor = false;
            this.btnTuruSil.Click += new System.EventHandler(this.btnTuruSil_Click);
            // 
            // btnTuruKaydet
            // 
            this.btnTuruKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTuruKaydet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTuruKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuruKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTuruKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTuruKaydet.Location = new System.Drawing.Point(368, 80);
            this.btnTuruKaydet.Name = "btnTuruKaydet";
            this.btnTuruKaydet.Size = new System.Drawing.Size(76, 37);
            this.btnTuruKaydet.TabIndex = 2;
            this.btnTuruKaydet.Text = "Kaydet";
            this.btnTuruKaydet.UseVisualStyleBackColor = false;
            this.btnTuruKaydet.Click += new System.EventHandler(this.btnTuruKaydet_Click);
            // 
            // tTurAdi
            // 
            this.tTurAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tTurAdi.Location = new System.Drawing.Point(12, 37);
            this.tTurAdi.Name = "tTurAdi";
            this.tTurAdi.Size = new System.Drawing.Size(154, 23);
            this.tTurAdi.TabIndex = 1;
            // 
            // lgrupadi
            // 
            this.lgrupadi.AutoSize = true;
            this.lgrupadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lgrupadi.Location = new System.Drawing.Point(12, 14);
            this.lgrupadi.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lgrupadi.Name = "lgrupadi";
            this.lgrupadi.Size = new System.Drawing.Size(89, 20);
            this.lgrupadi.TabIndex = 16;
            this.lgrupadi.Text = "Bakım Türü";
            this.lgrupadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBakimTuru
            // 
            this.listBakimTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBakimTuru.FormattingEnabled = true;
            this.listBakimTuru.Location = new System.Drawing.Point(0, 0);
            this.listBakimTuru.Name = "listBakimTuru";
            this.listBakimTuru.Size = new System.Drawing.Size(447, 304);
            this.listBakimTuru.TabIndex = 0;
            // 
            // fBakimTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(447, 430);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 469);
            this.Name = "fBakimTuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAKIM TÜRÜ";
            this.Load += new System.EventHandler(this.fBakimTuru_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTuruSil;
        private System.Windows.Forms.Button btnTuruKaydet;
        private System.Windows.Forms.TextBox tTurAdi;
        private System.Windows.Forms.Label lgrupadi;
        private System.Windows.Forms.ListBox listBakimTuru;
    }
}