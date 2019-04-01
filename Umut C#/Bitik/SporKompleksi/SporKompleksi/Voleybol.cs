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
    public partial class Voleybol : Form
    {
        public string tarih;
        public string saat;
        public Button oncekiButon;

        public Voleybol()
        {
            InitializeComponent();
        }

        private void BtnVoleybolMenu_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();

            
        }

        private void Voleybol_Load(object sender, EventArgs e)
        {
            Giris.paslananDeger = "Voleybol";
            LblKullaniciAdi.Text = Giris.Kullanici.Adi;
        }

        private void DateTimePickerVoleybol_ValueChanged(object sender, EventArgs e)
        {
            oncekiButon = null;
            TxtVoleybolTarih.Text = DateTimePickerVoleybol.Value.ToShortDateString();
            string tarih = TxtVoleybolTarih.Text;
            string saat = TxtVoleybolSaat.Text;
            List<Rezervasyon> gelenTarih = VeriTabani.Rezerve.Where(x => x.Tarih == tarih && x.Saha.SahaTuru == SahaTuru.Voleybol).ToList();
            List<string> gelenSaat = gelenTarih.Select(x => x.Saat).ToList();

            foreach (var item in panel1.Controls)
            {
                if (item is Button gelenButton)
                {
                    if (gelenSaat.IndexOf(gelenButton.Text) != -1)
                    {
                        gelenButton.BackColor = Color.Red;
                        gelenButton.Enabled = false;
                    }
                    else
                    {
                        gelenButton.BackColor = Color.Lime;
                        gelenButton.Enabled = true;
                    }
                }
            }
        }

        private void BtnVolaybolMenu_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var simdikiButon = (sender as Button);
            TxtVoleybolSaat.Text = simdikiButon.Text;
            simdikiButon.BackColor = Color.Gray;
            simdikiButon.Enabled = false;

            if (oncekiButon != null)
            {
                oncekiButon.BackColor = Color.Lime;
                oncekiButon.Enabled = true;

            }
            oncekiButon = simdikiButon;
        }

        private void BtnVoleybolKaydet_Click(object sender, EventArgs e)
        {
            if (TxtVoleybolSaat.Text.Length == 0 || TxtVoleybolTarih.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Tarih ve Saat Seçiniz");
            }
            else
            {
                
                Profil prf = new Profil(LblKullaniciAdi.Text, TxtVoleybolSaat.Text, TxtVoleybolTarih.Text, CBoxVoleybol.Text);
                prf.Show();
                this.Hide();
            }
        }
    }
}
