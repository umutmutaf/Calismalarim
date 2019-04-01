using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            FakeDB.VerileriDoldur();
            InitializeComponent();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            // Kullanıcı adi Daha önce alnmış olmamalı
            var Kullanici = FakeDB.Kullanicilar.Any(x => x.KullaniciAdi == TbKullaniciAdi.Text);
            if (Kullanici==true)
            {
                MessageBox.Show("Bu kullanıcı adı zaten var");
            }
            else
            {
                MessageBox.Show("Kayıt başarılı");
            }          
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //Kullanici Adi ve Şifre FakeDB'dekilerle uyuşuyor mu?
            var Kullanici = FakeDB.Kullanicilar.Any(x => x.KullaniciAdi == TbKullaniciAdi.Text && x.Sifre==TbSifre.Text);
           
        }

        private void BtnBireyselSatis_Click(object sender, EventArgs e)
        {
            //LbSatis'e bireysel Kullanicilar tarafindan alınan ürünler
            // AlanKişinin Kullanici Adi Urunun Adi ve Fiyati
            var alinanUrun = FakeDB.Satislar.Where(x => x.AlanKisi.KullaniciTipi == KullaniciTipi.Bireysel)
                                            .Select(y => new { y.AlanKisi.KullaniciAdi, y.SatilanUrun.UrunAdi, y.SatilanUrun.SatisFiyati });

            LbSatis.DataSource = alinanUrun.ToList();
        }

        private void BtnKurumsalSatis_Click(object sender, EventArgs e)
        {
            //LbSatis'e Kurumsal Kullanicilar tarafindan alınan ürünler
            // AlanKişinin Kullanici Adi Urunun Adi ve Fiyati
            var alinanUrun = FakeDB.Satislar.Where(x => x.AlanKisi.KullaniciTipi == KullaniciTipi.Kurumsal)
                                            .Select(y => new { y.AlanKisi.KullaniciAdi, y.SatilanUrun.UrunAdi, y.SatilanUrun.SatisFiyati });

            LbSatis.DataSource = alinanUrun.ToList();
        }

        private void BtnSatisTarihiGecmis_Click(object sender, EventArgs e)
        {
            // LBSatisTarih'e Satilirken SKT'si geçmiş olan ürünleri Listele
            // AlanKişinin Kullanici Adi Urunun Adi ve Fiyati
            var sonKullanmaTarihi = FakeDB.Satislar.Where(x => x.SatilanUrun.SonKullanmaTarihi<x.SatisTarihi)
                                            .Select(y => new { y.AlanKisi.KullaniciAdi, y.SatilanUrun.UrunAdi, y.SatilanUrun.SatisFiyati });

            LbSatisTarih.DataSource = sonKullanmaTarihi.ToList();

        }

        private void BtnTarihiGecmis_Click(object sender, EventArgs e)
        {
            // LBSatisTarih'e  SKT'si geçmiş olan ürünleri Listele
            // Urunun Adi ve Fiyati

            //var sonKullanmaTarihi = FakeDB.Urunler.Where(x => x.SonKullanmaTarihi < DateTime.Now)
            //                                .Select(y => new { y.UrunAdi, y.SatisFiyati });

            var sonKullanmaTarihi = FakeDB.Urunler.Count(x => x.SonKullanmaTarihi < DateTime.Now);
            MessageBox.Show(sonKullanmaTarihi.ToString());

            //LbSatisTarih.DataSource = sonKullanmaTarihi.ToList();

        }

        private void BtnFiyatiDusuk_Click(object sender, EventArgs e)
        {
            //Fiyati TbFiyattan düşük olan ürün Var mı ? 
            // Var ise Bu ürünleri LbFiyata yazalım
            // Urunun Adi ve Fiyati
            var urunFiyatVarMi = FakeDB.Urunler.Any(x => x.SatisFiyati < Convert.ToDouble(TbFiyat.Text));
           
            if (urunFiyatVarMi==true)
            {
                var urunFiyat = FakeDB.Urunler.Where(x => x.SatisFiyati < Convert.ToDouble(TbFiyat.Text)).Select(y => new { y.UrunAdi, y.SatisFiyati });
                LbFiyat.DataSource = urunFiyat.ToList();
            } 
            else
            {
                MessageBox.Show("Böyle bir ürün yok");
            }
        }

        private void BtnFiyatiYuksek_Click(object sender, EventArgs e)
        {
            //Fiyati TbFiyattan Yüksek olan ürün Var mı ? 
            // Var ise Bu ürünleri LbFiyata yazalım
            // Urunun Adi ve Fiyati
            var urunFiyatVarMi = FakeDB.Urunler.Any(x => x.SatisFiyati > Convert.ToDouble(TbFiyat.Text));

            if (urunFiyatVarMi == true)
            {
                var urunFiyat = FakeDB.Urunler.Where(x => x.SatisFiyati > Convert.ToDouble(TbFiyat.Text)).Select(y => new { y.UrunAdi, y.SatisFiyati });
                LbFiyat.DataSource = urunFiyat.ToList();
            }
            else
            {
                MessageBox.Show("Böyle bir ürün yok");
            }
        }

        private void BtnBireyselSatisAdedi_Click(object sender, EventArgs e)
        {
            var BireyseSatisAdedi = FakeDB.Satislar.Count(x => x.AlanKisi.KullaniciTipi == KullaniciTipi.Bireysel);
            MessageBox.Show(BireyseSatisAdedi.ToString());
        }

        private void BtnKurumsalSatisAdedi_Click(object sender, EventArgs e)
        {
            var KurumsalSatisAdedi = FakeDB.Satislar.Count(x=> x.AlanKisi.KullaniciTipi==KullaniciTipi.Kurumsal);
            MessageBox.Show(KurumsalSatisAdedi.ToString());
        }

        private void BtnTumSatislardanKazanilan_Click(object sender, EventArgs e)
        {
            var TumundanKazanilan = FakeDB.Satislar.Sum(x=> x.SatilanUrun.SatisFiyati*x.Adet);
            MessageBox.Show(TumundanKazanilan.ToString());

        }

        private void BtnBireyselCiro_Click(object sender, EventArgs e)
        {
            var BireyselCiro = FakeDB.Satislar.Where(x => x.AlanKisi.KullaniciTipi==KullaniciTipi.Bireysel).Sum(x => x.SatilanUrun.SatisFiyati * x.Adet);
            MessageBox.Show(BireyselCiro.ToString());
        }

        private void BtnKurumsalCiro_Click(object sender, EventArgs e)
        {
            var KurumsalCiro = FakeDB.Satislar.Where(x => x.AlanKisi.KullaniciTipi == KullaniciTipi.Kurumsal).Sum(x => x.SatilanUrun.SatisFiyati * x.Adet);
            MessageBox.Show(KurumsalCiro.ToString());
        }

        private void BtnOrtalamaSatisFiyati_Click(object sender, EventArgs e)
        {
            var OrtalamaSatisFiyati = FakeDB.Satislar.Average(x => x.SatilanUrun.SatisFiyati);
            MessageBox.Show(OrtalamaSatisFiyati.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var gruplu = FakeDB.Satislar.GroupBy(x => x.AlanKisi.KullaniciTipi, (key, list) =>
            //  {
            //      return new
            //      {
            //          KullaniciTip=key,
            //          KullaniciTuruSatisAdedi = list.Count()
            //      };
            //  });
            //foreach (var item in gruplu)
            //{
            //    MessageBox.Show(item.key + " " + item.KullaniciTuruSatisAdedi);
            //}

            var gruplu = FakeDB.Satislar.GroupBy

                (
                x => new { x.SatilanUrun.UrunTuru, x.AlanKisi.KullaniciTipi }, (key, list)=>

                {
                    return new
                    {
                        KullaniciTip =key.KullaniciTipi,
                        UrunTur=key.UrunTuru,
                        KullaniciTuruSatisAdedi=list.Count(),
                        KullaniciTuru=list
                        
                    };
                });
            foreach (var item in gruplu)
            {
                MessageBox.Show(item.UrunTur+" "+item.KullaniciTip+" "+item.KullaniciTuruSatisAdedi);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var urun = FakeDB.Urunler.FirstOrDefault(x => x.SatisFiyati == Convert.ToDouble(TbFiyat.Text));
          
            MessageBox.Show(urun.ToString());
        }
    }
}
