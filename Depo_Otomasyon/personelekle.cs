using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;
using System.Data.OleDb;
using System.IO;

namespace Depo_Otomasyon
{
    public partial class personelekle : Form
    {
        public personelekle()
        {
            InitializeComponent();
        }

        private void pcbPerResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog perResim = new OpenFileDialog();
            if (perResim.ShowDialog() == DialogResult.OK)
            {
                string adres = perResim.FileName;
                pcbPerResim.ImageLocation = adres;
            }
        }

        private void txtPerAd_TextChanged(object sender, EventArgs e)
        {
            txtPerAd.Text = txtPerAd.Text.ToUpper();
            txtPerAd.SelectionStart = txtPerAd.Text.Length;
        }

        private void txtPerSoyad_TextChanged(object sender, EventArgs e)
        {
            txtPerSoyad.Text = txtPerSoyad.Text.ToUpper();
            txtPerSoyad.SelectionStart = txtPerSoyad.Text.Length;
        }

        private void txtPerAdres_TextChanged(object sender, EventArgs e)
        {
            txtPerAdres.Text = txtPerAdres.Text.ToUpper();
            txtPerAdres.SelectionStart = txtPerAdres.Text.Length;
        }

        private void txtPerEgitim_TextChanged(object sender, EventArgs e)
        {
            txtPerEgitim.Text = txtPerEgitim.Text.ToUpper();
            txtPerEgitim.SelectionStart = txtPerEgitim.Text.Length;
        }

        private void pcbPerResim_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog perFoto = new OpenFileDialog();
            if (perFoto.ShowDialog() == DialogResult.OK)
            {
                string adres = perFoto.FileName;
                pcbPerResim.ImageLocation = adres;
            }
        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && cmbPerCinsiyet.Text != string.Empty && cmbPerMevki.Text != string.Empty && dateTimePicker1.Text != string.Empty)
                    {
                        try
                        {
                            string perEkleSql = "insert into Personeller(Personel_No,Personel_Kimlik_No,Personel_Adi,Personel_Soyadi,Personel_Email,Personel_Tel,Personel_Adres,Personel_Mevki,Personel_Cinsiyet,Personel_Maas,Personel_Kayit_Tarihi,Personel_Dogum_Tarihi,Personel_Egitim_Durumu,Personel_Fotograf) Values(@perNo,@perKimlikNo,@perAdi,@perSoyadi,@perEmail,@perTel,@perAdres,@perMevki,@perCinsiyet,@perMaas,@perKayitTarihi,@perDogumTarihi,@perEgitimDurumu,@perFoto)";
                            //***
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@perNo", OleDbType.VarChar).Value = txtPerNo.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perKimlikNo", OleDbType.VarChar).Value = txtPerKimlikNo.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perAdi", OleDbType.VarChar).Value = txtPerAd.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perSoyadi", OleDbType.VarChar).Value = txtPerSoyad.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perEmail", OleDbType.VarChar).Value = txtPerEmail.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perTel", OleDbType.VarChar).Value = txtTel.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perAdres", OleDbType.VarChar).Value = txtPerAdres.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perMevki", OleDbType.VarChar).Value = cmbPerMevki.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perCinsiyet", OleDbType.VarChar).Value = cmbPerCinsiyet.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perMaas", OleDbType.Double).Value = txtPerMaas.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perKayitTarihi", OleDbType.Date).Value = DateTime.Today.Date;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perDogumTarihi", OleDbType.VarChar).Value = dateTimePicker1.Value.Date.ToString();
                            OrtakClass.Yardim.Komut.Parameters.Add("@perEgitimDurumu", OleDbType.VarChar).Value = txtPerEgitim.Text;
                            //*****
                            Bitmap newImage = new Bitmap(pcbPerResim.Image, new Size(250, 250));
                            MemoryStream strm = new MemoryStream();
                            pcbPerResim.Image.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] image = strm.ToArray();
                            //*****
                            OrtakClass.Yardim.Komut.Parameters.Add("@perFoto", OleDbType.Binary).Value = image;
                            OrtakClass.Yardim.Komutisle(perEkleSql);
                            MessageBox.Show("Personel Kaydedildi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik Bilgi Olmayacak Şekilde Devam Ediniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }
                }
            }
        }

        private void personelekle_Load(object sender, EventArgs e)
        {
            comboDoldur();
        }

        private void comboDoldur()
        {
            string sqlMevkiGetir = "Select Mevki_Adi from Calisma_Mevkileri";
            DataTable tblMevkiler = OrtakClass.Yardim.GetDataTable(sqlMevkiGetir);
            cmbPerMevki.DisplayMember = "Mevki_Adi";
            cmbPerMevki.DataSource = tblMevkiler;
        }
    }
}
