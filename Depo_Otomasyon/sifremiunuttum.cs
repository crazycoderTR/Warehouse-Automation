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
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        
        private void btnŞifreVer_Click(object sender, EventArgs e)
        {
            if (txtEposta.Text != string.Empty && txtEposta.Text != string.Empty)
            {
                try
                {
                    string sifreVerSql = "select KullaniciSifre,KullaniciEposta from Kullanıcılar where KullaniciAdi=@kullaniciAdi and KullaniciEposta=@kullaniciEposta";
                    OrtakClass.Yardim.Komut.Parameters.Clear();
                    OrtakClass.Yardim.Komut.Parameters.Add("@kullaniciAdi", System.Data.OleDb.OleDbType.VarChar).Value = txtKullanıcıAdi.Text;
                    OrtakClass.Yardim.Komut.Parameters.Add("@kullaniciEposta", System.Data.OleDb.OleDbType.VarChar).Value = txtEposta.Text;
                    DataRow sifre = OrtakClass.Yardim.GetDataRow(sifreVerSql);
                    if (sifre != null)
                    {
                        SmtpClient sc = new SmtpClient();
                        sc.Port = 587;
                        sc.Host = "smtp.gmail.com";
                        sc.EnableSsl = true;
                        

                        sc.Credentials = new NetworkCredential("kilincaslan.software@gmail.com", "softwarekilincaslan");
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("kilincaslan.software@gmail.com", "Mesut KILINCASLAN");
                        mail.To.Add(txtEposta.Text);
                        mail.Subject = "Şifre Gönderme";
                        mail.IsBodyHtml = true;
                        mail.Body = "Şifreniz: " + sifre["KullaniciSifre"].ToString();
                        try
                        {
                            sc.Send(mail);
                            MessageBox.Show("Şifreniz Girmiş Olduğunuz Eposta Hesabınıza Gönderilmiştir!", "Şifre Göderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SmtpException ex)
                        {
                            MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veriler, Girmiş Olduğunuz Veriler Uyuşmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
