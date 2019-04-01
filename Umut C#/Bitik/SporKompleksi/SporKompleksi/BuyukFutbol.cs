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
    public partial class BuyukFutbol : Form
    {
        public string tarih;
        public string saat;
        public Button oncekiButon;
        public BuyukFutbol()
        {
            InitializeComponent();
        }    
        private void BtnBuyukFutbolMenu_Click_1(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }

        private void BuyukFutbol_Load(object sender, EventArgs e)
        {
            Giris.paslananDeger = "Büyük Futbol";
            LblBuyukFutbolKullaniciAdi.Text = Giris.Kullanici.Adi;
        }

        private void DateTimePickerBuyukFutbol_ValueChanged(object sender, EventArgs e)
        {
            oncekiButon = null;
            TxtBuyukFutbolTarih.Text = DateTimePickerBuyukFutbol.Value.ToShortDateString();
            string tarih = TxtBuyukFutbolTarih.Text;
            string saat = TxtBuyukFutbolSaat.Text;
            List<Rezervasyon> gelenTarih = VeriTabani.Rezerve.Where(x => x.Tarih == tarih && x.Saha.SahaTuru == SahaTuru.BFutbol).ToList();
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
            TxtBuyukFutbolSaat.Text = simdikiButon.Text;
            simdikiButon.BackColor = Color.Gray;
            simdikiButon.Enabled = false;

            if (oncekiButon != null)
            {
                oncekiButon.BackColor = Color.Lime;
                oncekiButon.Enabled = true;

            }
            oncekiButon = simdikiButon;
        }

        private void BtnBuyukFutbolKaydet_Click(object sender, EventArgs e)
        {
            if (TxtBuyukFutbolSaat.Text.Length == 0 || TxtBuyukFutbolTarih.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Tarih ve Saat Seçiniz");
            }
            else
            {

                Profil prf = new Profil(LblBuyukFutbolKullaniciAdi.Text, TxtBuyukFutbolSaat.Text, TxtBuyukFutbolTarih.Text, CBoxBuyukFutol.Text);
                prf.Show();
                this.Hide();
            }
        }
    }
}
