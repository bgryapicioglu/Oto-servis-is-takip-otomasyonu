namespace IsTakip.IsEmriForm
{
    partial class fGecmisArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGecmisArama));
            this.tAra = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridGecmis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // tAra
            // 
            this.tAra.Location = new System.Drawing.Point(12, 39);
            this.tAra.Name = "tAra";
            this.tAra.Size = new System.Drawing.Size(284, 20);
            this.tAra.TabIndex = 0;
            this.tAra.TextChanged += new System.EventHandler(this.tAra_TextChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnDetayGoster);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridGecmis);
            this.splitContainer1.Size = new System.Drawing.Size(1450, 450);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetayGoster.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDetayGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetayGoster.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetayGoster.Location = new System.Drawing.Point(1306, 31);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(132, 34);
            this.btnDetayGoster.TabIndex = 7;
            this.btnDetayGoster.Text = "Detay Göster";
            this.btnDetayGoster.UseVisualStyleBackColor = false;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARA (PLAKA VEYA ŞASİ NO)";
            // 
            // gridGecmis
            // 
            this.gridGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGecmis.Location = new System.Drawing.Point(0, 0);
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.Size = new System.Drawing.Size(1450, 375);
            this.gridGecmis.TabIndex = 0;
            // 
            // fGecmisArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1450, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGecmisArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEÇMİŞ ARAMA";
            this.Load += new System.EventHandler(this.fGecmisArama_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tAra;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridGecmis;
        private System.Windows.Forms.Button btnDetayGoster;
    }
}