namespace IsTakip.Raporlar
{
    partial class fRaporIsEmri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRaporIsEmri));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lGunSayisi = new System.Windows.Forms.Label();
            this.lToplamGelir = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridIsEmriRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIsEmriRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lGunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lToplamGelir);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnAra);
            this.splitContainer1.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtBaslangic);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridIsEmriRapor);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 0;
            // 
            // lGunSayisi
            // 
            this.lGunSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lGunSayisi.AutoSize = true;
            this.lGunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGunSayisi.Location = new System.Drawing.Point(649, 69);
            this.lGunSayisi.Name = "lGunSayisi";
            this.lGunSayisi.Size = new System.Drawing.Size(46, 16);
            this.lGunSayisi.TabIndex = 20;
            this.lGunSayisi.Text = "Gün : ";
            this.lGunSayisi.Visible = false;
            // 
            // lToplamGelir
            // 
            this.lToplamGelir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lToplamGelir.AutoSize = true;
            this.lToplamGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lToplamGelir.ForeColor = System.Drawing.Color.Green;
            this.lToplamGelir.Location = new System.Drawing.Point(648, 32);
            this.lToplamGelir.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lToplamGelir.Name = "lToplamGelir";
            this.lToplamGelir.Size = new System.Drawing.Size(19, 20);
            this.lToplamGelir.TabIndex = 18;
            this.lToplamGelir.Text = "0";
            this.lToplamGelir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lToplamGelir.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(616, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "TOPLAM KAZANÇ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(303, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(106, 34);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Detay Göster";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(97, 49);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "BİTİŞ";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(97, 12);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAŞLANGIÇ";
            // 
            // gridIsEmriRapor
            // 
            this.gridIsEmriRapor.AllowUserToResizeColumns = false;
            this.gridIsEmriRapor.AllowUserToResizeRows = false;
            this.gridIsEmriRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIsEmriRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIsEmriRapor.Location = new System.Drawing.Point(0, 0);
            this.gridIsEmriRapor.Name = "gridIsEmriRapor";
            this.gridIsEmriRapor.Size = new System.Drawing.Size(800, 344);
            this.gridIsEmriRapor.TabIndex = 0;
            // 
            // fRaporIsEmri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRaporIsEmri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞ EMRİ RAPORLARI";
            this.Load += new System.EventHandler(this.fRaporIsEmri_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIsEmriRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridIsEmriRapor;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lToplamGelir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lGunSayisi;
    }
}