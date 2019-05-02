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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
            OlayKontrol();
        }
        bool kapatma = false;
        public int deger = 0;
        public int kullaniciTur = 0;
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bazı Veriler Kaybolabilir, Çıkış Yapmak İstiyor Musunuz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                kapatma = true;
                if (kapatma == true)
                {
                    yedekAl();
                    Application.Exit();
                } 
            } 
        }

        private void yedekAl()
        {
            try
            {
                if (Directory.Exists(@"C:\\KılıncaslanSoftware"))
            {
                Directory.Delete(@"C:\\KılıncaslanSoftware", true);
            }
            string klasorYeri = "C:";
            string klasorAdi = "KılıncaslanSoftware";
            string klasorolustur = klasorYeri + @"\" + klasorAdi;
            Directory.CreateDirectory(klasorolustur);
            System.IO.File.Copy("Depo_Otomasyon.accdb", "C:\\KılıncaslanSoftware\\" + "DepoOtomasyonYedek" + ".accdb");
            MessageBox.Show("Veritabanı Kaydedilmiştir", "Dikkat",
MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            personelekle frmPersonelEkle = new personelekle();
            frmPersonelEkle.Show();
        }

        private void depoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kapatma == false)
            {
                e.Cancel = true;
            }
        }

        private void btnFirmalar_Click(object sender, EventArgs e)
        {
            firmalar frmFirmalar = new firmalar();
            frmFirmalar.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkimizda frmHakkimizda = new hakkimizda();
            frmHakkimizda.ShowDialog();
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            stokgirisi frmStokEkle = new stokgirisi();
            frmStokEkle.ShowDialog();
            dgvDoldur();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
           dgvDoldur();
           if (deger == 1)
           {
               btnYonetimPaneli.Enabled = false;
           }
           else if (kullaniciTur == 1)
           {
               btnYonetimPaneli.Enabled = false;
           }
           dgvGorunum();
        }

        private void dgvGorunum()
        {
           dgv1.Columns["Stok_Barkod"].HeaderText = "Stok Barkodu";
           dgv1.Columns["Stok_Adi"].HeaderText = "Stok Adı";
           dgv1.Columns["İslem_Tarihi"].HeaderText = "İşlem Tarihi";
           dgv1.Columns["Hareket_Miktari"].HeaderText = "Hareket Miktarı"; 
           dgv1.Columns["Olcu_Adi"].HeaderText = "Ölçü Birimi";
           dgv1.Columns["Stok_Birim_Fiyati"].HeaderText = "Birim Fiyat";
           dgv1.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
           dgv1.Columns["Hareket_Tipi"].HeaderText = "Stok Hareketi";
           dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void OlayKontrol()
        {
            try
            {
                string olayKontrolSql = "select Olay_Konu,Olay_Aciklama, aktif, Olay_Hatirlatici_Tarih from Olaylar where Olay_Hatirlatici_Tarih=@today";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@today", OleDbType.Date).Value = DateTime.Today.Date;
                DataTable tblOlay = OrtakClass.Yardim.GetDataTable(olayKontrolSql);
                for (int i = 0; i < tblOlay.Rows.Count; i++)
                {
                    if (Convert.ToInt32(tblOlay.Rows[i]["aktif"].ToString()) == 1)
                    {
                        DateTime olayTarihi = Convert.ToDateTime(tblOlay.Rows[i]["Olay_Hatirlatici_Tarih"].ToString());
                        DialogResult yanit = MessageBox.Show(tblOlay.Rows[i]["Olay_Aciklama"].ToString(), tblOlay.Rows[i]["Olay_Konu"].ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (yanit == DialogResult.OK)
                        {
                            ajanda frmAjanda = new ajanda();
                            frmAjanda.Show();
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDoldur()
        {
            string stokHareketler = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stok_Hareketler.İslem_Tarihi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.Hareket_Tipi, Depolar.Depo_Adi FROM((Stoklar INNER JOIN Stok_Hareketler ON Stoklar.Stok_Barkod = Stok_Hareketler.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No order by Stoklar.Stok_Tarihi desc";

            DataTable tblStok = OrtakClass.Yardim.GetDataTable(stokHareketler);
            dgv1.DataSource = tblStok;
            dgvRenklendir();
        }

        private void dgvRenklendir()
        {
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if (dgv1.Rows[i].Cells["Hareket_Tipi"].Value.ToString() == "Girdi")
                {
                    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;

                }
                else if (dgv1.Rows[i].Cells["Hareket_Tipi"].Value.ToString() == "Çıktı")
                {
                    dgv1.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void btnYeniStok_Click(object sender, EventArgs e)
        {
            stoktanimla frmStokTanimla = new stoktanimla();
            frmStokTanimla.Show();
        }

        private void stokTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stoktanimla frmStokTanimla = new stoktanimla();
            frmStokTanimla.Show();
        }

        private void btnPersonelBilgiler_Click(object sender, EventArgs e)
        {
            personelbilgileri frmPersonelBilgieri = new personelbilgileri();
            frmPersonelBilgieri.Show();
        }

        private void btnAjanda_Click(object sender, EventArgs e)
        {
            ajanda frmAjanda = new ajanda();
            frmAjanda.Show();
        }

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            stokcikisi frmStokCikisi = new stokcikisi();
            frmStokCikisi.ShowDialog();
            dgvDoldur();
        }

        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokgirisi frmStokGirisi = new stokgirisi();
            frmStokGirisi.ShowDialog();
            dgvDoldur();
        }

        private void stokÇıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokcikisi frmStokCikisi = new stokcikisi();
            frmStokCikisi.ShowDialog();
            dgvDoldur();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            stokhareketler frmStokHarekatlar = new stokhareketler();
            frmStokHarekatlar.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            raporlar frmRaporlar = new raporlar();
            frmRaporlar.Show();
        }

        private void stokGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokbilgileri frmStokBilgileri = new stokbilgileri();
            frmStokBilgileri.Show();
        }

        private void stokHareketGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokhareketler frmStokHareketler = new stokhareketler();
            frmStokHareketler.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporlar frmRaporlar = new raporlar();
            frmRaporlar.Show();
        }

        private void çalışmaMevkileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calismamevki frmCalismaMevki = new calismamevki();
            frmCalismaMevki.Show();
        }

        private void şirketBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sirketbilgileri frmSirketBilgileri = new sirketbilgileri();
            frmSirketBilgileri.Show();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasaislemleri frmKasa = new kasaislemleri();
            frmKasa.Show();
        }

        private void btnYonetimPaneli_Click(object sender, EventArgs e)
        {
            yonetimpaneli frmYonetimPaneli = new yonetimpaneli();
            frmYonetimPaneli.Show();
        }

        private void depolarArasıVirmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depoalarArasiVirman frmYonetimPaneli = new depoalarArasiVirman();
            frmYonetimPaneli.Show();
        }

        private void depolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depolar frmDepolar = new depolar();
            frmDepolar.Show();
        }

        private void virmanGörüntüleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            depoVirmanGoruntule virman = new depoVirmanGoruntule();
            virman.Show();
        }
    }
}
