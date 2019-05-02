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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.IO;

namespace Depo_Otomasyon
{
    public partial class stokgirisi : Form
    {
        public stokgirisi()
        {
            InitializeComponent();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && dateTimePicker1.Text != string.Empty )
                    {
                        try
                        {
                            string stokEkleSql = "insert into Stok_Hareketler (Stok_Barkod,Hareket_Tipi,Hareket_Miktari,Stok_Birim_Fiyati,Stok_Maliyeti,Depo,İslem_Tarihi) values (@stokBarkod,@hareketTipi,@hareketMiktar,@stokBirimFiyat,@stokMaliyeti,@depo,@islemTarihi)";
               //**********************************************************************************************          
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@hareketTipi", OleDbType.VarChar).Value = "Girdi";
                            OrtakClass.Yardim.Komut.Parameters.Add("@hareketMiktar", OleDbType.Double).Value = txtGirenMiktar.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokBirimFiyat", OleDbType.Double).Value = txtBirimFiyat.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokMaliyeti", OleDbType.Double).Value = txtGirenMiktarMaliyeti.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@islemTarihi", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                            OrtakClass.Yardim.Komutisle(stokEkleSql);
                            mevcutMiktarGuncelle();
                            MessageBox.Show("Stok Girişi Gerçekleşti", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); fisKes(); break;
                            
                        }

                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik Bilgi Olmayacak Şekilde Devam Ediniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void fisKes()
        {
            stokhareketfisi frmHareketFisi = new stokhareketfisi();
            frmHareketFisi.stokBarkod = txtStokBarkod.Text;
            frmHareketFisi.stokIsmi = txtStokAdi.Text;
            frmHareketFisi.StokUretici = txtFirma.Text;
            frmHareketFisi.stokDepo = cmbDepolar.Text;
            frmHareketFisi.stokPersonel = txtYetkiliPersonel.Text;
            frmHareketFisi.stokHareketMiktar = txtGirenMiktar.Text;
            frmHareketFisi.stokBirimFiyat = txtBirimFiyat.Text;
            frmHareketFisi.stokMaliyeti = txtGirenMiktarMaliyeti.Text;
            frmHareketFisi.islemTarihi = dateTimePicker1.Text;
            frmHareketFisi.stokHareketTur = 1;
            frmHareketFisi.Show();
        }


        private void mevcutMiktarGuncelle()
        {
            double guncelMiktar = 0;
            string miktarSql = "SELECT SUM(Stok_Mevcut_Miktarlar.Stok_Mevcut_Miktari) as Stok_Mevcut_Miktari FROM Stok_Mevcut_Miktarlar WHERE Stok_Mevcut_Miktarlar.Stok_Barkod = stokBarkod AND Stok_Mevcut_Miktarlar.Bulundugu_Depo = @depo; ";
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
            OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
            DataRow miktar = OrtakClass.Yardim.GetDataRow(miktarSql);
            if (miktar != null)
            {
                double mevcutMiktar = 0;
                if (miktar["Stok_Mevcut_Miktari"].ToString() == string.Empty)
                {
                    string yeniMiktarSql = "insert into Stok_Mevcut_Miktarlar(Stok_Barkod,Stok_Mevcut_Miktari,Bulundugu_Depo) values(@barkod,@miktar,@depo)";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                    OrtakClass.Yardim.Komut.Parameters.Add("@miktar", OleDbType.Double).Value = txtGirenMiktar.Text;
                    OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
                    OrtakClass.Yardim.Komutisle(yeniMiktarSql);
                    toplamMiktarGuncelle();
                }
                else {
                    mevcutMiktar = Convert.ToDouble(miktar["Stok_Mevcut_Miktari"].ToString());
                    guncelMiktar = Convert.ToDouble(txtGirenMiktar.Text) + mevcutMiktar;
                    string miktarGuncelleSql = "update Stok_Mevcut_Miktarlar set Stok_Mevcut_Miktari=@stokGuncelMiktar where Stok_Barkod=@stokBarkod and Bulundugu_Depo=@depo";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokGuncelMiktar", OleDbType.Double).Value = guncelMiktar;
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                    OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
                    OrtakClass.Yardim.Komutisle(miktarGuncelleSql);
                    toplamMiktarGuncelle();
                }
                
            }
            else
            {
                string yeniMiktarSql = "insert into Stok_Mevcut_Miktarlar(Stok_Barkod,Stok_Mevcut_Miktari,Bulundugu_Depo) values(@barkod,@miktar,@depo)";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                OrtakClass.Yardim.Komut.Parameters.Add("@miktar", OleDbType.Double).Value = txtGirenMiktar.Text;
                OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
                OrtakClass.Yardim.Komutisle(yeniMiktarSql);
                toplamMiktarGuncelle();
            }
        }

