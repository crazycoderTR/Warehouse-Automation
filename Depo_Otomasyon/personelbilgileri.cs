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
    public partial class personelbilgileri : Form
    {
        public personelbilgileri()
        {
            InitializeComponent();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Personel İsmi;";
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Personel Numarası;";
        }

        private void personelbilgileri_Load(object sender, EventArgs e)
        {
            personelBilgiler();
        }

        private void personelBilgiler()
        {
            string personelBilgilerSql = "SELECT Personel_No, Personel_Kimlik_No, Personel_Adi, Personel_Soyadi, Personel_Mevki, Personel_Cinsiyet, Personel_Maas FROM Personeller";
            DataTable tblPersoneller = OrtakClass.Yardim.GetDataTable(personelBilgilerSql);
            dgvPersoneller.DataSource = tblPersoneller;
            dgvHeader();
        }

        private void dgvHeader()
        {
            dgvPersoneller.Columns["Personel_No"].HeaderText = "Personel No";
            dgvPersoneller.Columns["Personel_Kimlik_No"].HeaderText = "Personel Kimlik No";
            dgvPersoneller.Columns["Personel_Adi"].HeaderText = "Personel Adı";
            dgvPersoneller.Columns["Personel_Soyadi"].HeaderText = "Personel Soyadı";
            dgvPersoneller.Columns["Personel_Mevki"].HeaderText = "Personel Çalışma Mevkisi";
            dgvPersoneller.Columns["Personel_Cinsiyet"].HeaderText = "Personel Cinsiyeti";
            dgvPersoneller.Columns["Personel_Maas"].HeaderText = "Personel Maaşı";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty)
            {
                if (rd1.Checked)
                {
                    string personelBilgilerSql = "SELECT Personel_No, Personel_Kimlik_No, Personel_Adi, Personel_Soyadi, Personel_Mevki, Personel_Cinsiyet, Personel_Maas FROM Personeller where Personel_Adi like @personelAdi";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@personelAdi", OleDbType.VarChar).Value = txtAra.Text + "%";
                    DataTable tblPersoneller = OrtakClass.Yardim.GetDataTable(personelBilgilerSql);
                    dgvPersoneller.DataSource = tblPersoneller;
                }
                else if (rd2.Checked)
                {
                    string personelBilgilerSql = "SELECT Personel_No, Personel_Kimlik_No, Personel_Adi, Personel_Soyadi, Personel_Mevki, Personel_Cinsiyet, Personel_Maas FROM Personeller where Personel_No=@personelNo";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@personelNo", OleDbType.VarChar).Value = txtAra.Text;
                    DataTable tblPersoneller = OrtakClass.Yardim.GetDataTable(personelBilgilerSql);
                    dgvPersoneller.DataSource = tblPersoneller;
                }
            }
            else
            {
                personelBilgiler();
            }
        }

        private void dgvPersoneller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            personelguncelle frmPersonelGuncelle = new personelguncelle();
            frmPersonelGuncelle.perNo = dgvPersoneller.CurrentRow.Cells["Personel_No"].Value.ToString();
            frmPersonelGuncelle.ShowDialog();
            personelBilgiler();
        }
    }
}
