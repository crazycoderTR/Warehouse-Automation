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
    public partial class kullaniciduzenle : Form
    {
        public kullaniciduzenle()
        {
            InitializeComponent();
        }
        public int kullaniciNo = 0;
        private void kullaniciduzenle_Load(object sender, EventArgs e)
        {
            string veriAl = "Select KullaniciAdi,KullaniciSifre,KullaniciEposta from Kullanıcılar";
            DataRow kullanici = OrtakClass.Yardim.GetDataRow(veriAl);
            if (veriAl != null)
            {
                txtAd.Text = kullanici["KullaniciAdi"].ToString();
                txtEposta.Text = kullanici["KullaniciEposta"].ToString();
                txtSifre.Text = kullanici["KullaniciSifre"].ToString();
            }
        }

        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != string.Empty && txtEposta.Text != string.Empty && txtSifre.Text != string.Empty && txtSifreTekrar.Text != string.Empty)
            {
                try
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        string kullaniciDuzenle = "update Kullanıcılar set KullaniciAdi=@ad, KullaniciSifre=@sifre, KullaniciEposta=@eposta";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@ad", System.Data.OleDb.OleDbType.VarChar).Value = txtAd.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@sifre", System.Data.OleDb.OleDbType.VarChar).Value = txtSifre.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@eposta", System.Data.OleDb.OleDbType.VarChar).Value = txtEposta.Text;
                        OrtakClass.Yardim.Komutisle(kullaniciDuzenle);
                        MessageBox.Show("Kullanıcı Güncellendi", "Güncelleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Şifre Tekrar Alanı İle Şifreniz Aynı Değildir !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Olmayacak Şekilde Devam Ediniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
