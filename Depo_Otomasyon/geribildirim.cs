using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class;
using System.Net.Mail;
using System.Net;

namespace Depo_Otomasyon
{
    public partial class geribildirim : Form
    {
        public geribildirim()
        {
            InitializeComponent();
        }

        private void txtKullaniciNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string verial = "Select KullaniciAdi, KullaniciEposta from Kullanıcılar where KullaniciNo=@no";
                OrtakClass.Yardim.Komut.Parameters.Clear();
                OrtakClass.Yardim.Komut.Parameters.Add("@no", System.Data.OleDb.OleDbType.VarChar).Value = txtKullaniciNo.Text;
                DataRow kullanici = OrtakClass.Yardim.GetDataRow(verial);
                if (kullanici != null)
                {
                    txtKullanıcıAdi.Text = kullanici["KullaniciAdi"].ToString();
                    txtEposta.Text = kullanici["KullaniciEposta"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != string.Empty)
                    {
                        try
                        {
                            SmtpClient sc = new SmtpClient();
                            sc.Port = 587;
                            sc.Host = "smtp.gmail.com";
                            sc.EnableSsl = true;

                            sc.Credentials = new NetworkCredential(txtEposta.Text, txtSifre.Text);
                            
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress(txtEposta.Text, txtKullanıcıAdi.Text);
                            mail.To.Add("kilincaslan.sofware@gmail.com");
                            mail.Subject = "Geri Bildirim";
                            mail.IsBodyHtml = true;
                            mail.Body = "Kullanıcı No: " + txtKullaniciNo.Text + "Kullanıcı Adı: " + txtKullanıcıAdi.Text + "Bildirim: " + txtBildirm.Text;
                            
                            try
                            {
                                sc.Send(mail);
                                MessageBox.Show("Geri Bildirim Gönderilmiştir", "Bildirim Göderildi", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                            }
                            catch (SmtpException ex)
                            {
                                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi"); break;
                            }
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        }
                    }
                }
            }
        }
        int resimKontrol = 0;
        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (resimKontrol == 0)
            {
                btnPassword.Image = Image.FromFile(Application.StartupPath + @"\Resimler\sifre-goster.png");
                txtSifre.PasswordChar = '\0';
                resimKontrol = 1;
            }
            else
            {
                btnPassword.Image = Image.FromFile(Application.StartupPath + @"\Resimler\sifre-gizle.png");
                txtSifre.PasswordChar = '*';
                resimKontrol = 0;
            }
        }
    }
}
