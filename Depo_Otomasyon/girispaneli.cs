using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;

namespace Depo_Otomasyon
{
    public partial class girispaneli : Form
    {
        public girispaneli()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            Baglan();
        }
        private void Baglan()
        {
            try
            {
                 Yardimci yardim = new Yardimci();
                 string yol = Application.StartupPath + "\\Depo_Otomasyon.accdb";
                 string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + yol + ";Jet OLEDB:Database Password=softwareforworld;Persist Security Info=False;";
                 yardim.Baglan(connStr);
                 OrtakClass.Yardim = yardim;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Giris();
            }
        }

        private void Giris()
        {
            string girisSql = "Select KullaniciAdi,KullaniciSifre,KullaniciTur from Kullanıcılar where KullaniciAdi=@kullaniciAdi and KullaniciSifre=@kullaniciSifre";
            //**
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@kullaniciAdi", System.Data.OleDb.OleDbType.VarChar).Value = txtKullaniciAd.Text;
            OrtakClass.Yardim.Komut.Parameters.Add("@kullaniciSifre", System.Data.OleDb.OleDbType.VarChar).Value = txtSifre.Text;
            //**
            DataRow kullanici = OrtakClass.Yardim.GetDataRow(girisSql);
            if (kullanici != null)
            {
                anaform frmAna = new anaform();
                frmAna.kullaniciTur = Convert.ToInt32(kullanici["KullaniciTur"].ToString());
                frmAna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DemoKontrol();
        }

        private void Gir()
        {
            anaform frmAna = new anaform();
            frmAna.deger = 1;
            frmAna.Show();
            this.Hide();
        }

        private void DemoKontrol()
        {
            string demoKon = "select DemoNo, DemoTarih from Demo";
            DataRow demo = OrtakClass.Yardim.GetDataRow(demoKon);
            if (demo != null)
            {
                if (demo["DemoNo"].ToString() == "0")
                {
                    string demoBaslat = "update Demo set DemoTarih=@yeniTarih, DemoNo=@no";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@yeniTarih", System.Data.OleDb.OleDbType.Date).Value = DateTime.Today.Date;
                    OrtakClass.Yardim.Komut.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar).Value = "1";
                    OrtakClass.Yardim.Komutisle(demoBaslat);
                }
                else
                {
                    DateTime ilkTarih = Convert.ToDateTime(demo["DemoTarih"].ToString());
                    DateTime today = DateTime.Today.Date;
                    TimeSpan tarih = (ilkTarih - today);
                    if (Math.Abs(tarih.Days) >= 30)
                    {
                        MessageBox.Show("Demo Sürümünüz Dolmuştur Artık Tam Sürüme Geçmelisiniz","Demo Durdur");
                    }
                    else if (Math.Abs(tarih.Days) < 30)
                    { 
                        MessageBox.Show("Kalan Demo Gün Hakkınız: " + (30 - Math.Abs(tarih.Days)),"Demo Hak");
                        Gir();
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sifremiunuttum frmSifremiUnuttum = new sifremiunuttum();
            frmSifremiUnuttum.Show();
        }
        int resimKontrol = 0;
        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (resimKontrol == 0)
            {
                btnPassword.Image = Image.FromFile(Application.StartupPath + @"\Resimler\sifre-goster.png");
                txtSifre.PasswordChar = '\0';
                resimKontrol = 1;
            }
            else
            {
                btnPassword.Image = Image.FromFile(Application.StartupPath + @"\Resimler\sifre-gizle.png");
                txtSifre.PasswordChar = '*';
                resimKontrol = 0;
            }
        }
    }
}
