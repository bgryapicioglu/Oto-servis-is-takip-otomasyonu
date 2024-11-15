namespace IsTakip.Ayarlar
{
    partial class fModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fModel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnModelSil = new System.Windows.Forms.Button();
            this.btnModelKaydet = new System.Windows.Forms.Button();
            this.tModelAdi = new System.Windows.Forms.TextBox();
            this.lMarkaAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridModeller = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModeller)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnModelSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnModelKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.tModelAdi);
            this.splitContainer1.Panel1.Controls.Add(this.lMarkaAdi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridModeller);
            this.splitContainer1.Size = new System.Drawing.Size(447, 430);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnModelSil
            // 
            this.btnModelSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModelSil.BackColor = System.Drawing.Color.GhostWhite;
            this.btnModelSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelSil.ForeColor = System.Drawing.Color.Crimson;
            this.btnModelSil.Location = new System.Drawing.Point(283, 70);
            this.btnModelSil.Name = "btnModelSil";
            this.btnModelSil.Size = new System.Drawing.Size(76, 37);
            this.btnModelSil.TabIndex = 9;
            this.btnModelSil.Text = "Sil";
            this.btnModelSil.UseVisualStyleBackColor = false;
            this.btnModelSil.Click += new System.EventHandler(this.btnModelSil_Click);
            // 
            // btnModelKaydet
            // 
            this.btnModelKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModelKaydet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnModelKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModelKaydet.Location = new System.Drawing.Point(365, 70);
            this.btnModelKaydet.Name = "btnModelKaydet";
            this.btnModelKaydet.Size = new System.Drawing.Size(76, 37);
            this.btnModelKaydet.TabIndex = 8;
            this.btnModelKaydet.Text = "Kaydet";
            this.btnModelKaydet.UseVisualStyleBackColor = false;
            this.btnModelKaydet.Click += new System.EventHandler(this.btnModelKaydet_Click);
            // 
            // tModelAdi
            // 
            this.tModelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tModelAdi.Location = new System.Drawing.Point(99, 76);
            this.tModelAdi.Name = "tModelAdi";
            this.tModelAdi.Size = new System.Drawing.Size(154, 23);
            this.tModelAdi.TabIndex = 7;
            // 
            // lMarkaAdi
            // 
            this.lMarkaAdi.AutoSize = true;
            this.lMarkaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMarkaAdi.Location = new System.Drawing.Point(12, 9);
            this.lMarkaAdi.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.lMarkaAdi.Name = "lMarkaAdi";
            this.lMarkaAdi.Size = new System.Drawing.Size(66, 24);
            this.lMarkaAdi.TabIndex = 10;
            this.lMarkaAdi.Text = "Marka";
            this.lMarkaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridModeller
            // 
            this.gridModeller.AllowUserToAddRows = false;
            this.gridModeller.AllowUserToDeleteRows = false;
            this.gridModeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridModeller.Location = new System.Drawing.Point(0, 0);
            this.gridModeller.Name = "gridModeller";
            this.gridModeller.ReadOnly = true;
            this.gridModeller.RowHeadersVisible = false;
            this.gridModeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModeller.Size = new System.Drawing.Size(447, 313);
            this.gridModeller.TabIndex = 0;
            // 
            // fModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(447, 430);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 469);
            this.Name = "fModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODEL";
            this.Load += new System.EventHandler(this.fModel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridModeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnModelSil;
        private System.Windows.Forms.Button btnModelKaydet;
        private System.Windows.Forms.TextBox tModelAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridModeller;
        private System.Windows.Forms.Label lMarkaAdi;
    }
}