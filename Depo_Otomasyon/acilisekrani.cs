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
    public partial class acilisekrani : Form
    {
        public acilisekrani()
        {
            InitializeComponent();
        }

        private void AcilisEkran_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            pcbLogo.BackColor = Color.Transparent;
        }

        private void AcilisTimer_Tick(object sender, EventArgs e)
        {
            if (pgbAcilis.Value < 100)
            {
                pgbAcilis.Value += 25;
            }
            else if (pgbAcilis.Value == 100)
            {
                girispaneli frmGirisPaneli = new girispaneli();
                frmGirisPaneli.Show();
                this.Hide();
                AcilisTimer.Enabled = false;
            }
        }

    }
}
