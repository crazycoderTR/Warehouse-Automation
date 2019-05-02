namespace Depo_Otomasyon
{
    partial class firmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firmalar));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirmaGoruntule = new System.Windows.Forms.Button();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdbforNumber = new System.Windows.Forms.RadioButton();
            this.rdbforName = new System.Windows.Forms.RadioButton();
            this.dgvFirmalar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirmaFax = new System.Windows.Forms.MaskedTextBox();
            this.txtFirmaTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.txtFirmaAdres = new System.Windows.Forms.TextBox();
            this.txtFirmaWeb = new System.Windows.Forms.TextBox();
            this.txtFirmaEmail = new System.Windows.Forms.TextBox();
            this.pcbFirmaFoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirmaYetkili = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirmaFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yetkili Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Adı:";
            // 
            // btnFirmaGoruntule
            // 
            this.btnFirmaGoruntule.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaGoruntule.Location = new System.Drawing.Point(2, 340);
            this.btnFirmaGoruntule.Name = "btnFirmaGoruntule";
            this.btnFirmaGoruntule.Size = new System.Drawing.Size(559, 40);
            this.btnFirmaGoruntule.TabIndex = 5;
            this.btnFirmaGoruntule.Text = "Firmaları Görüntüle";
            this.btnFirmaGoruntule.UseVisualStyleBackColor = true;
            this.btnFirmaGoruntule.Click += new System.EventHandler(this.btnFirmaGoruntule_Click);
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(133, 31);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.Size = new System.Drawing.Size(193, 23);
            this.txtFirmaAd.TabIndex = 0;
            this.txtFirmaAd.TextChanged += new System.EventHandler(this.txtFirmaAd_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Controls.Add(this.rdbforNumber);
            this.groupBox2.Controls.Add(this.rdbforName);
            this.groupBox2.Controls.Add(this.dgvFirmalar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 299);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firmalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(206, 61);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 22);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // rdbforNumber
            // 
            this.rdbforNumber.AutoSize = true;
            this.rdbforNumber.Location = new System.Drawing.Point(6, 62);
            this.rdbforNumber.Name = "rdbforNumber";
            this.rdbforNumber.Size = new System.Drawing.Size(183, 20);
            this.rdbforNumber.TabIndex = 2;
            this.rdbforNumber.TabStop = true;
            this.rdbforNumber.Text = "Numaraya Göre Firma Ara";
            this.rdbforNumber.UseVisualStyleBackColor = true;
            this.rdbforNumber.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdbforName
            // 
            this.rdbforName.AutoSize = true;
            this.rdbforName.Location = new System.Drawing.Point(6, 36);
            this.rdbforName.Name = "rdbforName";
            this.rdbforName.Size = new System.Drawing.Size(152, 20);
            this.rdbforName.TabIndex = 1;
            this.rdbforName.TabStop = true;
            this.rdbforName.Text = "İsime Göre Firma Ara";
            this.rdbforName.UseVisualStyleBackColor = true;
            this.rdbforName.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // dgvFirmalar
            // 
            this.dgvFirmalar.AllowUserToAddRows = false;
            this.dgvFirmalar.AllowUserToDeleteRows = false;
            this.dgvFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirmalar.Location = new System.Drawing.Point(6, 99);
            this.dgvFirmalar.Name = "dgvFirmalar";
            this.dgvFirmalar.ReadOnly = true;
            this.dgvFirmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFirmalar.Size = new System.Drawing.Size(533, 186);
            this.dgvFirmalar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtFirmaFax);
            this.groupBox1.Controls.Add(this.txtFirmaTel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnFirmaEkle);
            this.groupBox1.Controls.Add(this.txtFirmaAdres);
            this.groupBox1.Controls.Add(this.txtFirmaWeb);
            this.groupBox1.Controls.Add(this.txtFirmaEmail);
            this.groupBox1.Controls.Add(this.pcbFirmaFoto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFirmaYetkili);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirmaAd);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 322);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Ekle";
            // 
            // txtFirmaFax
            // 
            this.txtFirmaFax.Location = new System.Drawing.Point(135, 143);
            this.txtFirmaFax.Mask = "(999) 000-0000";
            this.txtFirmaFax.Name = "txtFirmaFax";
            this.txtFirmaFax.Size = new System.Drawing.Size(191, 23);
            this.txtFirmaFax.TabIndex = 59;
            // 
            // txtFirmaTel
            // 
            this.txtFirmaTel.Location = new System.Drawing.Point(135, 105);
            this.txtFirmaTel.Mask = "(999) 000-0000";
            this.txtFirmaTel.Name = "txtFirmaTel";
            this.txtFirmaTel.Size = new System.Drawing.Size(191, 23);
            this.txtFirmaTel.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Şirket Logosu Seçiniz;";
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.Location = new System.Drawing.Point(334, 272);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(205, 44);
            this.btnFirmaEkle.TabIndex = 21;
            this.btnFirmaEkle.Text = "Firma Ekle";
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // txtFirmaAdres
            // 
            this.txtFirmaAdres.Location = new System.Drawing.Point(135, 256);
            this.txtFirmaAdres.Multiline = true;
            this.txtFirmaAdres.Name = "txtFirmaAdres";
            this.txtFirmaAdres.Size = new System.Drawing.Size(193, 60);
            this.txtFirmaAdres.TabIndex = 20;
            this.txtFirmaAdres.TextChanged += new System.EventHandler(this.txtFirmaAdres_TextChanged);
            // 
            // txtFirmaWeb
            // 
            this.txtFirmaWeb.Location = new System.Drawing.Point(135, 219);
            this.txtFirmaWeb.Name = "txtFirmaWeb";
            this.txtFirmaWeb.Size = new System.Drawing.Size(193, 23);
            this.txtFirmaWeb.TabIndex = 19;
            // 
            // txtFirmaEmail
            // 
            this.txtFirmaEmail.Location = new System.Drawing.Point(133, 182);
            this.txtFirmaEmail.Name = "txtFirmaEmail";
            this.txtFirmaEmail.Size = new System.Drawing.Size(193, 23);
            this.txtFirmaEmail.TabIndex = 18;
            // 
            // pcbFirmaFoto
            // 
            this.pcbFirmaFoto.Image = ((System.Drawing.Image)(resources.GetObject("pcbFirmaFoto.Image")));
            this.pcbFirmaFoto.Location = new System.Drawing.Point(332, 68);
            this.pcbFirmaFoto.Name = "pcbFirmaFoto";
            this.pcbFirmaFoto.Size = new System.Drawing.Size(205, 136);
            this.pcbFirmaFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFirmaFoto.TabIndex = 16;
            this.pcbFirmaFoto.TabStop = false;
            this.pcbFirmaFoto.Click += new System.EventHandler(this.pcbFirmaFoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Firma Fax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Firma Adresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Firma Web Adresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Firma Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Firma Telefonu:";
            // 
            // txtFirmaYetkili
            // 
            this.txtFirmaYetkili.Location = new System.Drawing.Point(133, 68);
            this.txtFirmaYetkili.Name = "txtFirmaYetkili";
            this.txtFirmaYetkili.Size = new System.Drawing.Size(193, 23);
            this.txtFirmaYetkili.TabIndex = 5;
            this.txtFirmaYetkili.TextChanged += new System.EventHandler(this.txtFirmaYetkili_TextChanged);
            // 
            // firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 385);
            this.Controls.Add(this.btnFirmaGoruntule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "firmalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmalar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFirmaFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirmaGoruntule;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.RadioButton rdbforNumber;
        private System.Windows.Forms.RadioButton rdbforName;
        private System.Windows.Forms.DataGridView dgvFirmalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirmaYetkili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcbFirmaFoto;
        private System.Windows.Forms.TextBox txtFirmaAdres;
        private System.Windows.Forms.TextBox txtFirmaWeb;
        private System.Windows.Forms.TextBox txtFirmaEmail;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtFirmaFax;
        private System.Windows.Forms.MaskedTextBox txtFirmaTel;
    }
}