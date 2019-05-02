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
    public partial class depoVirmanGoruntule : Form
    {
        public depoVirmanGoruntule()
        {
            InitializeComponent();
        }

        private void depoVirmanGoruntule_Load(object sender, EventArgs e)
        {
            try
            {
                string virmanGetir = "SELECT Depo_Virman.Stok_Barkod, Stoklar.Stok_Adi, Depolar.Depo_Adi, Depo_Virman.Miktar, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Depo_Virman.Tarih FROM((Depo_Virman INNER JOIN Stoklar ON Depo_Virman.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Personeller ON Depo_Virman.YetkiliPersonel = Personeller.Personel_No) INNER JOIN Depolar ON Depo_Virman.AliciDepo = Depolar.Depo_No UNION SELECT Depo_Virman.Stok_Barkod, Stoklar.Stok_Adi, Depolar.Depo_Adi, Depo_Virman.Miktar, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Depo_Virman.Tarih FROM((Depo_Virman INNER JOIN Stoklar ON Depo_Virman.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Personeller ON Depo_Virman.YetkiliPersonel = Personeller.Personel_No) INNER JOIN Depolar ON Depo_Virman.GonderenDepo = Depolar.Depo_No";

                DataTable tblStoklar = OrtakClass.Yardim.GetDataTable(virmanGetir);
                dgvStoklar.DataSource = tblStoklar;
                dgvRenklendir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRenklendir()
        {
            for (int i = 0; i < dgvStoklar.Rows.Count; i+=2)
            {
                dgvStoklar.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
            }
            for (int i = 1; i < dgvStoklar.Rows.Count; i+=2)
            {
                dgvStoklar.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
        }
    }
}
