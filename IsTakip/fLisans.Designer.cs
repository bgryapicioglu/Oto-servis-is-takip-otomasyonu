namespace IsTakip
{
    partial class fLisans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLisans));
            this.label1 = new System.Windows.Forms.Label();
            this.lKontrolNo = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.tLisansNo = new System.Windows.Forms.TextBox();
            this.lcpuNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KONTROL NUMARASI";
            // 
            // lKontrolNo
            // 
            this.lKontrolNo.AutoSize = true;
            this.lKontrolNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKontrolNo.Location = new System.Drawing.Point(12, 38);
            this.lKontrolNo.Name = "lKontrolNo";
            this.lKontrolNo.Size = new System.Drawing.Size(48, 16);
            this.lKontrolNo.TabIndex = 2;
            this.lKontrolNo.Text = "Kontrol";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(12, 110);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(240, 23);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // tLisansNo
            // 
            this.tLisansNo.Location = new System.Drawing.Point(12, 84);
            this.tLisansNo.Name = "tLisansNo";
            this.tLisansNo.Size = new System.Drawing.Size(240, 20);
            this.tLisansNo.TabIndex = 4;
            // 
            // lcpuNo
            // 
            this.lcpuNo.AutoSize = true;
            this.lcpuNo.Location = new System.Drawing.Point(168, 38);
            this.lcpuNo.Name = "lcpuNo";
            this.lcpuNo.Size = new System.Drawing.Size(21, 13);
            this.lcpuNo.TabIndex = 5;
            this.lcpuNo.Text = "No";
            // 
            // fLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 162);
            this.Controls.Add(this.lcpuNo);
            this.Controls.Add(this.tLisansNo);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.lKontrolNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 201);
            this.Name = "fLisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LİSANS İŞLEMİ";
            this.Load += new System.EventHandler(this.fLisans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.Label lKontrolNo;
        private System.Windows.Forms.TextBox tLisansNo;
        private System.Windows.Forms.Label lcpuNo;
    }
}