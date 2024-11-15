namespace IsTakip.IsEmriForm
{
    partial class fIsEmriOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIsEmriOlustur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tModelYili = new System.Windows.Forms.MaskedTextBox();
            this.btnIsEmriKaydet = new System.Windows.Forms.Button();
            this.tGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.tSasiNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tGelisSebebi = new System.Windows.Forms.TextBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.tKm = new System.Windows.Forms.TextBox();
            this.tPlaka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tEposta = new System.Windows.Forms.TextBox();
            this.tSoyadi = new System.Windows.Forms.TextBox();
            this.tTelefon = new System.Windows.Forms.TextBox();
            this.tAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tModelYili);
            this.groupBox1.Controls.Add(this.btnIsEmriKaydet);
            this.groupBox1.Controls.Add(this.tGelisTarihi);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.tSasiNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tGelisSebebi);
            this.groupBox1.Controls.Add(this.cmbYakit);
            this.groupBox1.Controls.Add(this.tKm);
            this.groupBox1.Controls.Add(this.tPlaka);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 541);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAÇ";
            // 
            // tModelYili
            // 
            this.tModelYili.Location = new System.Drawing.Point(260, 168);
            this.tModelYili.Mask = "0000";
            this.tModelYili.Name = "tModelYili";
            this.tModelYili.Size = new System.Drawing.Size(218, 22);
            this.tModelYili.TabIndex = 3;
            this.tModelYili.ValidatingType = typeof(int);
            // 
            // btnIsEmriKaydet
            // 
            this.btnIsEmriKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIsEmriKaydet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIsEmriKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsEmriKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsEmriKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIsEmriKaydet.Location = new System.Drawing.Point(416, 438);
            this.btnIsEmriKaydet.Name = "btnIsEmriKaydet";
            this.btnIsEmriKaydet.Size = new System.Drawing.Size(62, 83);
            this.btnIsEmriKaydet.TabIndex = 9;
            this.btnIsEmriKaydet.Text = "Kaydet";
            this.btnIsEmriKaydet.UseVisualStyleBackColor = false;
            this.btnIsEmriKaydet.Click += new System.EventHandler(this.btnIsEmriKaydet_Click);
            // 
            // tGelisTarihi
            // 
            this.tGelisTarihi.Location = new System.Drawing.Point(16, 292);
            this.tGelisTarihi.Name = "tGelisTarihi";
            this.tGelisTarihi.Size = new System.Drawing.Size(462, 22);
            this.tGelisTarihi.TabIndex = 6;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(16, 112);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(462, 24);
            this.cmbModel.TabIndex = 1;
            // 
            // tSasiNo
            // 
            this.tSasiNo.Location = new System.Drawing.Point(16, 366);
            this.tSasiNo.Name = "tSasiNo";
            this.tSasiNo.Size = new System.Drawing.Size(462, 22);
            this.tSasiNo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(16, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Geliş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(16, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yakıt Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // tGelisSebebi
            // 
            this.tGelisSebebi.Location = new System.Drawing.Point(16, 438);
            this.tGelisSebebi.Multiline = true;
            this.tGelisSebebi.Name = "tGelisSebebi";
            this.tGelisSebebi.Size = new System.Drawing.Size(391, 83);
            this.tGelisSebebi.TabIndex = 8;
            // 
            // cmbYakit
            // 
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(16, 166);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(218, 24);
            this.cmbYakit.TabIndex = 2;
            // 
            // tKm
            // 
            this.tKm.Location = new System.Drawing.Point(16, 231);
            this.tKm.Name = "tKm";
            this.tKm.Size = new System.Drawing.Size(218, 22);
            this.tKm.TabIndex = 4;
            // 
            // tPlaka
            // 
            this.tPlaka.Location = new System.Drawing.Point(260, 231);
            this.tPlaka.Name = "tPlaka";
            this.tPlaka.Size = new System.Drawing.Size(218, 22);
            this.tPlaka.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(16, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Geliş Sebebi";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(16, 52);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(218, 24);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "KM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(260, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(260, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Model Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(16, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şasi No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tAdres);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tEposta);
            this.groupBox2.Controls.Add(this.tSoyadi);
            this.groupBox2.Controls.Add(this.tTelefon);
            this.groupBox2.Controls.Add(this.tAdi);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(75, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 281);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MÜŞTERİ";
            // 
            // tAdres
            // 
            this.tAdres.Enabled = false;
            this.tAdres.Location = new System.Drawing.Point(16, 180);
            this.tAdres.Multiline = true;
            this.tAdres.Name = "tAdres";
            this.tAdres.ReadOnly = true;
            this.tAdres.Size = new System.Drawing.Size(328, 83);
            this.tAdres.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(16, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Adres";
            // 
            // tEposta
            // 
            this.tEposta.Enabled = false;
            this.tEposta.Location = new System.Drawing.Point(194, 115);
            this.tEposta.Name = "tEposta";
            this.tEposta.ReadOnly = true;
            this.tEposta.Size = new System.Drawing.Size(150, 22);
            this.tEposta.TabIndex = 3;
            // 
            // tSoyadi
            // 
            this.tSoyadi.Enabled = false;
            this.tSoyadi.Location = new System.Drawing.Point(194, 52);
            this.tSoyadi.Name = "tSoyadi";
            this.tSoyadi.ReadOnly = true;
            this.tSoyadi.Size = new System.Drawing.Size(150, 22);
            this.tSoyadi.TabIndex = 3;
            // 
            // tTelefon
            // 
            this.tTelefon.Enabled = false;
            this.tTelefon.Location = new System.Drawing.Point(16, 114);
            this.tTelefon.Name = "tTelefon";
            this.tTelefon.ReadOnly = true;
            this.tTelefon.Size = new System.Drawing.Size(150, 22);
            this.tTelefon.TabIndex = 3;
            // 
            // tAdi
            // 
            this.tAdi.Enabled = false;
            this.tAdi.Location = new System.Drawing.Point(16, 52);
            this.tAdi.Name = "tAdi";
            this.tAdi.ReadOnly = true;
            this.tAdi.Size = new System.Drawing.Size(150, 22);
            this.tAdi.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(194, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "E-Posta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(16, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(194, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Soyadı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(16, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adı";
            // 
            // fIsEmriOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(519, 825);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fIsEmriOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞ EMRİ OLUŞTUR";
            this.Load += new System.EventHandler(this.fIsEmriOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tSasiNo;
        private System.Windows.Forms.TextBox tPlaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tGelisTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tGelisSebebi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIsEmriKaydet;
        private System.Windows.Forms.MaskedTextBox tModelYili;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tAdres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tEposta;
        private System.Windows.Forms.TextBox tSoyadi;
        private System.Windows.Forms.TextBox tTelefon;
        private System.Windows.Forms.TextBox tAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tKm;
    }
}