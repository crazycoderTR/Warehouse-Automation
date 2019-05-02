namespace Depo_Otomasyon
{
    partial class stokdetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokdetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKayitTarihi = new System.Windows.Forms.TextBox();
            this.txtStokYetkili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.txtStokBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStokDetay = new System.Windows.Forms.DataGridView();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExcelAktar);
            this.groupBox1.Controls.Add(this.dgvStokDetay);
            this.groupBox1.Controls.Add(this.txtKayitTarihi);
            this.groupBox1.Controls.Add(this.txtStokYetkili);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.txtStokBarkod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Detay";
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKayitTarihi.Location = new System.Drawing.Point(323, 60);
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.ReadOnly = true;
            this.txtKayitTarihi.Size = new System.Drawing.Size(208, 21);
            this.txtKayitTarihi.TabIndex = 15;
            // 
            // txtStokYetkili
            // 
            this.txtStokYetkili.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokYetkili.Location = new System.Drawing.Point(323, 29);
            this.txtStokYetkili.Name = "txtStokYetkili";
            this.txtStokYetkili.ReadOnly = true;
            this.txtStokYetkili.Size = new System.Drawing.Size(208, 21);
            this.txtStokYetkili.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stok Kayıt Tarihi:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stok Yetkilisi:";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(90, 60);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.ReadOnly = true;
            this.txtStokAdi.Size = new System.Drawing.Size(121, 21);
            this.txtStokAdi.TabIndex = 11;
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Location = new System.Drawing.Point(90, 29);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.ReadOnly = true;
            this.txtStokBarkod.Size = new System.Drawing.Size(121, 21);
            this.txtStokBarkod.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stok Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stok Barkod:";
            // 
            // dgvStokDetay
            // 
            this.dgvStokDetay.AllowUserToAddRows = false;
            this.dgvStokDetay.AllowUserToDeleteRows = false;
            this.dgvStokDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStokDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokDetay.Location = new System.Drawing.Point(11, 88);
            this.dgvStokDetay.Name = "dgvStokDetay";
            this.dgvStokDetay.ReadOnly = true;
            this.dgvStokDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokDetay.Size = new System.Drawing.Size(669, 294);
            this.dgvStokDetay.TabIndex = 16;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelAktar.Location = new System.Drawing.Point(546, 49);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(134, 33);
            this.btnExcelAktar.TabIndex = 17;
            this.btnExcelAktar.Text = "Ecxel Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // stokdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 409);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stokdetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Detay";
            this.Load += new System.EventHandler(this.stokdetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKayitTarihi;
        private System.Windows.Forms.TextBox txtStokYetkili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.TextBox txtStokBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStokDetay;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}