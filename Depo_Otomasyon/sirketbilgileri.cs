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
    public partial class sirketbilgileri : Form
    {
        public sirketbilgileri()
        {
            InitializeComponent();
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            string alanKontrolSql = "Select Sirket_Adi from Sirket_BilgileriF";
            DataRow alan = OrtakClass.Yardim.GetDataRow(alanKontrolSql);

            if (alan == null)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        if (txt.Text != string.Empty)
                        {
                            try
                            {
                                string sirketBilgileriEkle = "insert into Sirket_Bilgileri(Sirket_Adi,Sirket_Yetkili,Sirket_Telefonu,Sirket_Fax,Sirket_Email,Sirket_Web_Adres,Sirket_Adresi,Sirket_Foto)values (@ad,@yetkili,@tel,@fax,@email,@webAdres,@adres,@foto)";
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@ad", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaAd.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@yetkili", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaYetkili.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@tel", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaTel.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@fax", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaFax.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@email", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaEmail.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@webAdres", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaWeb.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@adres", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaAdres.Text;
                            //*****
                            Bitmap newImage = new Bitmap(pcbFirmaFoto.Image, new Size(250, 250));
                            System.IO.MemoryStream strm = new System.IO.MemoryStream();
                            pcbFirmaFoto.Image.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] image = strm.ToArray();
                            //*****
                            OrtakClass.Yardim.Komut.Parameters.Add("@foto", System.Data.OleDb.OleDbType.Binary).Value = image;
                            OrtakClass.Yardim.Komutisle(sirketBilgileriEkle);
                            MessageBox.Show("Şirket Bilgileri Kaydedildi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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
            else
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = (TextBox)item;
                        if (txt.Text != string.Empty)
                        {
                            try
                            {
                                string sirketBilgileriGuncelle = "update Sirket_Bilgileri set Sirket_Adi=@ad, Sirket_Yetkili=@yetkili, Sirket_Telefonu=@tel, Sirket_Fax=@fax, Sirket_Email=@email, Sirket_Web_Adres=@webAdres, Sirket_Adresi=@adres, Sirket_Foto=@foto";
                                OrtakClass.Yardim.Komut.Parameters.Clear();
                                OrtakClass.Yardim.Komut.Parameters.Add("@ad", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaAd.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@yetkili", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaYetkili.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@tel", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaTel.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@fax", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaFax.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@email", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaEmail.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@webAdres", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaWeb.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@adres", System.Data.OleDb.OleDbType.VarChar).Value = txtFirmaAdres.Text;
                                //***********
                                Bitmap newImage = new Bitmap(pcbFirmaFoto.Image, new Size(250, 250));
                                System.IO.MemoryStream strm = new System.IO.MemoryStream();
                                pcbFirmaFoto.Image.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] image = strm.ToArray();
                                //***********
                                OrtakClass.Yardim.Komut.Parameters.Add("@foto", System.Data.OleDb.OleDbType.Binary).Value = image;
                                OrtakClass.Yardim.Komutisle(sirketBilgileriGuncelle);
                                MessageBox.Show("Şirket Bilgileri Güncellendi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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

        private void pcbFirmaFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog firmaResim = new OpenFileDialog();
            if (firmaResim.ShowDialog() == DialogResult.OK)
            {
                string adres = firmaResim.FileName;
                pcbFirmaFoto.ImageLocation = adres;
            }
        }

        private void sirketbilgileri_Load(object sender, EventArgs e)
        {
            string bilgiGetir = "Select Sirket_Adi, Sirket_Yetkili, Sirket_Telefonu, Sirket_Fax, Sirket_Email, Sirket_Web_Adres, Sirket_Adresi, Sirket_Foto from Sirket_Bilgileri";
            DataRow sirket = OrtakClass.Yardim.GetDataRow(bilgiGetir);
            if (sirket != null)
            {
                txtFirmaAd.Text = sirket["Sirket_Adi"].ToString();
                txtFirmaAdres.Text = sirket["Sirket_Adresi"].ToString();
                txtFirmaEmail.Text = sirket["Sirket_Email"].ToString();
                txtFirmaFax.Text = sirket["Sirket_Fax"].ToString();
                txtFirmaTel.Text = sirket["Sirket_Telefonu"].ToString();
                txtFirmaWeb.Text = sirket["Sirket_Web_Adres"].ToString();
                txtFirmaYetkili.Text = sirket["Sirket_Yetkili"].ToString();
                //***********
                byte[] imageByte = (byte[])sirket["Sirket_Foto"];
                System.IO.MemoryStream strm = new System.IO.MemoryStream(imageByte);
                Image img = Image.FromStream(strm);
                pcbFirmaFoto.Image = img;
            }
        }
    }
}
