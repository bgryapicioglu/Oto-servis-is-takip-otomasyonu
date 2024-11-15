namespace IsTakip.Ayarlar
{
    partial class fBakimGrubu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBakimGrubu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBakimSil = new System.Windows.Forms.Button();
            this.btnBakimTurEkle = new System.Windows.Forms.Button();
            this.btnBakimKaydet = new System.Windows.Forms.Button();
            this.tBakimAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridBakimGrubu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBakimGrubu)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel1.Controls.Add(this.btnBakimSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnBakimTurEkle);
            this.splitContainer1.Panel1.Controls.Add(this.btnBakimKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.tBakimAdi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridBakimGrubu);
            this.splitContainer1.Size = new System.Drawing.Size(474, 451);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnBakimSil
            // 
            this.btnBakimSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBakimSil.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBakimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakimSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakimSil.ForeColor = System.Drawing.Color.Crimson;
            this.btnBakimSil.Location = new System.Drawing.Point(313, 91);
            this.btnBakimSil.Name = "btnBakimSil";
            this.btnBakimSil.Size = new System.Drawing.Size(76, 37);
            this.btnBakimSil.TabIndex = 4;
            this.btnBakimSil.Text = "Sil";
            this.btnBakimSil.UseVisualStyleBackColor = false;
            this.btnBakimSil.Click += new System.EventHandler(this.btnBakimSil_Click);
            // 
            // btnBakimTurEkle
            // 
            this.btnBakimTurEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBakimTurEkle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBakimTurEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakimTurEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakimTurEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBakimTurEkle.Location = new System.Drawing.Point(3, 91);
            this.btnBakimTurEkle.Name = "btnBakimTurEkle";
            this.btnBakimTurEkle.Size = new System.Drawing.Size(117, 37);
            this.btnBakimTurEkle.TabIndex = 3;
            this.btnBakimTurEkle.Text = "Bakım Ekle";
            this.btnBakimTurEkle.UseVisualStyleBackColor = false;
            this.btnBakimTurEkle.Click += new System.EventHandler(this.btnBakimTurEkle_Click);
            // 
            // btnBakimKaydet
            // 
            this.btnBakimKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBakimKaydet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBakimKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakimKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakimKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBakimKaydet.Location = new System.Drawing.Point(395, 91);
            this.btnBakimKaydet.Name = "btnBakimKaydet";
            this.btnBakimKaydet.Size = new System.Drawing.Size(76, 37);
            this.btnBakimKaydet.TabIndex = 2;
            this.btnBakimKaydet.Text = "Kaydet";
            this.btnBakimKaydet.UseVisualStyleBackColor = false;
            this.btnBakimKaydet.Click += new System.EventHandler(this.btnBakimKaydet_Click);
            // 
            // tBakimAdi
            // 
            this.tBakimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBakimAdi.Location = new System.Drawing.Point(119, 34);
            this.tBakimAdi.Name = "tBakimAdi";
            this.tBakimAdi.Size = new System.Drawing.Size(154, 23);
            this.tBakimAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bakım Grubu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridBakimGrubu
            // 
            this.gridBakimGrubu.AllowUserToAddRows = false;
            this.gridBakimGrubu.AllowUserToDeleteRows = false;
            this.gridBakimGrubu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBakimGrubu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBakimGrubu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBakimGrubu.Location = new System.Drawing.Point(0, 0);
            this.gridBakimGrubu.Name = "gridBakimGrubu";
            this.gridBakimGrubu.ReadOnly = true;
            this.gridBakimGrubu.RowHeadersVisible = false;
            this.gridBakimGrubu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBakimGrubu.Size = new System.Drawing.Size(474, 316);
            this.gridBakimGrubu.TabIndex = 1;
            // 
            // fBakimGrubu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 490);
            this.Name = "fBakimGrubu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAKIM GRUBU";
            this.Load += new System.EventHandler(this.fBakimGrubu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBakimGrubu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBakimSil;
        private System.Windows.Forms.Button btnBakimTurEkle;
        private System.Windows.Forms.Button btnBakimKaydet;
        private System.Windows.Forms.TextBox tBakimAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridBakimGrubu;
    }
}