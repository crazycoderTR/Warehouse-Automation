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
    public partial class stoktanimla : Form
    {
        public stoktanimla()
        {
            InitializeComponent();
        }

        private void pcbStokResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog stokFoto = new OpenFileDialog();
            if (stokFoto.ShowDialog() == DialogResult.OK)
            {
                string adres = stokFoto.FileName;
                pcbStokResim.ImageLocation = adres;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStokTanimla_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && cmbFirma.Text != string.Empty && cmbOlcuBirimi.Text != string.Empty && cmbPersonel.Text != string.Empty && pcbStokBarkod.Image != null && pcbStokResim.Image != null)
                    {
                        try
                        {
                            string stokEkleSql = "insert into Stoklar (Stok_Barkod,Stok_Adi,Stok_Cinsi,Stok_Uretici_Firma,Stok_Yetkili_Personel,Stok_Olcu_Birimi,Stok_Aciklama,Toplam_Mevcut_Miktar,Stok_Tarihi,Stok_Foto, Stok_Barkod_Foto) values (@stokBarkod,@stokAdi,@stokCinsi,@stokUreticiFirma,@stokYetkilisi,@stokOlcuBirimi,@stokAciklama,@stokMevcutMiktar,@stokTarihi,@stokFoto,@stokBarkodFoto)";
                            //***
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokAdi", OleDbType.VarChar).Value = txtStokAdi.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokCinsi", OleDbType.VarChar).Value = txtStokCinsi.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokUreticiFirma", OleDbType.Single).Value = cmbFirma.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokYetkilisi", OleDbType.VarChar).Value = cmbPersonel.SelectedValue.ToString();
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokOlcuBirimi", OleDbType.Single).Value = cmbOlcuBirimi.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokAciklama", OleDbType.VarChar).Value = txtStokAciklama.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokMevcutMiktar", OleDbType.Single).Value = txtMiktar.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokTarihi", OleDbType.Date).Value = DateTime.Today.Date;
                            //***********************
                            Bitmap newImage1 = new Bitmap(pcbStokResim.Image, new Size(250, 250));
                            MemoryStream strm1 = new MemoryStream();
                            pcbStokResim.Image.Save(strm1, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] image1 = strm1.ToArray();
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokFoto", OleDbType.Binary).Value = image1;
                            //***********************
                            Bitmap newImage = new Bitmap(pcbStokBarkod.Image, new Size(250, 250));
                            MemoryStream strm = new MemoryStream();
                            pcbStokBarkod.Image.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] image = strm.ToArray();
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkodFoto", OleDbType.Binary).Value = image;
                            //***********************
                            OrtakClass.Yardim.Komutisle(stokEkleSql);
                            miktar();
                            MessageBox.Show("Stok Eklendi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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

        private void miktar()
        {
            string miktarSql = "insert into Stok_Mevcut_Miktarlar(Stok_Barkod,Stok_Mevcut_Miktari,Bulundugu_Depo) values(@barkod,@miktar,@depo)"; 
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
            OrtakClass.Yardim.Komut.Parameters.Add("@miktar", OleDbType.Double).Value = txtMiktar.Text;
            OrtakClass.Yardim.Komut.Parameters.Add("@depo", OleDbType.Single).Value = cmbDepolar.SelectedValue;
            OrtakClass.Yardim.Komutisle(miktarSql);
        }
        
        private void txtStokBarkod_TextChanged(object sender, EventArgs e)
        {
            if (txtStokBarkod.Text != string.Empty)
            {
                string barkod = txtStokBarkod.Text;
                QRCodeEncoder encoder = new QRCodeEncoder();
                Bitmap qrcode = encoder.Encode(barkod);
                pcbStokBarkod.Image = qrcode as Image;
            }
            else
            {
                pcbStokBarkod.ImageLocation = Application.StartupPath + "\\Resimler" + "\\ünlem.png";
            }
        }

        private void StokTanımla_Load(object sender, EventArgs e)
        {
            try
            {
                 ComboDoldur();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboDoldur()
        {
            try
            {
                string firmaSql = "select Firma_No,Firma_Adi from Firmalar";
                DataTable tblFirmalar = OrtakClass.Yardim.GetDataTable(firmaSql);
                cmbFirma.DisplayMember = "Firma_Adi";
                cmbFirma.ValueMember = "Firma_No";
                cmbFirma.DataSource = tblFirmalar;
                //***
                string personelSql = "select Personel_No,(Personel_Adi + ' ' +  Personel_Soyadi) as perAdSoyad from Personeller";
                DataTable tblPersoneller = OrtakClass.Yardim.GetDataTable(personelSql);
                cmbPersonel.DisplayMember = "perAdSoyad";
                cmbPersonel.ValueMember = "Personel_No";
                cmbPersonel.DataSource = tblPersoneller;
                //***
                string olcuSql = "select Olcu_No,Olcu_Adi from Olculer";
                DataTable tblOlculer = OrtakClass.Yardim.GetDataTable(olcuSql);
                cmbOlcuBirimi.DisplayMember = "Olcu_Adi";
                cmbOlcuBirimi.ValueMember = "Olcu_No";
                cmbOlcuBirimi.DataSource = tblOlculer;
                //***
                string depoSql = "select Depo_No,Depo_Adi from Depolar";
                DataTable tblDepolar = OrtakClass.Yardim.GetDataTable(depoSql);
                cmbDepolar.DisplayMember = "Depo_Adi";
                cmbDepolar.ValueMember = "Depo_No";
                cmbDepolar.DataSource = tblDepolar;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            txtStokAdi.Text = txtStokAdi.Text.ToUpper();
            txtStokAdi.SelectionStart = txtStokAdi.Text.Length;
        }

        private void txtStokCinsi_TextChanged(object sender, EventArgs e)
        {
            txtStokCinsi.Text = txtStokCinsi.Text.ToUpper();
            txtStokCinsi.SelectionStart = txtStokCinsi.Text.Length;
        }

        private void txtStokAciklama_TextChanged(object sender, EventArgs e)
        {
            txtStokAciklama.Text = txtStokAciklama.Text.ToUpper();
            txtStokAciklama.SelectionStart = txtStokAciklama.Text.Length;
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

        private void btnOlcuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                olculer frmOlculer = new olculer();
                frmOlculer.ShowDialog();
                //***
                string olcuSql = "select Olcu_No,Olcu_Adi from Olculer";
                DataTable tblOlculer = OrtakClass.Yardim.GetDataTable(olcuSql);
                cmbOlcuBirimi.DisplayMember = "Olcu_Adi";
                cmbOlcuBirimi.ValueMember = "Olcu_No";
                cmbOlcuBirimi.DataSource = tblOlculer;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
