using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;
using System.IO;

namespace Depo_Otomasyon
{
    public partial class personelguncelle : Form
    {
        public personelguncelle()
        {
            InitializeComponent();
        }
        public string perNo = string.Empty;
        private void personelguncelle_Load(object sender, EventArgs e)
        {
            comboDoldur();
            try
            {
                string per = "Select Personel_No, Personel_Kimlik_No, Personel_Adi, Personel_Soyadi, Personel_Maas, Personel_Email, Personel_Tel, Personel_Egitim_Durumu, Personel_Adres, Personel_Fotograf from Personeller where Personel_No=@perNo";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@perNo", System.Data.OleDb.OleDbType.VarChar).Value = perNo;
                DataRow perBilgi = OrtakClass.Yardim.GetDataRow(per);
                if (per != null)
                {
                    txtPerAd.Text = perBilgi["Personel_Adi"].ToString();
                    txtPerAdres.Text = perBilgi["Personel_Adres"].ToString();
                    txtPerEgitim.Text = perBilgi["Personel_Egitim_Durumu"].ToString();
                    txtPerEmail.Text = perBilgi["Personel_Email"].ToString();
                    txtPerKimlikNo.Text = perBilgi["Personel_Kimlik_No"].ToString();
                    txtPerMaas.Text = perBilgi["Personel_Maas"].ToString();
                    txtPerNo.Text = perBilgi["Personel_No"].ToString();
                    txtPerSoyad.Text = perBilgi["Personel_Soyadi"].ToString();
                    txtPerTel.Text = perBilgi["Personel_Tel"].ToString();
                    byte[] imageByte = (byte[])perBilgi["Personel_Fotograf"];
                    MemoryStream strm = new MemoryStream(imageByte);
                    Image img = Image.FromStream(strm);
                    pcbPerResim.Image = img;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboDoldur()
        {
            string sqlMevkiGetir = "Select Mevki_Adi from Calisma_Mevkileri";
            DataTable tblMevkiler = OrtakClass.Yardim.GetDataTable(sqlMevkiGetir);
            cmbPerMevki.DisplayMember = "Mevki_Adi";
            cmbPerMevki.DataSource = tblMevkiler;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                        txt.Enabled = true;
                        dateTimePicker1.Enabled = true;
                        cmbPerCinsiyet.Enabled = true;
                        cmbPerMevki.Enabled = true;
                        pcbPerResim.Enabled = true;
                        txtPerNo.Enabled = false; 
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbPerResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog perFoto = new OpenFileDialog();
            if (perFoto.ShowDialog() == DialogResult.OK)
            {
                string adres = perFoto.FileName;
                pcbPerResim.ImageLocation = adres;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && cmbPerCinsiyet.Text != string.Empty && cmbPerMevki.Text != string.Empty && dateTimePicker1.Text != string.Empty)
                    {
                        try
                        {
                            string perGuncelle = "update Personeller set Personel_Kimlik_No=@perKimlik, Personel_Adi=@perAdi, Personel_Soyadi=@perSoyad, Personel_Email=@perEmail, Personel_Tel=@perTel, Personel_Adres=@perAdres, Personel_Mevki= @perMevki, Personel_Cinsiyet=@perCinsiyet, Personel_Maas=@perMaas, Personel_Dogum_Tarihi=@perDogumTarihi, Personel_Egitim_Durumu=@perEgitim where Personel_No=@perNo";
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@perKimlik", System.Data.OleDb.OleDbType.VarChar).Value = txtPerKimlikNo.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@perAdi", System.Data.OleDb.OleDbType.VarChar).Value = txtPerAd.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perSoyad", System.Data.OleDb.OleDbType.VarChar).Value = txtPerSoyad.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perEmail", System.Data.OleDb.OleDbType.VarChar).Value = txtPerEmail.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perTel", System.Data.OleDb.OleDbType.VarChar).Value = txtPerTel.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perAdres", System.Data.OleDb.OleDbType.VarChar).Value = txtPerAdres.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perMevki", System.Data.OleDb.OleDbType.VarChar).Value = cmbPerMevki.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perCinsiyet", System.Data.OleDb.OleDbType.VarChar).Value = cmbPerCinsiyet.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perMaas", System.Data.OleDb.OleDbType.Double).Value = txtPerMaas.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perDogumTarihi", System.Data.OleDb.OleDbType.Date).Value = dateTimePicker1.Value.Date; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perEgitim", System.Data.OleDb.OleDbType.VarChar).Value = txtPerEgitim.Text; 
                            OrtakClass.Yardim.Komut.Parameters.Add("@perNo", System.Data.OleDb.OleDbType.VarChar).Value = perNo;
                            //*****
                            Bitmap newImage = new Bitmap(pcbPerResim.Image, new Size(250, 250));
                            MemoryStream strm = new MemoryStream();
                            pcbPerResim.Image.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] image = strm.ToArray();
                            //*****
                            OrtakClass.Yardim.Komut.Parameters.Add("@perFoto", System.Data.OleDb.OleDbType.Binary).Value = image;
                            OrtakClass.Yardim.Komutisle(perGuncelle);
                            MessageBox.Show("Personel Güncelleme İşlemi Tamamlandı", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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

        }
    }

