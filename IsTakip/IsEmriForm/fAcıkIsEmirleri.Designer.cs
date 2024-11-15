namespace IsTakip.IsEmriForm
{
    partial class fAcıkIsEmirleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAcıkIsEmirleri));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.gridAcıkIsEmirleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAcıkIsEmirleri)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lSayi);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnIslemYap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridAcıkIsEmirleri);
            this.splitContainer1.Size = new System.Drawing.Size(984, 450);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.TabIndex = 0;
            // 
            // lSayi
            // 
            this.lSayi.AutoSize = true;
            this.lSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSayi.Location = new System.Drawing.Point(147, 70);
            this.lSayi.Name = "lSayi";
            this.lSayi.Size = new System.Drawing.Size(18, 20);
            this.lSayi.TabIndex = 4;
            this.lSayi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Açık İş Emri Sayısı :";
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIslemYap.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIslemYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemYap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemYap.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIslemYap.Location = new System.Drawing.Point(888, 53);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(93, 37);
            this.btnIslemYap.TabIndex = 2;
            this.btnIslemYap.Text = "İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = false;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // gridAcıkIsEmirleri
            // 
            this.gridAcıkIsEmirleri.AllowUserToAddRows = false;
            this.gridAcıkIsEmirleri.AllowUserToDeleteRows = false;
            this.gridAcıkIsEmirleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAcıkIsEmirleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAcıkIsEmirleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAcıkIsEmirleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAcıkIsEmirleri.Location = new System.Drawing.Point(0, 0);
            this.gridAcıkIsEmirleri.Name = "gridAcıkIsEmirleri";
            this.gridAcıkIsEmirleri.ReadOnly = true;
            this.gridAcıkIsEmirleri.RowHeadersVisible = false;
            this.gridAcıkIsEmirleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAcıkIsEmirleri.Size = new System.Drawing.Size(984, 353);
            this.gridAcıkIsEmirleri.TabIndex = 1;
            // 
            // fAcıkIsEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAcıkIsEmirleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AÇIK İŞ EMİRLERİ";
            this.Load += new System.EventHandler(this.fAcıkIsEmirleri_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAcıkIsEmirleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridAcıkIsEmirleri;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.Label lSayi;
        private System.Windows.Forms.Label label1;
    }
}