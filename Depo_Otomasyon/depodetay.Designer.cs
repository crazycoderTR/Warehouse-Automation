namespace Depo_Otomasyon
{
    partial class depodetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depodetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtToplamStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDepoDetay = new System.Windows.Forms.DataGridView();
            this.txtDepoKayıtTarih = new System.Windows.Forms.TextBox();
            this.txtDepoYetkili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.txtDepoNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExcelAktar);
            this.groupBox1.Controls.Add(this.txtToplamStok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvDepoDetay);
            this.groupBox1.Controls.Add(this.txtDepoKayıtTarih);
            this.groupBox1.Controls.Add(this.txtDepoYetkili);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDepoAdi);
            this.groupBox1.Controls.Add(this.txtDepoNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Detay";
            // 
            // txtToplamStok
            // 
            this.txtToplamStok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToplamStok.Location = new System.Drawing.Point(561, 61);
            this.txtToplamStok.Name = "txtToplamStok";
            this.txtToplamStok.ReadOnly = true;
            this.txtToplamStok.Size = new System.Drawing.Size(165, 21);
            this.txtToplamStok.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Depoda Bulunan Toplam Stok;";
            // 
            // dgvDepoDetay
            // 
            this.dgvDepoDetay.AllowUserToAddRows = false;
            this.dgvDepoDetay.AllowUserToDeleteRows = false;
            this.dgvDepoDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepoDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepoDetay.Location = new System.Drawing.Point(9, 102);
            this.dgvDepoDetay.Name = "dgvDepoDetay";
            this.dgvDepoDetay.ReadOnly = true;
            this.dgvDepoDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepoDetay.Size = new System.Drawing.Size(685, 279);
            this.dgvDepoDetay.TabIndex = 8;
            // 
            // txtDepoKayıtTarih
            // 
            this.txtDepoKayıtTarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepoKayıtTarih.Location = new System.Drawing.Point(321, 61);
            this.txtDepoKayıtTarih.Name = "txtDepoKayıtTarih";
            this.txtDepoKayıtTarih.ReadOnly = true;
            this.txtDepoKayıtTarih.Size = new System.Drawing.Size(208, 21);
            this.txtDepoKayıtTarih.TabIndex = 7;
            // 
            // txtDepoYetkili
            // 
            this.txtDepoYetkili.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepoYetkili.Location = new System.Drawing.Point(321, 30);
            this.txtDepoYetkili.Name = "txtDepoYetkili";
            this.txtDepoYetkili.ReadOnly = true;
            this.txtDepoYetkili.Size = new System.Drawing.Size(208, 21);
            this.txtDepoYetkili.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depo Kayıt Tarihi:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Depo Yetkilisi:";
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(71, 61);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.ReadOnly = true;
            this.txtDepoAdi.Size = new System.Drawing.Size(121, 21);
            this.txtDepoAdi.TabIndex = 3;
            // 
            // txtDepoNo
            // 
            this.txtDepoNo.Location = new System.Drawing.Point(71, 30);
            this.txtDepoNo.Name = "txtDepoNo";
            this.txtDepoNo.ReadOnly = true;
            this.txtDepoNo.Size = new System.Drawing.Size(121, 21);
            this.txtDepoNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depo Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depo No:";
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelAktar.Location = new System.Drawing.Point(700, 102);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(33, 279);
            this.btnExcelAktar.TabIndex = 11;
            this.btnExcelAktar.Text = "E\r\nx\r\nc\r\ne\r\nl\r\n\r\nA\r\nk\r\nt\r\na\r\nr";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // depodetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 408);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "depodetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Detay";
            this.Load += new System.EventHandler(this.depodetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.TextBox txtDepoNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepoKayıtTarih;
        private System.Windows.Forms.TextBox txtDepoYetkili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDepoDetay;
        private System.Windows.Forms.TextBox txtToplamStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}