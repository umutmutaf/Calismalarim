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
    public partial class Profil : Form
    {
        public Profil(string adi,string tarih,string saat,string saha)
        {
            InitializeComponent();
            label2.Text = adi;
            label6.Text = saat;
            label7.Text = tarih;
            label9.Text = saha;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris.paslananDeger=="Basketbol")
            {
                Basketbol bsk = new Basketbol();
                bsk.Show();
                this.Close();
            }
            else if (Giris.paslananDeger == "Voleybol")
            {
                Voleybol bsk = new Voleybol();
                bsk.Show();
                this.Close();
            }
            else if (Giris.paslananDeger == "Büyük Futbol")
            {
                BuyukFutbol bsk = new BuyukFutbol();
                bsk.Show();
                this.Close();
            }
            else if (Giris.paslananDeger == "Küçük Futbol")
            {
                KucukFutbol bsk = new KucukFutbol();
                bsk.Show();
                this.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var Saha = VeriTabani.Sahalar;
            if (Giris.paslananDeger == "Basketbol")
            {
                VeriTabani.Rezerve.Add(new Rezervasyon(Giris.Kullanici, Saha[0], label6.Text, label7.Text));
            }
            else if (Giris.paslananDeger == "Voleybol")
            {
                VeriTabani.Rezerve.Add(new Rezervasyon(Giris.Kullanici, Saha[3], label6.Text, label7.Text));
            }
            else if (Giris.paslananDeger == "Büyük Futbol")
            { 
                VeriTabani.Rezerve.Add(new Rezervasyon(Giris.Kullanici, Saha[1], label6.Text, label7.Text));
            }
            else if (Giris.paslananDeger == "Küçük Futbol")
            {
                VeriTabani.Rezerve.Add(new Rezervasyon(Giris.Kullanici, Saha[2], label6.Text, label7.Text));
            }
            SonKisim sk = new SonKisim(label2.Text,label7.Text,label6.Text);
            sk.Show();
            this.Hide();
        }
    }
}
