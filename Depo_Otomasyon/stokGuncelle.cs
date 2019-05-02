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
    public partial class stokGuncelle : Form
    {
        public string stokAdi, stokCinsi, stokAciklama, stokBarkod;
        public stokGuncelle()
        {
            InitializeComponent();
        }
        
        private void stokGuncelle_Load(object sender, EventArgs e)
        {
            txtStokAciklama.Text = stokAciklama;
            txtStokBarkod.Text = stokBarkod;
            txtStokCinsi.Text = stokCinsi;
            txtStokIsmi.Text = stokAdi;
            comboDoldur();
        }

        private void comboDoldur()
        {
            //Firma Combobox Doldur
            string firmaDoldurSQL = "Select Firma_No, Firma_Adi from Firmalar";
            DataTable tblFirma = OrtakClass.Yardim.GetDataTable(firmaDoldurSQL);
            cmbFirma.DisplayMember = "Firma_Adi";
            cmbFirma.ValueMember = "Firma_No";
            cmbFirma.DataSource = tblFirma;

            //Ölçü Combobox Doldur
            string olcuDoldurSQL = "Select Olcu_No, Olcu_Adi from Olculer";
            DataTable tblOlcu = OrtakClass.Yardim.GetDataTable(olcuDoldurSQL);
            cmbOlcuBirimi.DisplayMember = "Olcu_Adi";
            cmbOlcuBirimi.ValueMember = "Olcu_No";
            cmbOlcuBirimi.DataSource = tblOlcu;

            //Personel Combobox Doldur
            string personelDoldurSQL = "Select Personel_No, (Personel_Adi + ' ' + Personel_Soyadi) as perAdSoyad from Personeller";
            DataTable tblPersonel = OrtakClass.Yardim.GetDataTable(personelDoldurSQL);
            cmbStokYetkiliPersonel.DisplayMember = "perAdSoyad";
            cmbStokYetkiliPersonel.ValueMember = "Personel_No";
            cmbStokYetkiliPersonel.DataSource = tblPersonel;
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && cmbFirma.Text != string.Empty && cmbOlcuBirimi.Text != string.Empty && cmbStokYetkiliPersonel.Text != string.Empty && txtStokAciklama.Text != string.Empty)
                    {
                        try
                        {
                            string stokGuncelleSQL = "Update Stoklar set Stok_Adi=@stokAdi, Stok_Cinsi=@stokCinsi, Stok_Uretici_Firma=@stokUreticiFirma, Stok_Yetkili_Personel=@stokYetkili, Stok_Olcu_Birimi=@olcuBirimi, Stok_Aciklama=@stokAciklama where Stok_Barkod=@stokBarkod";
                            //***
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokAdi", OleDbType.VarChar).Value = txtStokIsmi.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokCinsi", OleDbType.VarChar).Value = txtStokCinsi.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokUreticiFirma", OleDbType.Single).Value = cmbFirma.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokYetkili", OleDbType.VarChar).Value = cmbStokYetkiliPersonel.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@olcuBirimi", OleDbType.Single).Value = cmbOlcuBirimi.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokAciklama", OleDbType.VarChar).Value = txtStokAciklama.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@stokBarkod", OleDbType.VarChar).Value = txtStokBarkod.Text;

                            OrtakClass.Yardim.Komutisle(stokGuncelleSQL);

                            MessageBox.Show("Stok Güncellendi", "Güncelleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
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
        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
