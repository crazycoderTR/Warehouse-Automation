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

namespace Depo_Otomasyon
{
    public partial class stokbilgileri : Form
    {
        public stokbilgileri()
        {
            InitializeComponent();
        }

        private void stokbilgileri_Load(object sender, EventArgs e)
        {
            dgvDoldur();
            dgvHeader();
            dgvStoklar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvHeader()
        {
            dgvStoklar.Columns["Stok_Barkod"].HeaderText = "Stok Barkodu";
            dgvStoklar.Columns["Stok_Adi"].HeaderText = "Stok Adı";
            dgvStoklar.Columns["Stok_Cinsi"].HeaderText = "Stok Cinsi";
            dgvStoklar.Columns["Stok_Aciklama"].HeaderText = "Stok Açıklaması";
            dgvStoklar.Columns["Firma_Adi"].HeaderText = "Stok Firma Adı";
            dgvStoklar.Columns["Personel_Adi"].HeaderText = "Yetkili Personel Adı";
            dgvStoklar.Columns["Personel_Soyadi"].HeaderText = "Yetkili Personel Soyadı";
            dgvStoklar.Columns["Toplam_Mevcut_Miktar"].HeaderText = "Toplam Stok Miktarı";
            dgvStoklar.Columns["Olcu_Adi"].HeaderText = "Stok Ölçü Birimi";
            dgvStoklar.Columns["Stok_Tarihi"].HeaderText = "Stok Tanımlanma Tarihi";
        }

        private void dgvDoldur()
        {
            string stoklarSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Stoklar.Stok_Aciklama, Firmalar.Firma_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Stoklar.Toplam_Mevcut_Miktar, Olculer.Olcu_Adi, Stoklar.Stok_Tarihi FROM ((Stoklar INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No) INNER JOIN Personeller ON Stoklar.Stok_Yetkili_Personel = Personeller.Personel_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No";
            DataTable tblStoklar = OrtakClass.Yardim.GetDataTable(stoklarSql);
            dgvStoklar.DataSource = tblStoklar;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Stok İsmi;";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Stok Barkodu;";
        }

        private void txtStokBilgi_TextChanged(object sender, EventArgs e)
        {
            txtStokBilgi.Text = txtStokBilgi.Text.ToUpper();
            txtStokBilgi.SelectionStart = txtStokBilgi.Text.Length;

            if (txtStokBilgi.Text != string.Empty)
            {
                if (rd1.Checked)
                {
                    string stoklarSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Stoklar.Stok_Aciklama, Firmalar.Firma_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Stoklar.Toplam_Mevcut_Miktar, Olculer.Olcu_Adi, Stoklar.Stok_Tarihi FROM ((Stoklar INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No) INNER JOIN Personeller ON Stoklar.Stok_Yetkili_Personel = Personeller.Personel_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No where Stoklar.Stok_Adi like @stokAdi";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokAdi", OleDbType.VarChar).Value = txtStokBilgi.Text + "%";
                    DataTable tblStoklar = OrtakClass.Yardim.GetDataTable(stoklarSql);
                    dgvStoklar.DataSource = tblStoklar;
                }
                else if (rd2.Checked)
                {
                    string stoklarSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Stoklar.Stok_Aciklama, Firmalar.Firma_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Stoklar.Toplam_Mevcut_Miktar, Olculer.Olcu_Adi, Stoklar.Stok_Tarihi FROM ((Stoklar INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No) INNER JOIN Personeller ON Stoklar.Stok_Yetkili_Personel = Personeller.Personel_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No where Stoklar.Stok_Barkod like stokBarkod";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBilgi.Text + "%";
                    DataTable tblStoklar = OrtakClass.Yardim.GetDataTable(stoklarSql);
                    dgvStoklar.DataSource = tblStoklar;
                }
                else if (rd3.Checked)
                {
                    string stoklarSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Stoklar.Stok_Aciklama, Firmalar.Firma_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Stoklar.Toplam_Mevcut_Miktar, Olculer.Olcu_Adi, Stoklar.Stok_Tarihi FROM ((Stoklar INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No) INNER JOIN Personeller ON Stoklar.Stok_Yetkili_Personel = Personeller.Personel_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No where Firmalar.Firma_Adi like @firmaAdi";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@firmaAdi", OleDbType.VarChar).Value = txtStokBilgi.Text + "%";
                    DataTable tblStoklar = OrtakClass.Yardim.GetDataTable(stoklarSql);
                    dgvStoklar.DataSource = tblStoklar;
                }
                else if (rd4.Checked)
                {
                    string stoklarSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Stoklar.Stok_Aciklama, Firmalar.Firma_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Stoklar.Toplam_Mevcut_Miktar, Olculer.Olcu_Adi, Stoklar.Stok_Tarihi FROM ((Stoklar INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No) INNER JOIN Personeller ON Stoklar.Stok_Yetkili_Personel = Personeller.Personel_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No where Depolar.Depo_Adi like @depoAdi";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@depoAdi", OleDbType.VarChar).Value = txtStokBilgi.Text + "%";
                    DataTable tblStoklar = OrtakClass.Yardim.GetDataTable(stoklarSql);
                    dgvStoklar.DataSource = tblStoklar;
                }
            }
            else
            {
                dgvDoldur();
            }
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Firma Adı;";
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Depo Adı;";
        }

        private void dgvStoklar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dgvStoklar, new System.Drawing.Point(e.X, e.Y));
                int satir = dgvStoklar.HitTest(e.X, e.Y).RowIndex;
                if (satir == 1)
                {
                    dgvStoklar.Rows[satir].Selected = true;
                }
            }
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokdetay frmStokDetay = new stokdetay();
            frmStokDetay.stokAdi = dgvStoklar.CurrentRow.Cells["Stok_Adi"].Value.ToString();
            frmStokDetay.stokBarkod = dgvStoklar.CurrentRow.Cells["Stok_Barkod"].Value.ToString();
            frmStokDetay.stokKayitTarihi = dgvStoklar.CurrentRow.Cells["Stok_Tarihi"].Value.ToString();
            frmStokDetay.perAdi = dgvStoklar.CurrentRow.Cells["Personel_Adi"].Value.ToString();
            frmStokDetay.perSoyadi = dgvStoklar.CurrentRow.Cells["Personel_Soyadi"].Value.ToString();
            frmStokDetay.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokGuncelle stokguncelle = new stokGuncelle();
            stokguncelle.stokAdi = dgvStoklar.CurrentRow.Cells["Stok_Adi"].Value.ToString();
            stokguncelle.stokCinsi = dgvStoklar.CurrentRow.Cells["Stok_Cinsi"].Value.ToString();
            stokguncelle.stokBarkod = dgvStoklar.CurrentRow.Cells["Stok_Barkod"].Value.ToString();
            stokguncelle.stokAciklama = dgvStoklar.CurrentRow.Cells["Stok_Aciklama"].Value.ToString();
            stokguncelle.ShowDialog();
            dgvDoldur();
        }
    }
}
