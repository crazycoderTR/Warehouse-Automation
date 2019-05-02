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
    public partial class depodetay : Form
    {
        public depodetay()
        {
            InitializeComponent();
        }
        public string depoAdi, perAd, perSoyad, kayitTarihi;
        public int depoNo = 0;
        private void depodetay_Load(object sender, EventArgs e)
        {
            txtDepoAdi.Text = depoAdi;
            txtDepoNo.Text = depoNo.ToString();
            txtDepoKayıtTarih.Text = kayitTarihi;
            txtDepoYetkili.Text = perAd + " " + perSoyad;
            dgvDoldur();
            toplamStokHesapla();
            dgvHeader();
        }


        private void toplamStokHesapla()
        {
            try
            {
                double toplamStokMiktari = 0;
                string miktarAlSqL = "SELECT Stok_Mevcut_Miktari, Bulundugu_Depo from Stok_Mevcut_Miktarlar";
                DataTable tblDepoMiktarlar = OrtakClass.Yardim.GetDataTable(miktarAlSqL);

                for (int j = 0; j < tblDepoMiktarlar.Rows.Count; j++)
                {
                    if (depoNo == Convert.ToInt32(tblDepoMiktarlar.Rows[j]["Bulundugu_Depo"].ToString()))
                    {
                        toplamStokMiktari += Convert.ToInt32(tblDepoMiktarlar.Rows[j]["Stok_Mevcut_Miktari"].ToString());
                    }
                }
                txtToplamStok.Text = toplamStokMiktari.ToString() + " Adet";

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDoldur()
        {
            try
            {
                string depoVeriSql = "SELECT Stoklar.Stok_Adi, Stok_Hareketler.İslem_Tarihi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Hareket_Tipi FROM Olculer INNER JOIN (Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) ON Olculer.Olcu_No = Stoklar.Stok_Olcu_Birimi where  Stok_Hareketler.Depo=@depoNo";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@depoNo", System.Data.OleDb.OleDbType.Single).Value = depoNo;
                DataTable tblDepoVeri = OrtakClass.Yardim.GetDataTable(depoVeriSql);
                if (tblDepoVeri != null)
                {
                    dgvDepoDetay.DataSource = tblDepoVeri;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvDepoDetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvHeader()
        {
            dgvDepoDetay.Columns["Stok_Adi"].HeaderText = "Stok Adı";
            dgvDepoDetay.Columns["İslem_Tarihi"].HeaderText = "İşlem Tarihi";
            dgvDepoDetay.Columns["Hareket_Miktari"].HeaderText = "Stok Hareket Miktarı";
            dgvDepoDetay.Columns["Stok_Birim_Fiyati"].HeaderText = "Stok Birim Fiyatı";
            dgvDepoDetay.Columns["Hareket_Tipi"].HeaderText = "Stok Hareket Tipi";
            dgvDepoDetay.Columns["Olcu_Adi"].HeaderText = "Stok Ölçü Birimi";
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                uyg.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                for (int i = 0; i < dgvDepoDetay.Columns.Count; i++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[1, i + 1];
                    myRange.Value2 = dgvDepoDetay.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvDepoDetay.Columns.Count; i++)
                {
                    for (int j = 0; j < dgvDepoDetay.Rows.Count; j++)
                    {
                        if (dgvDepoDetay.Columns[i].HeaderText == "İşlem Tarihi")
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[j + 2, i + 1];
                            myRange.Value2 = (DateTime)dgvDepoDetay[i, j].Value;
                            sheet.get_Range("B1", "B1048576").NumberFormat = "gg.aa.yyyy";
                        }
                        else
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[j + 2, i + 1];
                            myRange.Value2 = dgvDepoDetay[i, j].Value;
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
}
