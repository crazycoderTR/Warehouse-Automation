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
    public partial class olculer : Form
    {
        public olculer()
        {
            InitializeComponent();
        }

        private void btnOlcuEkle_Click(object sender, EventArgs e)
        {
            if (txtOlcu.Text != string.Empty)
            {
                try
                {
                    string olcuEkleSql = "insert into Olculer (Olcu_Adi) values (@olcuAdi)";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@olcuAdi", OleDbType.VarChar).Value = txtOlcu.Text;
                    //***
                    OrtakClass.Yardim.Komutisle(olcuEkleSql);
                    MessageBox.Show("Ölçü Eklendi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Olmayacak Şekilde Devam Ediniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void txtOlcu_TextChanged(object sender, EventArgs e)
        {
            txtOlcu.Text = txtOlcu.Text.ToUpper();
            txtOlcu.SelectionStart = txtOlcu.Text.Length;
        }

    }
}
