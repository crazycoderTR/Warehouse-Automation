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
    public partial class ajanda : Form
    {
        public ajanda()
        {
            InitializeComponent();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            panel1.Visible = false;
            groupBox1.Height = 167;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            dateTimePicker1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            groupBox1.Height = 240;
            panel1.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty && dateTimePicker3.Text != string.Empty && txtAciklama.Text != string.Empty)
                    {
                        try
                        {
                            string notEkleSql = "insert into Olaylar (Olay_Konu,Olay_Aciklama,aktif,Olay_Hatirlatici_Tarih) values(@olayKonu,@olayAciklama,@aktif,@olayTarihi)";
                            OrtakClass.Yardim.Komut.Parameters.Clear();
                            OrtakClass.Yardim.Komut.Parameters.Add("@olayKonu", OleDbType.VarChar).Value = txtKonu.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@olayAciklama", OleDbType.VarChar).Value = txtAciklama.Text;
                            OrtakClass.Yardim.Komut.Parameters.Add("@aktif", OleDbType.VarChar).Value = 1;
                            OrtakClass.Yardim.Komut.Parameters.Add("@olayTarihi", OleDbType.Date).Value = dateTimePicker3.Value.Date;
                            OrtakClass.Yardim.Komutisle(notEkleSql);
                            MessageBox.Show("Olay Eklendi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizlik();
                            DataDoldur(); break;
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

        }

        private void Temizlik()
        {
            txtAciklama.Clear();
            txtKonu.Clear();
        }

        private void txtKonu_TextChanged(object sender, EventArgs e)
        {
            txtKonu.Text = txtKonu.Text.ToUpper();
            txtKonu.SelectionStart = txtKonu.Text.Length;
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            txtAciklama.Text = txtAciklama.Text.ToUpper();
            txtAciklama.SelectionStart = txtAciklama.Text.Length;
        }

        private void ajanda_Load(object sender, EventArgs e)
        {
            DataDoldur();
            dgvHeader();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvHeader()
        {
            dataGridView1.Columns["Olay_No"].HeaderText = "Olay No";
            dataGridView1.Columns["Olay_Konu"].HeaderText = "Olay Konu";
            dataGridView1.Columns["aktif"].HeaderText = "Aktif/Pasif";
            dataGridView1.Columns["Olay_Aciklama"].HeaderText = "Olay Açıklama";
            dataGridView1.Columns["Olay_Hatirlatici_Tarih"].HeaderText = "Olay Hatırlatma Tarihi";
        }

        private void DataDoldur()
        {
            try
            {
                string notlarSql = "Select Olay_No,Olay_Konu,Olay_Aciklama,aktif,Olay_Hatirlatici_Tarih from Olaylar";
                DataTable tblNotlar = OrtakClass.Yardim.GetDataTable(notlarSql);
                dataGridView1.DataSource = tblNotlar;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOlayGoster_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                string olayGetirSql = "Select * from Olaylar where Olay_Hatirlatici_Tarih BETWEEN @tarih1 AND @tarih2";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker2.Value.Date;
                DataTable tblOLaylar = OrtakClass.Yardim.GetDataTable(olayGetirSql);
                dataGridView1.DataSource = tblOLaylar;
            }
            else if (rd2.Checked)
            {
                string olayGetirSql = "Select * from Olaylar where Olay_Hatirlatici_Tarih = @tarih";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = monthCalendar1.SelectionRange.Start.Date;
                DataTable tblOLaylar = OrtakClass.Yardim.GetDataTable(olayGetirSql);
                dataGridView1.DataSource = tblOLaylar;
            }
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string olayDurdurSQL = "update Olaylar set aktif=@pasif where Olay_No=@olayno";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("pasif", OleDbType.Single).Value = 0;
                OrtakClass.Yardim.Komut.Parameters.Add("olayno", OleDbType.Single).Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Olay_No"].Value.ToString());
                OrtakClass.Yardim.Komutisle(olayDurdurSQL);
                MessageBox.Show("Olay Bitirildi", "Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
