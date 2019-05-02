using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Depo_Otomasyon
{
    public partial class yonetimpaneli : Form
    {
        public yonetimpaneli()
        {
            InitializeComponent();
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            kullaniciekle frmKullaniciEkle = new kullaniciekle();
            frmKullaniciEkle.Show();
        }

        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            kullaniciler frmKullaniciler = new kullaniciler();
            frmKullaniciler.Show();
        }

        private void btnGeriBildirm_Click(object sender, EventArgs e)
        {
            geribildirim frmGeriBildirim = new geribildirim();
            frmGeriBildirim.Show();
        }
    }
}
