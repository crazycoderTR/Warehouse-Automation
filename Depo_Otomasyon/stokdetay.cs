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
    public partial class stokdetay : Form
    {
        public stokdetay()
        {
            InitializeComponent();
        }
        public string stokBarkod, stokAdi, perAdi, perSoyadi, stokKayitTarihi;
        private void stokdetay_Load(object sender, EventArgs e)
        {
            txtKayitTarihi.Text = stokKayitTarihi;
            txtStokAdi.Text = stokAdi;
            txtStokBarkod.Text = stokBarkod;
            txtStokYetkili.Text = perAdi + " " + perSoyadi;
            dgvDoldur();
            dgvHeader();
            dgvStokDetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvHeader()
        {
            dgvStokDetay.Columns["Depo_Adi"].HeaderText = "Depo Adı";
            dgvStokDetay.Columns["Stok_Mevcut_Miktari"].HeaderText = "Stok Miktari";
            dgvStokDetay.Columns["Personel_Adi"].HeaderText = "Depo Yetkili Personel Adı";
            dgvStokDetay.Columns["Personel_Soyadi"].HeaderText = "Depo Yetkili Personel Soyadı";
        }

        private void dgvDoldur()
        {
            try
            {
                string stokVeriSql = "SELECT Depolar.Depo_Adi, Stok_Mevcut_Miktarlar.Stok_Mevcut_Miktari, Personeller.Personel_Adi, Personeller.Personel_Soyadi FROM Personeller INNER JOIN (Depolar INNER JOIN Stok_Mevcut_Miktarlar ON Depolar.Depo_No = Stok_Mevcut_Miktarlar.Bulundugu_Depo) ON Personeller.Personel_No = Depolar.Depo_Sorumlu_No where Stok_Mevcut_Miktarlar.Stok_Barkod=@barkod";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@barkod", System.Data.OleDb.OleDbType.VarChar).Value = stokBarkod;
                DataTable tblStokDetay = OrtakClass.Yardim.GetDataTable(stokVeriSql);
                dgvStokDetay.DataSource = tblStokDetay;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Missing);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dgvStokDetay.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgvStokDetay.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dgvStokDetay.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvStokDetay.Columns.Count; j++)
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dgvStokDetay[j, i].Value == null ? "" : dgvStokDetay[j, i].Value;
                        myRange.Select();


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
