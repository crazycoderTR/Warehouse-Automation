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
using iTextSharp.text;
using iTextSharp.text.pdf;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using System.IO;

namespace Depo_Otomasyon
{
    public partial class raporlar : Form
    {
        public string FileName { get; set; } //pdf oluşturacağımız dosya adı
        public string Text { get; set; } //dosyanın içinde oluşturacağımız pdf adı
        public int PdfRowIndex { get; set; } //pdfrowindex
        public string Path { get; set; }

        public raporlar()
        {
            InitializeComponent();
        }

        private void raporlar_Load(object sender, EventArgs e)
        {
            dgvRaporDoldur();
            dgvGoruntu();
            maliyetHesapla();
        }

        private void dgvGoruntu()
        {
            dgvRaporDetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaporlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvRaporDoldur()
        {
            string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Firmalar.Firma_Adi, Stoklar.Toplam_Mevcut_Miktar, Stok_Hareketler.İslem_Tarihi FROM(((Personeller INNER JOIN(Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No order by Stok_Hareketler.İslem_Tarihi desc";
            System.Data.DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
            dgvRaporlar.DataSource = tblHareketler;
            dgvHeader();
        }

        private void dgvHeader()
        {
            dgvRaporlar.Columns["Stok_Barkod"].HeaderText = "Stok Barkodu";
            dgvRaporlar.Columns["Stok_Adi"].HeaderText = "Stok Adı";
            dgvRaporlar.Columns["Stok_Cinsi"].HeaderText = "Stok Cinsi";
            dgvRaporlar.Columns["İslem_Tarihi"].HeaderText = "İşlem Tarihi";
            dgvRaporlar.Columns["Depo_Adi"].HeaderText = "Depo Adı";
            dgvRaporlar.Columns["Toplam_Mevcut_Miktar"].HeaderText = "Toplam Mevcut Miktar";
            dgvRaporlar.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
            dgvRaporlar.Columns["Hareket_Miktari"].HeaderText = "Hareket Miktarı";
            dgvRaporlar.Columns["Olcu_Adi"].HeaderText = "Ölçü Birimi";
            dgvRaporlar.Columns["Personel_Adi"].HeaderText = "Personel Adı";
            dgvRaporlar.Columns["Personel_Soyadi"].HeaderText = "Personel Soyadı";
            dgvRaporlar.Columns["Firma_Adi"].HeaderText = "Firma Adı";
            dgvRaporlar.Columns["Stok_Birim_Fiyati"].HeaderText = "Birim Fiyat";
            dgvRaporlar.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
            dgvRaporlar.Columns["Hareket_Tipi"].HeaderText = "Stok Hareketi";
            
        }

        private void btnVeriGetir1_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                string raporVeriSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Firmalar.Firma_Adi, Stoklar.Toplam_Mevcut_Miktar, Stok_Hareketler.İslem_Tarihi FROM(((Personeller INNER JOIN(Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No order by Stok_Hareketler.İslem_Tarihi desc";
                System.Data.DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(raporVeriSql);
                dgvRaporlar.DataSource = tblHareketler;
                maliyetHesapla();
            }
            else if (rd2.Checked)
            {
                string raporVeriSql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Firmalar.Firma_Adi, Stoklar.Toplam_Mevcut_Miktar, Stok_Hareketler.İslem_Tarihi FROM(((Personeller INNER JOIN(Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No where İslem_Tarihi BETWEEN @tarih1 AND @tarih2  order by Stok_Hareketler.İslem_Tarihi desc";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker2.Value.Date;
                System.Data.DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(raporVeriSql);
                dgvRaporlar.DataSource = tblHareketler;
                maliyetHesapla();
            }
        }

        private void maliyetHesapla()
        {
            double girdiMaliyet = 0, ciktiMaliyet = 0, toplamMaliyet = 0, toplamGirdiMaliyeti = 0, toplamCiktiMaliyeti = 0;
            string sql = "Select * from Stoklar";
            System.Data.DataTable tbl = OrtakClass.Yardim.GetDataTable(sql);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string barkod = tbl.Rows[i]["Stok_Barkod"].ToString();
                for (int j = 0; j < dgvRaporlar.Rows.Count; j++)
                {
                    if (barkod == dgvRaporlar.Rows[j].Cells["Stok_Barkod"].Value.ToString())
                    {
                        if (dgvRaporlar.Rows[j].Cells["Hareket_Tipi"].Value.ToString() == "Girdi")
                        {
                            girdiMaliyet += Convert.ToDouble(dgvRaporlar.Rows[j].Cells["Hareket_Miktari"].Value.ToString()) * Convert.ToDouble(dgvRaporlar.Rows[j].Cells["Stok_Birim_Fiyati"].Value.ToString());
                        }
                        else if (dgvRaporlar.Rows[j].Cells["Hareket_Tipi"].Value.ToString() == "Çıktı")
                        {
                            ciktiMaliyet += Convert.ToDouble(dgvRaporlar.Rows[j].Cells["Hareket_Miktari"].Value.ToString()) * Convert.ToDouble(dgvRaporlar.Rows[j].Cells["Stok_Birim_Fiyati"].Value.ToString());
                        }
                    }
                }
                toplamMaliyet += ciktiMaliyet - girdiMaliyet;
                toplamGirdiMaliyeti += girdiMaliyet;
                toplamCiktiMaliyeti += ciktiMaliyet;
                girdiMaliyet = 0;
                ciktiMaliyet = 0;
            }
            txtToplamMaliyet.Text = toplamMaliyet.ToString();
            txtGirdiMaliyet.Text = toplamGirdiMaliyeti.ToString();
            txtCiktiMaliyet.Text = toplamCiktiMaliyeti.ToString();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void dgvRaporlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string urunDetaySql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Firmalar.Firma_Adi, Stoklar.Toplam_Mevcut_Miktar, Stok_Hareketler.İslem_Tarihi FROM(((Personeller INNER JOIN(Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No where Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = dgvRaporlar.CurrentRow.Cells["Stok_Barkod"].Value.ToString();
            System.Data.DataTable tblUrunDetay = OrtakClass.Yardim.GetDataTable(urunDetaySql);
            dgvRaporDetay.DataSource = tblUrunDetay;
            urunDetayHesapla();
            dgvHeader1();
        }

        private void dgvHeader1()
        {
            dgvRaporDetay.Columns["Stok_Barkod"].HeaderText = "Stok Barkodu";
            dgvRaporDetay.Columns["Stok_Adi"].HeaderText = "Stok Adı";
            dgvRaporDetay.Columns["Stok_Cinsi"].HeaderText = "Stok Cinsi";
            dgvRaporDetay.Columns["İslem_Tarihi"].HeaderText = "İşlem Tarihi";
            dgvRaporDetay.Columns["Depo_Adi"].HeaderText = "Depo Adı";
            dgvRaporDetay.Columns["Toplam_Mevcut_Miktar"].HeaderText = "Stok Mevcut Miktar";
            dgvRaporDetay.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
            dgvRaporDetay.Columns["Hareket_Miktari"].HeaderText = "Hareket Miktarı";
            dgvRaporDetay.Columns["Olcu_Adi"].HeaderText = "Ölçü Birimi";
            dgvRaporDetay.Columns["Personel_Adi"].HeaderText = "Personel Adı";
            dgvRaporDetay.Columns["Personel_Soyadi"].HeaderText = "Personel Soyadı";
            dgvRaporDetay.Columns["Firma_Adi"].HeaderText = "Firma Adı";
            dgvRaporDetay.Columns["Stok_Birim_Fiyati"].HeaderText = "Birim Fiyat";
            dgvRaporDetay.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
            dgvRaporDetay.Columns["Hareket_Tipi"].HeaderText = "Stok Hareketi";
        }

        private void urunDetayHesapla()
        {
                double girdiMaliyet = 0, ciktiMaliyet = 0, toplamMaliyet = 0, toplamGirdiMaliyeti = 0, toplamCiktiMaliyeti = 0;
                for (int j = 0; j < dgvRaporDetay.Rows.Count; j++)
                {
                     if (dgvRaporDetay.Rows[j].Cells["Hareket_Tipi"].Value.ToString() == "Girdi")
                     {
                         girdiMaliyet += Convert.ToDouble(dgvRaporDetay.Rows[j].Cells["Hareket_Miktari"].Value.ToString()) * Convert.ToDouble(dgvRaporDetay.Rows[j].Cells["Stok_Birim_Fiyati"].Value.ToString());
                     }
                     else if (dgvRaporDetay.Rows[j].Cells["Hareket_Tipi"].Value.ToString() == "Çıktı")
                     {
                         ciktiMaliyet += Convert.ToDouble(dgvRaporDetay.Rows[j].Cells["Hareket_Miktari"].Value.ToString()) * Convert.ToDouble(dgvRaporDetay.Rows[j].Cells["Stok_Birim_Fiyati"].Value.ToString());
                     }

                     toplamMaliyet += ciktiMaliyet - girdiMaliyet;
                     toplamGirdiMaliyeti += girdiMaliyet;
                     toplamCiktiMaliyeti += ciktiMaliyet;
                     girdiMaliyet = 0;
                     ciktiMaliyet = 0;
                }
                txtGirdiMaliyetiUrun.Text = toplamGirdiMaliyeti.ToString();
                txtCiktiMaliyetiUrun.Text = toplamCiktiMaliyeti.ToString();
                txtToplamMliyetUrun.Text = toplamMaliyet.ToString();
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
        }

        private void rd4_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
        }

        private void btnVeriGetir2_Click_1(object sender, EventArgs e)
        {
            if (rd3.Checked)
            {
                string urunDetaySql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Firmalar.Firma_Adi, Stoklar.Toplam_Mevcut_Miktar, Stok_Hareketler.İslem_Tarihi FROM(((Personeller INNER JOIN(Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No where Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = dgvRaporlar.CurrentRow.Cells["Stok_Barkod"].Value.ToString();
                System.Data.DataTable tblUrunDetay = OrtakClass.Yardim.GetDataTable(urunDetaySql);
                dgvRaporDetay.DataSource = tblUrunDetay;
                urunDetayHesapla();
                dgvHeader1();
            }
            else if (rd4.Checked)
            {
                string urunDetaySql = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Firmalar.Firma_Adi, Stoklar.Toplam_Mevcut_Miktar, Stok_Hareketler.İslem_Tarihi FROM(((Personeller INNER JOIN(Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) ON Personeller.Personel_No = Stoklar.Stok_Yetkili_Personel) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Firmalar ON Stoklar.Stok_Uretici_Firma = Firmalar.Firma_No where İslem_Tarihi BETWEEN @tarih1 AND @tarih2 AND Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker3.Value.Date;
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker4.Value.Date;
                OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = dgvRaporlar.CurrentRow.Cells["Stok_Barkod"].Value.ToString();
                System.Data.DataTable tblUrunDetay = OrtakClass.Yardim.GetDataTable(urunDetaySql);
                dgvRaporDetay.DataSource = tblUrunDetay;
                urunDetayHesapla();
                dgvHeader1();
            }
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application uyg = new Excel.Application();
                uyg.Visible = true;
                object Missing = Type.Missing;
                Excel.Workbook kitap = uyg.Workbooks.Add(Missing);
                Excel.Worksheet sheet = (Excel.Worksheet)kitap.Sheets[1];
                for (int i = 0; i < dgvRaporlar.Columns.Count; i++)
                {
                    Excel.Range myRange = (Excel.Range)sheet.Cells[1, i + 1];
                    myRange.Value2 = dgvRaporlar.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvRaporlar.Columns.Count; i++)
                {
                    for (int j = 0; j < dgvRaporlar.Rows.Count; j++)
                    {
                        if (dgvRaporlar.Columns[i].HeaderText == "İşlem Tarihi")
                        {
                            Excel.Range myRange = (Excel.Range)sheet.Cells[j + 2, i + 1];
                            myRange.Value2 = (DateTime)dgvRaporlar[i, j].Value;
                            sheet.get_Range("D1", "D1048576").NumberFormat = "gg.aa.yyyy";
                        }
                        else
                        {
                            Excel.Range myRange = (Excel.Range)sheet.Cells[j + 2, i + 1];
                            myRange.Value2 = dgvRaporlar[i, j].Value;
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExceleAktar2_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application uyg = new Excel.Application();
                uyg.Visible = true;
                object Missing = Type.Missing;
                Excel.Workbook kitap = uyg.Workbooks.Add(Missing);
                Excel.Worksheet sheet = (Excel.Worksheet)kitap.Sheets[1];
                for (int i = 0; i < dgvRaporDetay.Columns.Count; i++)
                {
                    Excel.Range myRange = (Excel.Range)sheet.Cells[1, i + 1];
                    myRange.Value2 = dgvRaporDetay.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgvRaporDetay.Columns.Count; i++)
                {
                    for (int j = 0; j < dgvRaporDetay.Rows.Count; j++)
                    {
                        if (dgvRaporDetay.Columns[i].HeaderText == "İslem_Tarihi")
                        {
                            Excel.Range myRange = (Excel.Range)sheet.Cells[j + 2, i + 1];
                            myRange.Value2 = (DateTime)dgvRaporDetay[i, j].Value;
                            sheet.get_Range("D1", "D1048576").NumberFormat = "gg.aa.yyyy";
                        }
                        else
                        {
                            Excel.Range myRange = (Excel.Range)sheet.Cells[j + 2, i + 1];
                            myRange.Value2 = dgvRaporDetay[i, j].Value;
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Güncelleme İle Dahil Olacak !!!  İlginiz İçin Teşekkürler.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYazdir2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Güncelleme İle Dahil Olacak !!!  İlginiz İçin Teşekkürler.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPdfAktar1_Click(object sender, EventArgs e)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable table = new PdfPTable(dgvRaporlar.Columns.Count);
            table.DefaultCell.Padding = 3;
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add Header
            foreach (DataGridViewColumn column in dgvRaporlar.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                table.AddCell(cell);
            }

            //Add Datarow
            foreach (DataGridViewRow row in dgvRaporlar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Rapor";
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    stream.Close();
                }
            }

        }

        private void btnPdfAktar2_Click(object sender, EventArgs e)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable table = new PdfPTable(dgvRaporDetay.Columns.Count);
            table.DefaultCell.Padding = 3;
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add Header
            foreach (DataGridViewColumn column in dgvRaporDetay.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                table.AddCell(cell);
            }

            //Add Datarow
            foreach (DataGridViewRow row in dgvRaporDetay.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Rapor";
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
