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
    public partial class depolar : Form
    {
        public depolar()
        {
            InitializeComponent();
        }

        private void btnDepoGoruntule_Click(object sender, EventArgs e)
        {
            if (this.Height != 516)
            {
                this.Height = 516;
                btnDepoGoruntule.Text = "Depoları Kapat";
            }
            else if (this.Height == 516)
            {
                this.Height = 218;
                btnDepoGoruntule.Text = "Depoları Görüntüle";
            }
            dgvDoldur();
        }

        private void dgvDoldur()
        {
            try
            {
                string depolarSql = "SELECT Depolar.Depo_No, Depolar.Depo_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Depolar.Depo_Eklenme_Tarihi FROM Personeller INNER JOIN Depolar ON Personeller.Personel_No = Depolar.Depo_Sorumlu_No";
                DataTable tblDepolar = OrtakClass.Yardim.GetDataTable(depolarSql);
                dgvDepolar.DataSource = tblDepolar;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvHeader();
        }

        private void dgvHeader()
        {
            dgvDepolar.Columns["Depo_No"].HeaderText = "Depo No";
            dgvDepolar.Columns["Depo_Adi"].HeaderText = "Depo Adı";
            dgvDepolar.Columns["Personel_Adi"].HeaderText = "Yetkili Personel Adı";
            dgvDepolar.Columns["Personel_Soyadi"].HeaderText = "Yetkili Personel Soyadı";
            dgvDepolar.Columns["Depo_Eklenme_Tarihi"].HeaderText = "Depo Eklenme Tarihi";
        }

        private void Depolar_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            dgvDepolar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ComboDoldur()
        {
            try
            {
                string depoSorumluSql = "Select Personel_No,(Personel_Adi + ' ' + Personel_Soyadi) as perAdSoyad from Personeller";
                DataTable depoSorumlu = OrtakClass.Yardim.GetDataTable(depoSorumluSql);
                cmbDepoSorumlu.DisplayMember = "perAdSoyad";
                cmbDepoSorumlu.ValueMember = "Personel_No";
                cmbDepoSorumlu.DataSource = depoSorumlu;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && cmbDepoSorumlu.Text != string.Empty)
                    {
                        try
                        {
                            string depoSql = "insert into Depolar(Depo_Adi,Depo_Sorumlu_No,Depo_Eklenme_Tarihi) Values(@depoAdi,@depoSorumluNo,@depoEklenmeTarihi)";
                            //***
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@depoAdi", OleDbType.VarChar).Value = txtDepoAd.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@depoSorumluNo", OleDbType.VarChar).Value = cmbDepoSorumlu.SelectedValue;
                            OrtakClass.Yardim.Komut.Parameters.Add("@depoEklenmeTarihi", OleDbType.Date).Value = DateTime.Today.Date;
                            //***
                            OrtakClass.Yardim.Komutisle(depoSql);
                            MessageBox.Show("Depo Eklendi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik Bilgi Olmayacak Şekilde Devam Ediniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;

                    }
                }
            }

            dgvDoldur();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty)
            {
                try
                {
                    if (rdb1.Checked)
                    {
                        string depolarSql = "SELECT Depolar.Depo_No, Depolar.Depo_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Depolar.Depo_Eklenme_Tarihi FROM Personeller INNER JOIN Depolar ON Personeller.Personel_No = Depolar.Depo_Sorumlu_No where Depolar.Depo_Adi like @depoAdi";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@depoAdi", OleDbType.VarChar).Value = txtAra.Text + "%";
                        //***
                        DataTable tblDepolar = OrtakClass.Yardim.GetDataTable(depolarSql);
                        dgvDepolar.DataSource = tblDepolar;
                    }
                    else if (rdb2.Checked)
                    {
                        string depolarSql = "SELECT Depolar.Depo_No, Depolar.Depo_Adi, Personeller.Personel_Adi, Personeller.Personel_Soyadi, Depolar.Depo_Eklenme_Tarihi FROM Personeller INNER JOIN Depolar ON Personeller.Personel_No = Depolar.Depo_Sorumlu_No where Depolar.Depo_No=@depoNo";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@depoNo", OleDbType.Single).Value = txtAra.Text;
                        //***
                        DataTable tblDepolar = OrtakClass.Yardim.GetDataTable(depolarSql);
                        dgvDepolar.DataSource = tblDepolar;
                    }
                    else
                    {
                        dgvDoldur();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvDoldur();     
            }
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Depo Adı;";
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Depo Numarası;";
        }

        private void txtDepoAd_TextChanged(object sender, EventArgs e)
        {
            txtDepoAd.Text = txtDepoAd.Text.ToUpper();
            txtDepoAd.SelectionStart = txtDepoAd.Text.Length;
        }

        private void dgvDepolar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            depodetay frmDepoDetay = new depodetay();
            frmDepoDetay.depoNo = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["Depo_No"].Value.ToString());
            frmDepoDetay.depoAdi = dgvDepolar.CurrentRow.Cells["Depo_Adi"].Value.ToString();
            frmDepoDetay.perAd = dgvDepolar.CurrentRow.Cells["Personel_Adi"].Value.ToString();
            frmDepoDetay.perSoyad = dgvDepolar.CurrentRow.Cells["Personel_Soyadi"].Value.ToString();
            frmDepoDetay.kayitTarihi = dgvDepolar.CurrentRow.Cells["Depo_Eklenme_Tarihi"].Value.ToString();
            frmDepoDetay.Show();
        }
    }
}
