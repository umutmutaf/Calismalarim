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
    public partial class KucukFutbol : Form
    {
        public string tarih;
        public string saat;
        public Button oncekiButon;
        public KucukFutbol()
        {
            InitializeComponent();
        }
        private void KucukFutbol_Load(object sender, EventArgs e)
        {
            Giris.paslananDeger = "Küçük Futbol";
            LblKucukFutbolKullaniciAdi.Text = Giris.Kullanici.Adi;
        }

        private void DateTimePickerKucukFutbol_ValueChanged(object sender, EventArgs e)
        {
            oncekiButon = null;
            TxtKucukFutbolTarih.Text = DateTimePickerKucukFutbol.Value.ToShortDateString();
            string tarih = TxtKucukFutbolTarih.Text;
            string saat = TxtKucukFutbolSaat.Text;
            List<Rezervasyon> gelenTarih = VeriTabani.Rezerve.Where(x => x.Tarih == tarih && x.Saha.SahaTuru == SahaTuru.KFutbol).ToList();
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

        private void button_Click(object sender, EventArgs e)
        {
            var simdikiButon = (sender as Button);
            TxtKucukFutbolSaat.Text = simdikiButon.Text;
            simdikiButon.BackColor = Color.Gray;
            simdikiButon.Enabled = false;

            if (oncekiButon != null)
            {
                oncekiButon.BackColor = Color.Lime;
                oncekiButon.Enabled = true;

            }
            oncekiButon = simdikiButon;
        }

        private void BtnKucukFutbolKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKucukFutbolSaat.Text.Length == 0 || TxtKucukFutbolTarih.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Tarih ve Saat Seçiniz");
            }
            else
            {

                Profil prf = new Profil(LblKucukFutbolKullaniciAdi.Text, TxtKucukFutbolSaat.Text, TxtKucukFutbolTarih.Text, CBoxKucukFutbol.Text);
                prf.Show();
                this.Hide();
            }
        }

        private void BtnKucukFutbolMenu_Click_1(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }
    }
}
