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
    public partial class stokhareketler : Form
    {
        public stokhareketler()
        {
            InitializeComponent();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtStokBarkod.Enabled = false;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtStokBarkod.Enabled = false;
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtStokBarkod.Enabled = true;
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtStokBarkod.Enabled = true;
        }

        private void btnVeriGoster_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.İslem_Tarihi FROM ((Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No order by Stok_Hareketler.İslem_Tarihi desc";
                DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
                dgvHareketler.DataSource = tblHareketler;
                dataRenklendir();
            }
            else if (rd2.Checked)
            {
                string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.İslem_Tarihi FROM ((Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No where İslem_Tarihi BETWEEN @tarih1 AND @tarih2 order by Stok_Hareketler.İslem_Tarihi desc";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker2.Value.Date;
                DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
                if (tblHareketler != null)
                {
                    dgvHareketler.DataSource = tblHareketler;
                    dataRenklendir();
                }
                else
                {
                    MessageBox.Show("Hatalı Değer Girdiniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rd3.Checked)
            {
                string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.İslem_Tarihi FROM ((Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No where İslem_Tarihi BETWEEN @tarih1 AND @tarih2 AND Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker2.Value.Date; 
                OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
                if (tblHareketler != null)
                {
                    dgvHareketler.DataSource = tblHareketler;
                    dataRenklendir();
                }
                else
                {
                    MessageBox.Show("Hatalı Değer Girdiniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rd4.Checked)
            {
                string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.İslem_Tarihi FROM ((Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No where Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
                if (tblHareketler != null)
                {
                    dgvHareketler.DataSource = tblHareketler;
                    dataRenklendir();
                }
                else
                {
                    MessageBox.Show("Hatalı Değer Girdiniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dgvHeader();
        }

        private void dataRenklendir()
        {
            for (int i = 0; i < dgvHareketler.Rows.Count; i++)
            {
                if (dgvHareketler.Rows[i].Cells["Hareket_Tipi"].Value.ToString() == "Girdi")
                {
                    dgvHareketler.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;

                }
                else if (dgvHareketler.Rows[i].Cells["Hareket_Tipi"].Value.ToString() == "Çıktı")
                {
                    dgvHareketler.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void stokharekatlar_Load(object sender, EventArgs e)
        {
            dgvHareketler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void dgvHeader()
        {
            dgvHareketler.Columns["Stok_Barkod"].HeaderText = "Stok Barkodu";
            dgvHareketler.Columns["Stok_Adi"].HeaderText = "Stok Adı";
            dgvHareketler.Columns["Stok_Cinsi"].HeaderText = "Stok Cinsi";
            dgvHareketler.Columns["İslem_Tarihi"].HeaderText = "İşlem Tarihi";
            dgvHareketler.Columns["Depo_Adi"].HeaderText = "Depo Adı";
            dgvHareketler.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
            dgvHareketler.Columns["Hareket_Miktari"].HeaderText = "Hareket Miktarı";
            dgvHareketler.Columns["Olcu_Adi"].HeaderText = "Ölçü Birimi";
            dgvHareketler.Columns["Stok_Birim_Fiyati"].HeaderText = "Birim Fiyat";
            dgvHareketler.Columns["Stok_Maliyeti"].HeaderText = "Stok Maliyeti";
            dgvHareketler.Columns["Hareket_Tipi"].HeaderText = "Stok Hareketi";
        }

        private void txtStokBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rd3.Checked)
                {
                    string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.İslem_Tarihi FROM ((Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No where İslem_Tarihi BETWEEN @tarih1 AND @tarih2 AND Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                    OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker2.Value.Date;
                    OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                    DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
                    if (tblHareketler != null)
                    {
                        dgvHareketler.DataSource = tblHareketler;
                        dataRenklendir();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Değer Girdiniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else if (rd4.Checked)
                {
                    string hareketVeri = "SELECT Stoklar.Stok_Barkod, Stoklar.Stok_Adi, Stoklar.Stok_Cinsi, Depolar.Depo_Adi, Stok_Hareketler.Hareket_Tipi, Stok_Hareketler.Hareket_Miktari, Olculer.Olcu_Adi, Stok_Hareketler.Stok_Birim_Fiyati, Stok_Hareketler.Stok_Maliyeti, Stok_Hareketler.İslem_Tarihi FROM ((Stok_Hareketler INNER JOIN Stoklar ON Stok_Hareketler.Stok_Barkod = Stoklar.Stok_Barkod) INNER JOIN Olculer ON Stoklar.Stok_Olcu_Birimi = Olculer.Olcu_No) INNER JOIN Depolar ON Stok_Hareketler.Depo = Depolar.Depo_No where Stoklar.Stok_Barkod=@barkod order by Stok_Hareketler.İslem_Tarihi desc";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@barkod", OleDbType.VarChar).Value = txtStokBarkod.Text;
                    DataTable tblHareketler = OrtakClass.Yardim.GetDataTable(hareketVeri);
                    if (tblHareketler != null)
                    {
                        dgvHareketler.DataSource = tblHareketler;
                        dataRenklendir();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Değer Girdiniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
