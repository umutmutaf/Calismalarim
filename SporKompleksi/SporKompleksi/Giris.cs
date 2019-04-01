using SporKompleksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporKompleksi
{
    public partial class Giris : Form
    {
        public static string paslananDeger;
    
        public Giris()
        {
            InitializeComponent();
        }
        public static Kullanicilar Kullanici;
        private void BtnGiris_Click(object sender, EventArgs e)
        {           
            var kullaniciAdi = TxtKullaniciAdi.Text;
            var sifre = TxtSifre.Text;
            var sahalar = VeriTabani.Sahalar;
            if (VeriTabani.Kullanıcılar.Exists(x=> x.KullaniciAdi == kullaniciAdi && sifre == x.Sifre) == true)
            {
                Kullanici = VeriTabani.Kullanıcılar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && sifre == x.Sifre);
                if(kullaniciAdi == "admin"&& sifre == "admin")
                {
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    this.Hide();
                }
                else
                {
                     Secim scm = new Secim();
                scm.Show();
                this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adi yada şifre hatalı");
            }         
        }
        private void LinkLblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }
        private void Giris_Load(object sender, EventArgs e)
        {
            TxtKullaniciAdi.Text = "admin";
            TxtSifre.Text = "admin";
            VeriTabani.VeriTabaniniAc();
        }
    }
}
