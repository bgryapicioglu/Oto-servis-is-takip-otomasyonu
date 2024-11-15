namespace IsTakip.IsEmriForm
{
    partial class fIslemYap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIslemYap));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tAlinanUcret = new System.Windows.Forms.TextBox();
            this.lKdvliToplam = new System.Windows.Forms.Label();
            this.lKdv = new System.Windows.Forms.Label();
            this.lGenelToplam = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.btnIslemSil = new System.Windows.Forms.Button();
            this.tDigerIslem = new System.Windows.Forms.TextBox();
            this.btnDigerKaydet = new System.Windows.Forms.Button();
            this.btnIslemEkle = new System.Windows.Forms.Button();
            this.tDigerToplam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tToplam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tDigerBirimFiyat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBirimFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tDigerAdet = new System.Windows.Forms.NumericUpDown();
            this.tAdet = new System.Windows.Forms.NumericUpDown();
            this.cmbBakimTur = new System.Windows.Forms.ComboBox();
            this.cmbBakimGrubu = new System.Windows.Forms.ComboBox();
            this.tArac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tPlaka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridIslemler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDigerAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIslemler)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnIslemSil);
            this.splitContainer1.Panel1.Controls.Add(this.tDigerIslem);
            this.splitContainer1.Panel1.Controls.Add(this.btnDigerKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnIslemEkle);
            this.splitContainer1.Panel1.Controls.Add(this.tDigerToplam);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.tToplam);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tDigerBirimFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.tBirimFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tDigerAdet);
            this.splitContainer1.Panel1.Controls.Add(this.tAdet);
            this.splitContainer1.Panel1.Controls.Add(this.cmbBakimTur);
            this.splitContainer1.Panel1.Controls.Add(this.cmbBakimGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.tArac);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tPlaka);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tAdiSoyadi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridIslemler);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 509);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tAlinanUcret);
            this.panel1.Controls.Add(this.lKdvliToplam);
            this.panel1.Controls.Add(this.lKdv);
            this.panel1.Controls.Add(this.lGenelToplam);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbl15);
            this.panel1.Location = new System.Drawing.Point(945, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 135);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(166, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tAlinanUcret
            // 
            this.tAlinanUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlinanUcret.Location = new System.Drawing.Point(20, 98);
            this.tAlinanUcret.Name = "tAlinanUcret";
            this.tAlinanUcret.Size = new System.Drawing.Size(139, 29);
            this.tAlinanUcret.TabIndex = 1;
            this.tAlinanUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBirimFiyat_KeyPress);
            // 
            // lKdvliToplam
            // 
            this.lKdvliToplam.AutoSize = true;
            this.lKdvliToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lKdvliToplam.Location = new System.Drawing.Point(139, 71);
            this.lKdvliToplam.Name = "lKdvliToplam";
            this.lKdvliToplam.Size = new System.Drawing.Size(23, 16);
            this.lKdvliToplam.TabIndex = 0;
            this.lKdvliToplam.Text = "10";
            // 
            // lKdv
            // 
            this.lKdv.AutoSize = true;
            this.lKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lKdv.Location = new System.Drawing.Point(139, 42);
            this.lKdv.Name = "lKdv";
            this.lKdv.Size = new System.Drawing.Size(23, 16);
            this.lKdv.TabIndex = 0;
            this.lKdv.Text = "10";
            // 
            // lGenelToplam
            // 
            this.lGenelToplam.AutoSize = true;
            this.lGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lGenelToplam.Location = new System.Drawing.Point(139, 13);
            this.lGenelToplam.Name = "lGenelToplam";
            this.lGenelToplam.Size = new System.Drawing.Size(23, 16);
            this.lGenelToplam.TabIndex = 0;
            this.lGenelToplam.Text = "10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(17, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "KDV\'li TOPLAM :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(17, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "KDV :";
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl15.Location = new System.Drawing.Point(17, 13);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(116, 16);
            this.lbl15.TabIndex = 0;
            this.lbl15.Text = "GENEL TOPLAM :";
            // 
            // btnIslemSil
            // 
            this.btnIslemSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIslemSil.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIslemSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemSil.ForeColor = System.Drawing.Color.Crimson;
            this.btnIslemSil.Location = new System.Drawing.Point(875, 15);
            this.btnIslemSil.Name = "btnIslemSil";
            this.btnIslemSil.Size = new System.Drawing.Size(64, 29);
            this.btnIslemSil.TabIndex = 18;
            this.btnIslemSil.Text = "Sil";
            this.btnIslemSil.UseVisualStyleBackColor = false;
            this.btnIslemSil.Click += new System.EventHandler(this.btnIslemSil_Click);
            // 
            // tDigerIslem
            // 
            this.tDigerIslem.Location = new System.Drawing.Point(121, 100);
            this.tDigerIslem.Name = "tDigerIslem";
            this.tDigerIslem.Size = new System.Drawing.Size(154, 20);
            this.tDigerIslem.TabIndex = 5;
            // 
            // btnDigerKaydet
            // 
            this.btnDigerKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDigerKaydet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDigerKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigerKaydet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDigerKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDigerKaydet.Location = new System.Drawing.Point(879, 103);
            this.btnDigerKaydet.Name = "btnDigerKaydet";
            this.btnDigerKaydet.Size = new System.Drawing.Size(60, 24);
            this.btnDigerKaydet.TabIndex = 8;
            this.btnDigerKaydet.Text = "Ekle";
            this.btnDigerKaydet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDigerKaydet.UseVisualStyleBackColor = false;
            this.btnDigerKaydet.Click += new System.EventHandler(this.btnDigerKaydet_Click);
            // 
            // btnIslemEkle
            // 
            this.btnIslemEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIslemEkle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIslemEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemEkle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIslemEkle.Location = new System.Drawing.Point(879, 65);
            this.btnIslemEkle.Name = "btnIslemEkle";
            this.btnIslemEkle.Size = new System.Drawing.Size(60, 24);
            this.btnIslemEkle.TabIndex = 4;
            this.btnIslemEkle.Text = "Ekle";
            this.btnIslemEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIslemEkle.UseVisualStyleBackColor = false;
            this.btnIslemEkle.Click += new System.EventHandler(this.btnIslemEkle_Click);
            // 
            // tDigerToplam
            // 
            this.tDigerToplam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tDigerToplam.Enabled = false;
            this.tDigerToplam.Location = new System.Drawing.Point(784, 100);
            this.tDigerToplam.Name = "tDigerToplam";
            this.tDigerToplam.Size = new System.Drawing.Size(89, 20);
            this.tDigerToplam.TabIndex = 4;
            this.tDigerToplam.TabStop = false;
            this.tDigerToplam.Text = "0";
            this.tDigerToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(708, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "TOPLAM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tToplam
            // 
            this.tToplam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tToplam.Enabled = false;
            this.tToplam.Location = new System.Drawing.Point(784, 70);
            this.tToplam.Name = "tToplam";
            this.tToplam.Size = new System.Drawing.Size(89, 20);
            this.tToplam.TabIndex = 4;
            this.tToplam.TabStop = false;
            this.tToplam.Text = "0";
            this.tToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(708, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "TOPLAM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tDigerBirimFiyat
            // 
            this.tDigerBirimFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tDigerBirimFiyat.Location = new System.Drawing.Point(609, 102);
            this.tDigerBirimFiyat.Name = "tDigerBirimFiyat";
            this.tDigerBirimFiyat.Size = new System.Drawing.Size(89, 20);
            this.tDigerBirimFiyat.TabIndex = 7;
            this.tDigerBirimFiyat.Text = "0";
            this.tDigerBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tDigerBirimFiyat.Click += new System.EventHandler(this.tBirimFiyat_Click);
            this.tDigerBirimFiyat.TextChanged += new System.EventHandler(this.tDigerBirimFiyat_TextChanged);
            this.tDigerBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tDigerBirimFiyat_KeyPress);
            this.tDigerBirimFiyat.Leave += new System.EventHandler(this.tDigerBirimFiyat_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(517, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "BİRİM FİYAT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBirimFiyat
            // 
            this.tBirimFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBirimFiyat.Location = new System.Drawing.Point(609, 72);
            this.tBirimFiyat.Name = "tBirimFiyat";
            this.tBirimFiyat.Size = new System.Drawing.Size(89, 20);
            this.tBirimFiyat.TabIndex = 3;
            this.tBirimFiyat.Text = "0";
            this.tBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBirimFiyat.Click += new System.EventHandler(this.tBirimFiyat_Click);
            this.tBirimFiyat.TextChanged += new System.EventHandler(this.tBirimFiyat_TextChanged);
            this.tBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBirimFiyat_KeyPress);
            this.tBirimFiyat.Leave += new System.EventHandler(this.tBirimFiyat_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(517, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "BİRİM FİYAT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tDigerAdet
            // 
            this.tDigerAdet.Location = new System.Drawing.Point(418, 100);
            this.tDigerAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tDigerAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tDigerAdet.Name = "tDigerAdet";
            this.tDigerAdet.Size = new System.Drawing.Size(89, 20);
            this.tDigerAdet.TabIndex = 6;
            this.tDigerAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tDigerAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tDigerAdet.ValueChanged += new System.EventHandler(this.tDigerAdet_ValueChanged);
            // 
            // tAdet
            // 
            this.tAdet.Location = new System.Drawing.Point(418, 70);
            this.tAdet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tAdet.Name = "tAdet";
            this.tAdet.Size = new System.Drawing.Size(89, 20);
            this.tAdet.TabIndex = 2;
            this.tAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tAdet.ValueChanged += new System.EventHandler(this.tAdet_ValueChanged);
            // 
            // cmbBakimTur
            // 
            this.cmbBakimTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakimTur.FormattingEnabled = true;
            this.cmbBakimTur.Location = new System.Drawing.Point(418, 41);
            this.cmbBakimTur.Name = "cmbBakimTur";
            this.cmbBakimTur.Size = new System.Drawing.Size(154, 21);
            this.cmbBakimTur.TabIndex = 1;
            // 
            // cmbBakimGrubu
            // 
            this.cmbBakimGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakimGrubu.FormattingEnabled = true;
            this.cmbBakimGrubu.Location = new System.Drawing.Point(418, 12);
            this.cmbBakimGrubu.Name = "cmbBakimGrubu";
            this.cmbBakimGrubu.Size = new System.Drawing.Size(154, 21);
            this.cmbBakimGrubu.TabIndex = 0;
            this.cmbBakimGrubu.SelectedIndexChanged += new System.EventHandler(this.cmbBakimGrubu_SelectedIndexChanged);
            // 
            // tArac
            // 
            this.tArac.Enabled = false;
            this.tArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tArac.Location = new System.Drawing.Point(121, 70);
            this.tArac.Name = "tArac";
            this.tArac.ReadOnly = true;
            this.tArac.Size = new System.Drawing.Size(154, 23);
            this.tArac.TabIndex = 12;
            this.tArac.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "DİĞER İŞLEM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "ARAÇ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tPlaka
            // 
            this.tPlaka.Enabled = false;
            this.tPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tPlaka.Location = new System.Drawing.Point(121, 41);
            this.tPlaka.Name = "tPlaka";
            this.tPlaka.ReadOnly = true;
            this.tPlaka.Size = new System.Drawing.Size(154, 23);
            this.tPlaka.TabIndex = 12;
            this.tPlaka.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(311, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "BAKIM GRUBU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(311, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "ADET";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ADI SOYADI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(311, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ADET";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(311, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "BAKIM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tAdiSoyadi
            // 
            this.tAdiSoyadi.Enabled = false;
            this.tAdiSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAdiSoyadi.Location = new System.Drawing.Point(121, 12);
            this.tAdiSoyadi.Name = "tAdiSoyadi";
            this.tAdiSoyadi.ReadOnly = true;
            this.tAdiSoyadi.Size = new System.Drawing.Size(154, 23);
            this.tAdiSoyadi.TabIndex = 12;
            this.tAdiSoyadi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "PLAKA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridIslemler
            // 
            this.gridIslemler.AllowUserToAddRows = false;
            this.gridIslemler.AllowUserToDeleteRows = false;
            this.gridIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIslemler.Location = new System.Drawing.Point(0, 0);
            this.gridIslemler.Name = "gridIslemler";
            this.gridIslemler.ReadOnly = true;
            this.gridIslemler.RowHeadersVisible = false;
            this.gridIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIslemler.Size = new System.Drawing.Size(1191, 368);
            this.gridIslemler.TabIndex = 2;
            this.gridIslemler.TabStop = false;
            // 
            // fIslemYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1191, 509);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fIslemYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLEM YAP";
            this.Load += new System.EventHandler(this.fIslemYap_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDigerAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIslemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridIslemler;
        private System.Windows.Forms.TextBox tAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tArac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tAdet;
        private System.Windows.Forms.ComboBox cmbBakimTur;
        private System.Windows.Forms.ComboBox cmbBakimGrubu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBirimFiyat;
        private System.Windows.Forms.Button btnIslemEkle;
        private System.Windows.Forms.TextBox tToplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tDigerIslem;
        private System.Windows.Forms.TextBox tDigerToplam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tDigerBirimFiyat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown tDigerAdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDigerKaydet;
        private System.Windows.Forms.Button btnIslemSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lKdv;
        private System.Windows.Forms.Label lGenelToplam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tAlinanUcret;
        private System.Windows.Forms.Label lKdvliToplam;
        private System.Windows.Forms.Label label16;
    }
}