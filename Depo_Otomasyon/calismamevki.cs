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
    public partial class calismamevki : Form
    {
        public calismamevki()
        {
            InitializeComponent();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Mevki İsmi;";
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Mevki Numarası;";
        }

        private void btnMevkiEkle_Click(object sender, EventArgs e)
        {
            if (txtMevkiAd.Text != string.Empty)
            {
                try
                {
                    string mevkiEkleSql = "insert into Calisma_Mevkileri (Mevki_Adi)values (@mevkiAdi)";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@mevkiAdi", OleDbType.VarChar).Value = txtMevkiAd.Text;
                    OrtakClass.Yardim.Komutisle(mevkiEkleSql);
                    MessageBox.Show("Mevki Kaydedildi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgvDoldur();
        }

        private void txtMevki_TextChanged(object sender, EventArgs e)
        {
            if (txtMevki.Text != string.Empty)
            {
                if (rd1.Checked)
                {
                    string mevkiBlgiSql = "SELECT Calisma_Mevkileri.Mevki_No, Calisma_Mevkileri.Mevki_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi FROM Calisma_Mevkileri INNER JOIN Personeller ON Calisma_Mevkileri.Mevki_Adi = Personeller.Personel_Mevki where Mevki_Adi like @mevkiAd";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@mevkiAd", OleDbType.VarChar).Value = txtMevki.Text + "%";
                    DataTable tblMevkiler = OrtakClass.Yardim.GetDataTable(mevkiBlgiSql);
                    dgvMevki.DataSource = tblMevkiler;
                }
                else if (rd2.Checked)
                {
                    string mevkiBlgiSql = "SELECT Calisma_Mevkileri.Mevki_No, Calisma_Mevkileri.Mevki_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi FROM Calisma_Mevkileri INNER JOIN Personeller ON Calisma_Mevkileri.Mevki_Adi = Personeller.Personel_Mevki where Mevki_No=@mevkiNo";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@mevkiNo", OleDbType.VarChar).Value = txtMevki.Text;
                    DataTable tblMevkiler = OrtakClass.Yardim.GetDataTable(mevkiBlgiSql);
                    dgvMevki.DataSource = tblMevkiler;
                }
            }
            else
            {
                dgvDoldur();
            }
        }

        private void dgvDoldur()
        {
            string mevkiBlgiSql = "SELECT Calisma_Mevkileri.Mevki_No, Calisma_Mevkileri.Mevki_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi FROM Calisma_Mevkileri INNER JOIN Personeller ON Calisma_Mevkileri.Mevki_Adi = Personeller.Personel_Mevki";
            DataTable tblMevkiler = OrtakClass.Yardim.GetDataTable(mevkiBlgiSql);
            dgvMevki.DataSource = tblMevkiler;
        }

        private void calismamevki_Load(object sender, EventArgs e)
        {
            dgvDoldur();
            dgvMevki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
