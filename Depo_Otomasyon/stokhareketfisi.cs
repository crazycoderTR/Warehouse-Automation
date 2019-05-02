using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;

namespace Depo_Otomasyon
{
    public partial class stokhareketfisi : Form
    {
        public stokhareketfisi()
        {
            InitializeComponent();
        }
        public string stokBarkod, stokIsmi, StokUretici, stokDepo, stokPersonel, stokHareketMiktar, stokBirimFiyat, stokMaliyeti, islemTarihi;
        public int stokHareketTur = 0;
        private void stokhareketfisi_Load(object sender, EventArgs e)
        {
            label1.Text = "Stok Barkod: " + stokBarkod;
            label2.Text = "Stok İsmi: " + stokIsmi;
            label3.Text = "Stok Üretici: " + StokUretici;
            label4.Text = "Stok Deposu: " + stokDepo;
            label5.Text = "Stok Personeli: " + stokPersonel;
            label7.Text = "Stok Birim Fiyat: " + stokBirimFiyat;
            label8.Text = "Stok Maliyeti: " + stokMaliyeti;
            label9.Text = "İşlem Tarihi: " + islemTarihi;
            barkodFotoCek();

            if (stokHareketTur == 1)
            {
                label6.Text = "Stok Giren Miktar: " + stokHareketMiktar;
            }
            else
            {
                label6.Text = "Stok Çıkan Miktar: " + stokHareketMiktar;
            }
        }

        private void barkodFotoCek()
        {
            string stokBarkodFotoSql = "select Stok_Barkod_Foto from Stoklar where Stok_Barkod=@barkod";
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("", System.Data.OleDb.OleDbType.VarChar).Value = stokBarkod;
            DataRow stok = OrtakClass.Yardim.GetDataRow(stokBarkodFotoSql);
            //***********************
            byte[] imageByte1 = (byte[])stok["Stok_Barkod_Foto"];
            MemoryStream strm1 = new MemoryStream(imageByte1);
            Image img1 = Image.FromStream(strm1);
            pcbBarkod.Image = img1;
        }

        private void btnFisKes_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
    }
}
