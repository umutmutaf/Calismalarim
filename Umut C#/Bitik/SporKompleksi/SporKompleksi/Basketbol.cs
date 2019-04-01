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
    public partial class Basketbol : Form
    {
        
        public string tarih;
        public string saat;
        public Button oncekiButon;      

        public Basketbol()
        {
            InitializeComponent();
        }
        private void DateTimePickerBasketbol_ValueChanged(object sender, EventArgs e)
        {
            oncekiButon = null;
            TxtBasketbolTarih.Text = DateTimePickerBasketbol.Value.ToShortDateString();
            string tarih=TxtBasketbolTarih.Text;
            string saat=TxtBasketbolSaat.Text;
            List<Rezervasyon> gelenTarih = VeriTabani.Rezerve.Where(x => x.Tarih == tarih && x.Saha.SahaTuru==SahaTuru.Basketbol).ToList();
            List<string> gelenSaat = gelenTarih.Select(x => x.Saat).ToList();

            foreach (var item in panel1.Controls)
            {
                if (item is Button gelenButton)
                {
                    if(gelenSaat.IndexOf(gelenButton.Text)!=-1)
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
        private void BtnBasketbolMenu_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }
        private void button_Click(object sender, EventArgs e)
        {
            var simdikiButon = (sender as Button);
            TxtBasketbolSaat.Text = simdikiButon.Text;
            simdikiButon.BackColor = Color.Gray; 
            simdikiButon.Enabled = false;

            if(oncekiButon!=null)
            {
                oncekiButon.BackColor = Color.Lime;
                oncekiButon.Enabled = true;               
            }
            oncekiButon = simdikiButon;
        }
        private void Basketbol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Basketbol_Load(object sender, EventArgs e)
        {
         Giris.paslananDeger = "Basketbol";
        LblBasketbolKullaniciAdi.Text = Giris.Kullanici.KullaniciAdi;
        }
        private void BtnKaydetBasketbol_Click_1(object sender, EventArgs e)
        {
            if (TxtBasketbolSaat.Text.Length==0 || TxtBasketbolTarih.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Tarih ve Saat Seçiniz");
            }
            else
            { 
            Profil prf = new Profil(LblBasketbolKullaniciAdi.Text,TxtBasketbolSaat.Text,TxtBasketbolTarih.Text,CBoxBasketbol.Text);
            prf.Show();
            this.Hide();
            }
        }
    }
}
