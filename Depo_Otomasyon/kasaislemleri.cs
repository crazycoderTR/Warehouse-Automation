using Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Depo_Otomasyon
{
    public partial class kasaislemleri : Form
    {
        public kasaislemleri()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            label7.Text = "Ek Gelir Açıklama";
            label8.Text = "Ek Gelir Tutar";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Ek Gider Açıklama";
            label8.Text = "Ek Gider Tutar";
        }

        private void btnStokHesapla_Click(object sender, EventArgs e)
        {
            try
            {
double girdiMaliyet = 0, ciktiMaliyet = 0, toplamMaliyet = 0, toplamGirdiMaliyeti = 0, toplamCiktiMaliyeti = 0;
            string sql = "Select * from Stoklar";
            System.Data.DataTable tbl = OrtakClass.Yardim.GetDataTable(sql);
            string hesapla = "select Stok_Barkod, Hareket_Tipi, Stok_Maliyeti from Stok_Hareketler where İslem_Tarihi BETWEEN @tarih1 AND @tarih2";
            OrtakClass.Yardim.Komut.Parameters.Clear();
            OrtakClass.Yardim.Komut.Parameters.Add("@tarih1", OleDbType.Date).Value = dateTimePicker1.Value.Date;
            OrtakClass.Yardim.Komut.Parameters.Add("@tarih2", OleDbType.Date).Value = dateTimePicker2.Value.Date;
            DataTable tblveriler = OrtakClass.Yardim.GetDataTable(hesapla);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string barkod = tbl.Rows[i]["Stok_Barkod"].ToString();
                for (int j = 0; j < tblveriler.Rows.Count; j++)
                {
                    if (barkod == tblveriler.Rows[j]["Stok_Barkod"].ToString())
                    {
                        if (tblveriler.Rows[j]["Hareket_Tipi"].ToString() == "Girdi")
                        {
                            girdiMaliyet += Convert.ToDouble(tblveriler.Rows[j]["Stok_Maliyeti"].ToString());
                        }
                        else if (tblveriler.Rows[j]["Hareket_Tipi"].ToString() == "Çıktı")
                        {
                            ciktiMaliyet += Convert.ToDouble(tblveriler.Rows[j]["Stok_Maliyeti"].ToString());
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
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void btnPerMaasHesapla_Click(object sender, EventArgs e)
        {
            try
            {
double perMaas = 0;
            string hesapla = "select Personel_Maas from Personeller";
            DataTable tblPerMaas = OrtakClass.Yardim.GetDataTable(hesapla);
            for (int i = 0; i < tblPerMaas.Rows.Count; i++)
            {
                perMaas += Convert.ToDouble(tblPerMaas.Rows[i]["Personel_Maas"].ToString());
            }
            txtPerMaas.Text=perMaas.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkHesapla_Click(object sender, EventArgs e)
        {
            double tutar = 0, gelir = 0, gider = 0;
            if (txtEkHesap.Text != string.Empty && txtEkAciklama.Text != string.Empty)
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        Açıklama.Items.Add(txtEkAciklama.Text + "- Gelir");
                    Hesap.Items.Add(txtEkHesap.Text);
                    gelir = Convert.ToDouble(txtEkHesap.Text);
                    if (txtTutar.Text != string.Empty)
                    {
                        tutar = Convert.ToDouble(txtTutar.Text);
                        tutar += gelir;
                        txtTutar.Text = tutar.ToString(); 
                    }
                    else
                    {
                        tutar += gelir;
                        txtTutar.Text = tutar.ToString();
                    }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButton2.Checked)
                {
                    try
                    {
                        Açıklama.Items.Add(txtEkAciklama.Text + "- Gider");
                    Hesap.Items.Add(txtEkHesap.Text);
                    gider = Convert.ToDouble(txtEkHesap.Text);
                    if (txtTutar.Text != string.Empty)
                    {
                        tutar = Convert.ToDouble(txtTutar.Text);
                        tutar -= gider;
                        txtTutar.Text = tutar.ToString();
                    }
                    else
                    {
                        tutar -= gider;
                        txtTutar.Text = tutar.ToString();
                    }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplamGelir = 0, toplamGider = 0, toplamMaliyet = 0;
            try
            {
                if (txtToplamMaliyet.Text != string.Empty && txtPerMaas.Text != string.Empty)
                {
                    if (txtTutar.Text == string.Empty)
                    {
                        if (Convert.ToDouble(txtToplamMaliyet.Text) > 0)
                        {
                            toplamGelir += Convert.ToDouble(txtToplamMaliyet.Text);
                        }
                        else
                        {
                            toplamGider += Convert.ToDouble(txtToplamMaliyet.Text);
                        }
                        toplamGider -= Convert.ToDouble(txtPerMaas.Text);
                        txtToplamGelir.Text = toplamGelir.ToString();
                        txtToplamGider.Text = toplamGider.ToString();
                        if (Convert.ToDouble(txtToplamGelir.Text) == 0)
                        {
                            txtToplamMaliyet2.Text = toplamGider.ToString(); 
                        }
                        else
                        {
                            toplamMaliyet = toplamGelir + toplamGider;
                            txtToplamMaliyet2.Text = toplamMaliyet.ToString(); 
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(txtToplamMaliyet.Text) > 0)
                        {
                            toplamGelir += Convert.ToDouble(txtToplamMaliyet.Text);
                        }
                        else
                        {
                            toplamGider -= Convert.ToDouble(txtToplamMaliyet.Text);
                        }
                        toplamGider -= Convert.ToDouble(txtPerMaas.Text);
                        if (Convert.ToDouble(txtTutar.Text) > 0)
                        {
                            toplamGelir += Convert.ToDouble(txtTutar.Text);
                        }
                        else
                        {
                            toplamGider += Convert.ToDouble(txtTutar.Text);
                        }
                        txtToplamGelir.Text = toplamGelir.ToString();
                        txtToplamGider.Text = toplamGider.ToString();
                        if (Convert.ToDouble(txtToplamGelir.Text) == 0)
                        {
                            txtToplamMaliyet2.Text = toplamGider.ToString();
                        }
                        else
                        {
                            toplamMaliyet = toplamGelir + toplamGider;
                            txtToplamMaliyet2.Text = toplamMaliyet.ToString();
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
