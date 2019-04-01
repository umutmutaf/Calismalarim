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
    public partial class Kayit : Form
    {
       public Kayit()
        {
            
        }
        private void LinkLblGiriseDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
        private void BtnKayitKaydet_Click(object sender, EventArgs e)
        {
            Kullanicilar user = new Kullanicilar(TxtKayitKullaniciAdi.Text, TxtKayitSifre.Text, "", "", TxtKayitTelNo.Text);
           
            VeriTabani.Kullanıcılar.Add(user);
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
    }
}
