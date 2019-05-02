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
    public partial class depoalarArasiVirman : Form
    {
        public depoalarArasiVirman()
        {
            InitializeComponent();
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

        private void depoalarArasiVirman_Load(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
            txtStokBarkod.Enabled = true;
            comboDoldur();
        }

        private void comboDoldur()
        {
            string depoSql = "select Depo_No,Depo_Adi from Depolar";
            DataTable tblGonderen = OrtakClass.Yardim.GetDataTable(depoSql);
            cmbGonderen.DisplayMember = "Depo_Adi";
            cmbGonderen.ValueMember = "Depo_No";
            cmbGonderen.DataSource = tblGonderen;
            //***
            DataTable tblAlici = OrtakClass.Yardim.GetDataTable(depoSql);
            cmbAlici.DisplayMember = "Depo_Adi";
            cmbAlici.ValueMember = "Depo_No";
            cmbAlici.DataSource = tblAlici;
            //***
            string personelSql = "select Personel_No,(Personel_Adi + ' ' +  Personel_Soyadi) as perAdSoyad from Personeller";
            DataTable tblPersoneller = OrtakClass.Yardim.GetDataTable(personelSql);
            cmbVirmanPersonel.DisplayMember = "perAdSoyad";
            cmbVirmanPersonel.ValueMember = "Personel_No";
            cmbVirmanPersonel.DataSource = tblPersoneller;
        }

        private void txtCikanMiktar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double cikanMiktar = Convert.ToDouble(txtCikanMiktar.Text);
                    double mevcutMiktar = Convert.ToDouble(txtMevcutMiktar.Text);
                    double toplamMiktar = 0;
                    if (txtCikanMiktar.Text != string.Empty)
                    {
                        if (txtMevcutMiktar.Text != string.Empty)
                        {
                            if (cikanMiktar > mevcutMiktar)
                            {
                                MessageBox.Show("Girdiğiniz Miktar Stokda Bulunandan Çok Fazla Lütfen Tutarlı Değerler Giriniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                toplamMiktar = mevcutMiktar - cikanMiktar;
                                txtMevcutMiktar.Text = toplamMiktar.ToString();
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVirman_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && dateTimePicker1.Text != string.Empty)
                    {
                        string virmanSQL = "INSERT INTO Depo_Virman (Stok_Barkod, GonderenDepo, AliciDepo, Tarih, Miktar, YetkiliPersonel) values (@stokBarkod, @gonderenDepo, @aliciDepo, @tarih, @miktar, @yetkiliPersonel)";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@gonderenDepo", OleDbType.Single).Value = cmbGonderen.SelectedValue;
                        OrtakClass.Yardim.Komut.Parameters.Add("@aliciDepo", OleDbType.Single).Value = cmbAlici.SelectedValue;
                        OrtakClass.Yardim.Komut.Parameters.Add("@tarih", OleDbType.Date).Value = DateTime.Now.Date;
                        OrtakClass.Yardim.Komut.Parameters.Add("@miktar", OleDbType.Single).Value = txtCikanMiktar.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@yetkiliPersonel", OleDbType.VarChar).Value = cmbVirmanPersonel.SelectedValue;
                        OrtakClass.Yardim.Komutisle(virmanSQL);
                        mevcutMiktarlariGuncelle();
                        MessageBox.Show("Virman İşlemi Gerçekleşti", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Eksik Bilgi Olmayacak Şekilde Devam Ediniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void mevcutMiktarlariGuncelle()
        {
            try
            {
                double guncelMiktar = 0;
                string miktarSql = "SELECT SUM(Stok_Mevcut_Miktari) as Stok_Mevcut_Miktari from Stok_Mevcut_Miktarlar where Stok_Barkod=@stokBarkod and Bulundugu_Depo=@depo";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbGonderen.SelectedValue;
                DataRow miktar = OrtakClass.Yardim.GetDataRow(miktarSql);
                if (miktar != null)
                {
                    double mevcutMiktar = Convert.ToDouble(miktar["Stok_Mevcut_Miktari"].ToString());
                    if (Convert.ToDouble(txtCikanMiktar.Text) > mevcutMiktar)
                    {
                        MessageBox.Show("Girdiğiniz Miktar Stokda Bulunandan Çok Fazla Lütfen Tutarlı Değerler Giriniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Gönderen Depo Verisini Güncelleme
                        guncelMiktar = mevcutMiktar - Convert.ToDouble(txtCikanMiktar.Text);
                        string miktarGuncelleSql = "update Stok_Mevcut_Miktarlar set Stok_Mevcut_Miktari=@stokGuncelMiktar where Stok_Barkod=@stokBarkod and Bulundugu_Depo=@depo";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@stokGuncelMiktar", OleDbType.Double).Value = guncelMiktar;
                        OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text; OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbGonderen.SelectedValue;
                        OrtakClass.Yardim.Komutisle(miktarGuncelleSql);
                        //Alıcı Depo Verisini Güncelleme
                        miktarSql = "SELECT SUM(Stok_Mevcut_Miktari) as Stok_Mevcut_Miktari from Stok_Mevcut_Miktarlar where Stok_Barkod=@stokBarkod and Bulundugu_Depo=@depo";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbAlici.SelectedValue;
                        DataRow alicimiktar = OrtakClass.Yardim.GetDataRow(miktarSql);
                        if (alicimiktar != null)
                        {
                            if (alicimiktar["Stok_Mevcut_Miktari"].ToString() == string.Empty)
                            {
                                string yeniMiktarSql = "insert into Stok_Mevcut_Miktarlar(Stok_Barkod,Stok_Mevcut_Miktari,Bulundugu_Depo) values(@barkod,@miktar,@depo)";
                                OrtakClass.Yardim.Komut.Parameters.Clear();
                                OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@miktar", OleDbType.Double).Value = txtCikanMiktar.Text;
                                OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbAlici.SelectedValue;
                                OrtakClass.Yardim.Komutisle(yeniMiktarSql);
                            }
                            else
                            {
                                mevcutMiktar = Convert.ToDouble(alicimiktar["Stok_Mevcut_Miktari"].ToString());
                                guncelMiktar = mevcutMiktar + Convert.ToDouble(txtCikanMiktar.Text);
                                miktarGuncelleSql = "update Stok_Mevcut_Miktarlar set Stok_Mevcut_Miktari=@stokGuncelMiktar where Stok_Barkod=@stokBarkod and Bulundugu_Depo=@depo";
                                OrtakClass.Yardim.Komut.Parameters.Clear();
                                OrtakClass.Yardim.Komut.Parameters.Add("@stokGuncelMiktar", OleDbType.Double).Value = guncelMiktar;
                                OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text; OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbAlici.SelectedValue;
                                OrtakClass.Yardim.Komutisle(miktarGuncelleSql);
                            }
                        }
                    }
                }
                else
                {
                    txtMevcutMiktar.Text = "0";
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGonderen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mevcutMiktar = "Select SUM(Stok_Mevcut_Miktari) as Stok_Mevcut_Miktari from Stok_Mevcut_Miktarlar where Stok_Barkod=@barkod and Bulundugu_Depo=@depo";
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
            OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbGonderen.SelectedValue;
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
    }
}
