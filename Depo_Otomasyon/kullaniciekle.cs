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
    public partial class kullaniciekle : Form
    {
        public kullaniciekle()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != string.Empty && txtEposta.Text != string.Empty && txtSifre.Text != string.Empty && txtSifreTekrar.Text != string.Empty)
            {
                try
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        string kullaniciEkle = "insert into Kullanıcılar (KullaniciAdi, KullaniciSifre, KullaniciEposta, KullaniciTur)values (@ad, @sifre, @eposta, @tur)";
                        OrtakClass.Yardim.Komut.Parameters.Clear();
                        OrtakClass.Yardim.Komut.Parameters.Add("@ad", System.Data.OleDb.OleDbType.VarChar).Value = txtAd.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@sifre", System.Data.OleDb.OleDbType.VarChar).Value = txtSifre.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@eposta", System.Data.OleDb.OleDbType.VarChar).Value = txtEposta.Text;
                        OrtakClass.Yardim.Komut.Parameters.Add("@tur", System.Data.OleDb.OleDbType.Single).Value = cmbTur.SelectedIndex;
                        OrtakClass.Yardim.Komutisle(kullaniciEkle);
                        mailGonder();
                        MessageBox.Show("Kullanıcı Eklendi", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    }
                    else
                    {
                        MessageBox.Show("Şifre Tekrar Alanı İle Şifreniz Aynı Değildir !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void mailGonder()
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                sc.Credentials = new NetworkCredential("kilincaslan.software@gmail.com", "softwarekilincaslan");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("kilincaslan.software@gmail.com", "Mesut KILINCASLAN");
                mail.To.Add(txtEposta.Text);
                mail.Subject = "Hoşgeldiniz";
                mail.IsBodyHtml = true;
                mail.Body = "Depo Otomasyonuna Hoşgeldiniz. Sizi aramızda görmekten mutluluk duyuyoruz. Kullanımlarınızda kolaylıklar dileriz. Herhangi bir durumda bizimle iletişime geçmekten çekinmeyiniz :)))";
                sc.Send(mail);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message, "Mail Gönderme Hatası");
            }
        }
    }
}
