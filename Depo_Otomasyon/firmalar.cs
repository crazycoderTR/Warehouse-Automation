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
    public partial class firmalar : Form
    {
        public firmalar()
        {
            InitializeComponent();
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

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && pcbFirmaFoto.ImageLocation != null)
                    {
                        try
                        {
                            string firmaEkleSql = "insert into Firmalar(Firma_Adi,Firma_Yetkili,Firma_Tel,Firma_Fax,Firma_Email,Firma_Web_Adresi,Firma_Adresi,Firma_Fotoğraf,Firma_Anlasma_Tarihi) Values (@firmaAdi,@firmaYetkili,@firmaTel,@firmaFax,@firmaEmail,@firmaWeb,@firmaAdres,@firmaFoto,@firmaTarih)";
                            //****************************************
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaAdi", OleDbType.VarChar).Value = txtFirmaAd.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaYetkili", OleDbType.VarChar).Value = txtFirmaYetkili.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaTel", OleDbType.VarChar).Value = txtFirmaTel.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaFax", OleDbType.VarChar).Value = txtFirmaFax.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaEmail", OleDbType.VarChar).Value = txtFirmaEmail.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaWeb", OleDbType.VarChar).Value = txtFirmaWeb.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaAdres", OleDbType.VarChar).Value = txtFirmaAdres.Text;
                            //***********
                            Bitmap newImage = new Bitmap(pcbFirmaFoto.Image, new Size(250, 250));
                            MemoryStream strm = new MemoryStream();
                            pcbFirmaFoto.Image.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] image = strm.ToArray();
                            //***********
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaFoto", OleDbType.Binary).Value = image;
                            OrtakClass.Yardim.Komut.Parameters.Add("@firmaTarih", OleDbType.Date).Value = DateTime.Today.Date;
                            OrtakClass.Yardim.Komutisle(firmaEkleSql);
                            MessageBox.Show("Firma Kaydedildi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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

        private void btnFirmaGoruntule_Click(object sender, EventArgs e)
        {
            if (this.Height != 718)
            {
                this.Height = 718;
                btnFirmaGoruntule.Text = "Firmaları Kapat";
            }
            else if (this.Height == 718)
            {
                this.Height = 424;
                btnFirmaGoruntule.Text = "Firmaları Görüntüle";
            }
            dgvDoldur();
        }

        private void dgvDoldur()
        {
            try
            {
                string firmalarSql = "SELECT Firma_No, Firma_Adi, Firma_Yetkili, Firma_Tel, Firma_Fax, Firma_Email, Firma_Web_Adresi, Firma_Adresi, Firma_Anlasma_Tarihi FROM Firmalar";
                DataTable tblFirmalar = OrtakClass.Yardim.GetDataTable(firmalarSql);
                dgvFirmalar.DataSource = tblFirmalar;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvHeader();
        }

        private void dgvHeader()
        {
            dgvFirmalar.Columns["Firma_No"].HeaderText = "Firma No";
            dgvFirmalar.Columns["Firma_Adi"].HeaderText = "Firma Adı";
            dgvFirmalar.Columns["Firma_Yetkili"].HeaderText = "Firma Yetkilisi";
            dgvFirmalar.Columns["Firma_Tel"].HeaderText = "Firma Telefonu";
            dgvFirmalar.Columns["Firma_Fax"].HeaderText = "Firma Fax";
            dgvFirmalar.Columns["Firma_Email"].HeaderText = "Firma Email";
            dgvFirmalar.Columns["Firma_Web_Adresi"].HeaderText = "Firma Web Adresi";
            dgvFirmalar.Columns["Firma_Adresi"].HeaderText = "Firma Adresi";
            dgvFirmalar.Columns["Firma_Anlasma_Tarihi"].HeaderText = "Firma Anlaşma Tarihi";
        }

        private void txtFirmaAd_TextChanged(object sender, EventArgs e)
        {
            txtFirmaAd.Text = txtFirmaAd.Text.ToUpper();
            txtFirmaAd.SelectionStart = txtFirmaAd.Text.Length;
        }

        private void txtFirmaYetkili_TextChanged(object sender, EventArgs e)
        {
            txtFirmaYetkili.Text = txtFirmaYetkili.Text.ToUpper();
            txtFirmaYetkili.SelectionStart = txtFirmaYetkili.Text.Length;
        }

        private void txtFirmaAdres_TextChanged(object sender, EventArgs e)
        {
            txtFirmaAdres.Text = txtFirmaAdres.Text.ToUpper();
            txtFirmaAdres.SelectionStart = txtFirmaAdres.Text.Length;
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Firma Adı;";
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Firma Numarası;";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty)
            {
                try
                {
                    if (rdbforName.Checked)
                    {
                        string firmalarSql = "SELECT Firma_No, Firma_Adi, Firma_Yetkili, Firma_Tel, Firma_Fax, Firma_Email, Firma_Web_Adresi, Firma_Adresi, Firma_Anlasma_Tarihi FROM Firmalar where Firma_Adi like @firmaAdi";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@firmaAdi", OleDbType.VarChar).Value = txtAra.Text + "%";
                        //***
                        DataTable tblFirmalar = OrtakClass.Yardim.GetDataTable(firmalarSql);
                        dgvFirmalar.DataSource = tblFirmalar;
                    }
                    else if (rdbforNumber.Checked)
                    {
                        string firmalarSql = "SELECT Firma_No, Firma_Adi, Firma_Yetkili, Firma_Tel, Firma_Fax, Firma_Email, Firma_Web_Adresi, Firma_Adresi, Firma_Anlasma_Tarihi FROM Firmalar where Firma_No=@firmaNo";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@firmaNo", OleDbType.Single).Value = txtAra.Text;
                        //***
                        DataTable tblFirmalar = OrtakClass.Yardim.GetDataTable(firmalarSql);
                        dgvFirmalar.DataSource = tblFirmalar;
                    }
                    else
                    {
                        dgvDoldur();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvDoldur();
            }

        }

    }
}