        private void toplamMiktarGuncelle()
        {
            try
            {
                double guncelMiktar;
                string miktarAlSql = "select Toplam_Mevcut_Miktar from Stoklar where Stok_Barkod=@barkod";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                DataRow miktar = OrtakClass.Yardim.GetDataRow(miktarAlSql);
                if (miktar != null)
                {
                    double toplamMevcutMiktar = Convert.ToDouble(miktar["Toplam_Mevcut_Miktar"].ToString());
                    guncelMiktar = toplamMevcutMiktar + Convert.ToDouble(txtGirenMiktar.Text);
                    string miktarGuncelleSql = "UPDATE Stoklar set Toplam_Mevcut_Miktar=@stokGuncelMiktar where Stok_Barkod=@stokBarkod";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokGuncelMiktar", OleDbType.Double).Value = guncelMiktar;
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                    OrtakClass.Yardim.Komutisle(miktarGuncelleSql);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                stokBul();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stokBul()
        {
            string stokBulSql = "SELECT Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Firmalar.Firma_Adi, (Personeller.Personel_Adi + ' ' + Personeller.Personel_Soyadi) as perAdSoyad, Olculer.Olcu_Adi, Stoklar.Toplam_Mevcut_Miktar FROM((Personeller INNER JOIN Stoklar ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No WHERE Stoklar.Stok_Barkod = @stokBarkod";
            //*****
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
            DataRow stok = OrtakClass.Yardim.GetDataRow(stokBulSql);
            if (stok != null)
            {
                txtStokAdi.Text = stok["Stok_Adi"].ToString();
                txtStokCinsi.Text = stok["Stok_Cinsi"].ToString();
                txtFirma.Text = stok["Firma_Adi"].ToString();
                txtYetkiliPersonel.Text = stok["perAdSoyad"].ToString();
                txtOlcu.Text = stok["Olcu_Adi"].ToString();
                txtMevcutMiktar.Text = stok["Toplam_Mevcut_Miktar"].ToString();
                //Stok Barkod Foto ve Stok Foto
                stokBulSql = "SELECT Stoklar.Stok_Foto, Stoklar.Stok_Barkod_Foto from Stoklar where Stoklar.Stok_Barkod=@stokBarkod";
                //*****
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                DataRow stokFotolar = OrtakClass.Yardim.GetDataRow(stokBulSql);
                if (stokFotolar != null)
                {
                    byte[] imageByte = (byte[])stokFotolar["Stok_Barkod_Foto"];
                    MemoryStream strm = new MemoryStream(imageByte);
                    Image img = Image.FromStream(strm);
                    pcbStokBarkod.Image = img;
                    //***********************
                    byte[] imageByte1 = (byte[])stokFotolar["Stok_Foto"];
                    MemoryStream strm1 = new MemoryStream(imageByte1);
                    Image img1 = Image.FromStream(strm1);
                    pcbStokResim.Image = img1;
                }

                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Enabled = true;
                    }
                }
                pcbStokBarkod.Enabled = true;
            }
            else
            {
                MessageBox.Show("Hatalı Barkod", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txtGirenMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtGirenMiktar.Text == string.Empty)
            {
                string miktarGuncelleSql = "SELECT SUM(Stok_Mevcut_Miktari) as Stok_Mevcut_Miktari from Stok_Mevcut_Miktarlar where Stok_Barkod=@stokBarkod and Bulundugu_Depo=@depo";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
                DataRow miktar = OrtakClass.Yardim.GetDataRow(miktarGuncelleSql);
                if (miktar != null)
                {
                    txtMevcutMiktar.Text = miktar["Stok_Mevcut_Miktari"].ToString();
                }
                txtGirenMiktarMaliyeti.Text = string.Empty;
            }
            else
            {
                try
                {
                    if (txtBirimFiyat.Text != string.Empty)
                    {
                         double girenMiktar = Convert.ToDouble(txtGirenMiktar.Text);
                         double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                         double toplamMaliyet = birimFiyat * girenMiktar;
                         txtGirenMiktarMaliyeti.Text = toplamMaliyet.ToString();
                    }
                    else
                    {
                         txtGirenMiktarMaliyeti.Text = string.Empty;
                    }
                    
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBirimFiyat.Text != string.Empty )
                {
                    if (txtGirenMiktar.Text != string.Empty)
                    {
                        double girenMiktar = Convert.ToDouble(txtGirenMiktar.Text);
                        double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                        double toplamMaliyet = birimFiyat * girenMiktar;
                        txtGirenMiktarMaliyeti.Text = toplamMaliyet.ToString();
                    }
                    else
                    {
                        txtGirenMiktarMaliyeti.Text = string.Empty;
                    }
                }
                else
                {
                    txtGirenMiktarMaliyeti.Text = string.Empty;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StokGiris_Load(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
            txtStokBarkod.Enabled = true;
            depoComboDoldur();
        }

        private void depoComboDoldur()
        {
            string depoSql = "select Depo_No,Depo_Adi from Depolar";
            DataTable tblDepolar = OrtakClass.Yardim.GetDataTable(depoSql);
            cmbDepolar.DisplayMember = "Depo_Adi";
            cmbDepolar.ValueMember = "Depo_No";
            cmbDepolar.DataSource = tblDepolar;
        }

        private void txtGirenMiktar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double girenMiktar = Convert.ToDouble(txtGirenMiktar.Text);
                    double mevcutMiktar = Convert.ToDouble(txtMevcutMiktar.Text);
                    double toplamMiktar = 0;
                    if (txtGirenMiktar.Text != string.Empty)
                    {
                        if (txtMevcutMiktar.Text != string.Empty)
                        {
                            toplamMiktar = mevcutMiktar + girenMiktar;
                            txtMevcutMiktar.Text = toplamMiktar.ToString();
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtStokBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    stokBul();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbDepolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mevcutMiktar = "Select SUM(Stok_Mevcut_Miktari) as Stok_Mevcut_Miktari from Stok_Mevcut_Miktarlar where Stok_Barkod=@barkod and Bulundugu_Depo=@depo";
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
            OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
            DataRow miktar = OrtakClass.Yardim.GetDataRow(mevcutMiktar);
            if (miktar != null)
            {
                txtMevcutMiktar.Text = miktar["Stok_Mevcut_Miktari"].ToString();
            }
            else
            {
                txtMevcutMiktar.Text = "0";
            }
        }

        private void pcbStokBarkod_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.pcbStokBarkod.Width, this.pcbStokBarkod.Height);
            this.pcbStokBarkod.DrawToBitmap(bmp, new Rectangle(0, 0, this.pcbStokBarkod.Width, this.pcbStokBarkod.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

    }
}
