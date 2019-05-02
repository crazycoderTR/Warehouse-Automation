namespace Depo_Otomasyon
{
    partial class stokgirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokgirisi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDepolar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pcbStokResim = new System.Windows.Forms.PictureBox();
            this.pcbStokBarkod = new System.Windows.Forms.PictureBox();
            this.txtOlcu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGirenMiktarMaliyeti = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGirenMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMevcutMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYetkiliPersonel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStokCinsi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokBarkod = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStokResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStokBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbDepolar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pcbStokResim);
            this.panel1.Controls.Add(this.pcbStokBarkod);
            this.panel1.Controls.Add(this.txtOlcu);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtGirenMiktarMaliyeti);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBirimFiyat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtGirenMiktar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMevcutMiktar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtYetkiliPersonel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFirma);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStokCinsi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStokBarkod);
            this.panel1.Controls.Add(this.txtStokAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 429);
            this.panel1.TabIndex = 20;
            // 
            // cmbDepolar
            // 
            this.cmbDepolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepolar.FormattingEnabled = true;
            this.cmbDepolar.Location = new System.Drawing.Point(152, 163);
            this.cmbDepolar.Name = "cmbDepolar";
            this.cmbDepolar.Size = new System.Drawing.Size(120, 21);
            this.cmbDepolar.TabIndex = 73;
            this.cmbDepolar.SelectedIndexChanged += new System.EventHandler(this.cmbDepolar_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(310, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 14);
            this.label12.TabIndex = 72;
            this.label12.Text = "Stok Resmi;";
            // 
            // pcbStokResim
            // 
            this.pcbStokResim.Image = ((System.Drawing.Image)(resources.GetObject("pcbStokResim.Image")));
            this.pcbStokResim.Location = new System.Drawing.Point(278, 166);
            this.pcbStokResim.Name = "pcbStokResim";
            this.pcbStokResim.Size = new System.Drawing.Size(145, 110);
            this.pcbStokResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStokResim.TabIndex = 71;
            this.pcbStokResim.TabStop = false;
            // 
            // pcbStokBarkod
            // 
            this.pcbStokBarkod.Enabled = false;
            this.pcbStokBarkod.Image = ((System.Drawing.Image)(resources.GetObject("pcbStokBarkod.Image")));
            this.pcbStokBarkod.Location = new System.Drawing.Point(278, 49);
            this.pcbStokBarkod.Name = "pcbStokBarkod";
            this.pcbStokBarkod.Size = new System.Drawing.Size(145, 92);
            this.pcbStokBarkod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStokBarkod.TabIndex = 70;
            this.pcbStokBarkod.TabStop = false;
            this.pcbStokBarkod.Click += new System.EventHandler(this.pcbStokBarkod_Click);
            // 
            // txtOlcu
            // 
            this.txtOlcu.Location = new System.Drawing.Point(278, 282);
            this.txtOlcu.Name = "txtOlcu";
            this.txtOlcu.ReadOnly = true;
            this.txtOlcu.Size = new System.Drawing.Size(80, 20);
            this.txtOlcu.TabIndex = 69;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 394);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 67;
            this.label10.Text = "İşlem Tarih:";
            // 
            // txtGirenMiktarMaliyeti
            // 
            this.txtGirenMiktarMaliyeti.Location = new System.Drawing.Point(152, 358);
            this.txtGirenMiktarMaliyeti.Name = "txtGirenMiktarMaliyeti";
            this.txtGirenMiktarMaliyeti.ReadOnly = true;
            this.txtGirenMiktarMaliyeti.Size = new System.Drawing.Size(120, 20);
            this.txtGirenMiktarMaliyeti.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 66;
            this.label11.Text = "Stok Maliyeti:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(152, 320);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtBirimFiyat.TabIndex = 63;
            this.txtBirimFiyat.TextChanged += new System.EventHandler(this.txtBirimFiyat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 14);
            this.label8.TabIndex = 64;
            this.label8.Text = "Stok Birim Fiyatı:";
            // 
            // txtGirenMiktar
            // 
            this.txtGirenMiktar.Location = new System.Drawing.Point(152, 242);
            this.txtGirenMiktar.Name = "txtGirenMiktar";
            this.txtGirenMiktar.Size = new System.Drawing.Size(120, 20);
            this.txtGirenMiktar.TabIndex = 61;
            this.txtGirenMiktar.TextChanged += new System.EventHandler(this.txtGirenMiktar_TextChanged);
            this.txtGirenMiktar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGirenMiktar_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 14);
            this.label7.TabIndex = 62;
            this.label7.Text = "Giren Stok Miktarı:";
            // 
            // txtMevcutMiktar
            // 
            this.txtMevcutMiktar.Location = new System.Drawing.Point(152, 282);
            this.txtMevcutMiktar.Name = "txtMevcutMiktar";
            this.txtMevcutMiktar.ReadOnly = true;
            this.txtMevcutMiktar.Size = new System.Drawing.Size(120, 20);
            this.txtMevcutMiktar.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 14);
            this.label9.TabIndex = 60;
            this.label9.Text = "Mevcut Stok Miktarı:";
            // 
            // txtYetkiliPersonel
            // 
            this.txtYetkiliPersonel.Location = new System.Drawing.Point(152, 204);
            this.txtYetkiliPersonel.Name = "txtYetkiliPersonel";
            this.txtYetkiliPersonel.ReadOnly = true;
            this.txtYetkiliPersonel.Size = new System.Drawing.Size(120, 20);
            this.txtYetkiliPersonel.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 14);
            this.label6.TabIndex = 39;
            this.label6.Text = "Stok Yetkili Personel:";
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBul.Location = new System.Drawing.Point(278, 11);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(145, 25);
            this.btnBul.TabIndex = 38;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Giriş Depo:";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(152, 123);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(120, 20);
            this.txtFirma.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "Üretici Firma:";
            // 
            // txtStokCinsi
            // 
            this.txtStokCinsi.Location = new System.Drawing.Point(152, 84);
            this.txtStokCinsi.Name = "txtStokCinsi";
            this.txtStokCinsi.ReadOnly = true;
            this.txtStokCinsi.Size = new System.Drawing.Size(120, 20);
            this.txtStokCinsi.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Stok Cinsi:";
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Location = new System.Drawing.Point(152, 14);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(120, 20);
            this.txtStokBarkod.TabIndex = 28;
            this.txtStokBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStokBarkod_KeyDown);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(152, 48);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.ReadOnly = true;
            this.txtStokAdi.Size = new System.Drawing.Size(120, 20);
            this.txtStokAdi.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Stok İsmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stok Barkod:";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.Control;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Location = new System.Drawing.Point(288, 447);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(145, 40);
            this.btnKapat.TabIndex = 28;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokEkle.Location = new System.Drawing.Point(8, 447);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(274, 40);
            this.btnStokEkle.TabIndex = 27;
            this.btnStokEkle.Text = "Girişi Yap";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // stokgirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(451, 496);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "stokgirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Giriş";
            this.Load += new System.EventHandler(this.StokGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStokResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStokBarkod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.TextBox txtStokCinsi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokBarkod;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtYetkiliPersonel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGirenMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMevcutMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGirenMiktarMaliyeti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOlcu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pcbStokResim;
        private System.Windows.Forms.PictureBox pcbStokBarkod;
        private System.Windows.Forms.ComboBox cmbDepolar;
    }
}