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
    public partial class kullaniciler : Form
    {
        public kullaniciler()
        {
            InitializeComponent();
        }

        private void kullaniciler_Load(object sender, EventArgs e)
        {
            dgvDoldur();
        }

        private void dgvDoldur()
        {
            string kullaniciler = "select * from Kullanıcılar";
            DataTable tblKullaniciler = OrtakClass.Yardim.GetDataTable(kullaniciler);
            dataGridView1.DataSource = tblKullaniciler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kaydı Silmek İstediğinize Emin Misiniz?", "Silme İşlemi" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                string sil = "delete from Kullancılar where KullaniciNo=@no";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@no", System.Data.OleDb.OleDbType.Single).Value = dataGridView1.CurrentRow.Cells["KullaniciNo"].Value.ToString();
                OrtakClass.Yardim.Komutisle(sil);
                MessageBox.Show("Kayıt Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            kullaniciduzenle frmKullaniciDuzenle = new kullaniciduzenle();
            frmKullaniciDuzenle.kullaniciNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KullaniciNo"].Value.ToString());
            frmKullaniciDuzenle.ShowDialog();
            dgvDoldur();
        }
    }
}
