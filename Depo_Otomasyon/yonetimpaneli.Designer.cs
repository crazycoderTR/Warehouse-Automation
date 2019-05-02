namespace Depo_Otomasyon
{
    partial class yonetimpaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetimpaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciDuzenle = new System.Windows.Forms.Button();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.btnGeriBildirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKullaniciDuzenle);
            this.groupBox1.Controls.Add(this.btnKullanıcıEkle);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcılar";
            // 
            // btnKullaniciDuzenle
            // 
            this.btnKullaniciDuzenle.Location = new System.Drawing.Point(111, 36);
            this.btnKullaniciDuzenle.Name = "btnKullaniciDuzenle";
            this.btnKullaniciDuzenle.Size = new System.Drawing.Size(88, 48);
            this.btnKullaniciDuzenle.TabIndex = 1;
            this.btnKullaniciDuzenle.Text = "Kullanıcı Hesabı Düzenle";
            this.btnKullaniciDuzenle.UseVisualStyleBackColor = true;
            this.btnKullaniciDuzenle.Click += new System.EventHandler(this.btnKullaniciDuzenle_Click);
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.Location = new System.Drawing.Point(17, 36);
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.Size = new System.Drawing.Size(88, 48);
            this.btnKullanıcıEkle.TabIndex = 0;
            this.btnKullanıcıEkle.Text = "Yeni Kullanıcı Tanıt";
            this.btnKullanıcıEkle.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // btnGeriBildirm
            // 
            this.btnGeriBildirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriBildirm.Location = new System.Drawing.Point(12, 112);
            this.btnGeriBildirm.Name = "btnGeriBildirm";
            this.btnGeriBildirm.Size = new System.Drawing.Size(212, 50);
            this.btnGeriBildirm.TabIndex = 1;
            this.btnGeriBildirm.Text = "Geri Bildirim";
            this.btnGeriBildirm.UseVisualStyleBackColor = true;
            this.btnGeriBildirm.Click += new System.EventHandler(this.btnGeriBildirm_Click);
            // 
            // yonetimpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 171);
            this.Controls.Add(this.btnGeriBildirm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "yonetimpaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.Button btnKullaniciDuzenle;
        private System.Windows.Forms.Button btnGeriBildirm;
    }
}