using KitapMagzasiClassLib.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapMagazasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FakeDb.FakeDataOlustur();
            CbKitapTur.DataSource = Enum.GetNames(typeof(KitapTuru));
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            //Kullanici adi ve şifre FakeDB'de var ise mbox'a Hoşgeldin Adi + " " + Soyadi
            //Kullanici adi ve şifre FakeDB'de yok ise mbox'a Ka ve veya Şifre Hatalı
            var kullanici = FakeDb.Kullaniciler.FirstOrDefault(x => x.KullaniciAdi == TbKullaniciAdi.Text && x.Sifre == TbSifre.Text);
            if (kullanici==null)
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı");
            }
            else
            {
                MessageBox.Show("Hoşgeldin "+kullanici.KullaniciAdi+" "+kullanici.Soyadi);
            }
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            //Kullanici adi FakeDB'de var ise mbox'a Şifreyi Yaz
            //Kullanici adi FakeDb'de yok ise mbox'a Böyle Bir Kullanici Yok Yaz
            var kullanici = FakeDb.Kullaniciler.FirstOrDefault(x=> x.KullaniciAdi==TbKullaniciAdi.Text);
            if (kullanici==null)
            {
                MessageBox.Show("Böyle Bir Kullanici Yok");
            }
            else
            {
                MessageBox.Show(kullanici.KullaniciAdi+" Adlı kullanıcının şifresi: "+kullanici.Sifre);
            }
        }

        private void BtnYazarKitapGetir_Click(object sender, EventArgs e)
        {
            // TbYazarAdi'na girilen Yazarın Tüm kitaplarını getir ve LbSonuc'a Kitabın adını ve Fiyatını Yaz
            var kitaplar = FakeDb.Kitaplar.Where(x => x.Yazar.AdiSoyadi==TbYazarAdi.Text).Select(y=> new {y.Adi,y.Fiyat });
            LbSonuc.DataSource = kitaplar.ToList();
           
        }

        private void BtnTumKitapSatisAded_Click(object sender, EventArgs e)
        {
            //Tüm Kitap Türlerinin ayrı ayrı kaç adet sattığını ve KitapTürünü LbSonuc'ta listeleyin
            var kitaplar = FakeDb.Kitaplar.GroupBy
                (
                x => new { x.KitapTuru, x.Adi }, (key, list) =>

                  {
                      return new
                      {
                          KitapAdi = key.Adi,
                          KitapTuru = key.KitapTuru,
                          KitapSatisAdedi = list.Count()
                      };
                  });
                        
                LbSonuc.DataSource = kitaplar.ToList();           
        }

        private void BtnYazarKitapSayfa_Click(object sender, EventArgs e)
        {
            // TbYazarAdi'na girilen Yazarın Tüm kitaplarının ortalama sayfa adedini mbox'a Yazdır
            var sayfaOrtalama = FakeDb.Kitaplar.Where(x => x.Yazar.AdiSoyadi == TbYazarAdi.Text).Average(y => y.SayfaSayisi);
            MessageBox.Show(sayfaOrtalama.ToString());
        }

        private void BtnYazarKitapTur_Click(object sender, EventArgs e)
        {
            // TbYazarAdi'na girilen Yazarın hangi türde kaç adet kitabı olduğunu LbSonuc'ta listeleyin
            var turKitap = FakeDb.Kitaplar.Where(x => x.Yazar.AdiSoyadi == TbYazarAdi.Text).GroupBy
                (
                y => new
                { y.KitapTuru }, (key, list) => 
                {
                    return new
                    {
                        key,
                        KitapTurAded = list.Count()
                    };
                });
            LbSonuc.DataSource = turKitap.ToList();
        }

        private void BtnKitapTurOrtalamaFiyat_Click(object sender, EventArgs e)
        {
            KitapTuru seciliKitapTuru = (KitapTuru)CbKitapTur.SelectedIndex;
            //Secili Kitap Turuna Ait Kitaplarin ortalama fiyatını bulun
            var kitapOrtalama = FakeDb.Kitaplar.Where(x=> x.KitapTuru==seciliKitapTuru).Average(y=> y.Fiyat);
            MessageBox.Show(kitapOrtalama.ToString());
        }

        private void BtnEnPahalıKitap_Click(object sender, EventArgs e)
        {
            // FakeDb'deki En Pahalı Kitabın satis fiyatını ve adını mbox'a yazdırın
            var kitapFiyati = FakeDb.Kitaplar.Max(x=>x.Fiyat);
            var kitapAdi = FakeDb.Kitaplar.FirstOrDefault(y=>y.Fiyat == kitapFiyati).Adi;
            MessageBox.Show(kitapAdi+" "+kitapFiyati);
        }

        private void BtnFiyatOrtalamaFazla_Click(object sender, EventArgs e)
        {
            // FakeDb'deki Fiyatı Ortalama Kitap Fiyatından Fazla olan Kitapları LbSonuc'ta listeleyin
            var kitapFiyatiOrtalama = FakeDb.Kitaplar.Average(x => x.Fiyat);
            var kitapFiyat = FakeDb.Kitaplar.Where(y => y.Fiyat > kitapFiyatiOrtalama).Select(z=> z.Adi);
            LbSonuc.DataSource = kitapFiyat.ToList();
        }

        private void TbFiyatAralık_Click(object sender, EventArgs e)
        {
            // FakeDb'deki Fiyatı TbMin ile TbMax arasında olan Kitapları Fiyata göre azalan şekilde
            // LbSonuc'ta listeleyin
            var kitapSiralama = FakeDb.Kitaplar.Where(x=> x.Fiyat>Convert.ToDouble(TbMin.Text)&&x.Fiyat<Convert.ToDouble(TbMax.Text)).Select(y=>new { y.Adi,y.Fiyat });
            LbSonuc.DataSource = kitapSiralama.OrderByDescending(x => x.Fiyat).ToList();
           
        }

        private void BtnKısadanUzuna_Click(object sender, EventArgs e)
        {
            //Kitapları sayfa sayısına göre kısadan uzuna sıralayın,
            //kitapların isimlerini ve satış fiyatlarını LbSonuc'ta listeleyin
            var sayfaSiralama = FakeDb.Kitaplar.OrderBy(x=> x.SayfaSayisi).Select(y=> new {y.Adi,y.Fiyat,y.SayfaSayisi});
            LbSonuc.DataSource = sayfaSiralama.ToList();
        }

        private void BtnYılSatis_Click(object sender, EventArgs e)
        {
            // Her Yıl kaç adet kitap satıldığını ve bu kitaplardan elde edilen geliri LbSonuc'ta listeleyin
            var satilanKitaplar = FakeDb.Satislar.GroupBy(x => new { x.SatisTarihi.Year }, (key, list)
                   =>
            { return new { satilanTarih = key, kitapAdedi = list.Count() }; });

            LbSonuc.DataSource = satilanKitaplar.ToList();
        }
        private void BtnKinKacKitap_Click(object sender, EventArgs e)
        {
            //Tüm kullanıcıların kaç kitap aldığını LbSonuc'ta listeleyin (KullanıcıAdi, KitapSayisi)
            var alinanKitap = FakeDb.Satislar.GroupBy
                (
                x=> new { x.SatinAlanKullanici.KullaniciAdi,x.AlınanKitap},
                (key,list)=>
                {
                    return new
                    {
                        satinAlanlar=key.KullaniciAdi,
                        alinanKitaplar=list.Count()
                    };
                });
            LbSonuc.DataSource = alinanKitap.ToList();
        }

        private void BtnAralikTurKitap_Click(object sender, EventArgs e)
        {
            KitapTuru seciliKitapTuru = (KitapTuru)CbKitapTur.SelectedIndex;
            //Girilen seciliKitapTurun'deki (en ucuz) kitabın adi ve Yazarının adini mbox ile ekrana yazın
            var ucuzKitap = FakeDb.Kitaplar.Where(y => y.KitapTuru == seciliKitapTuru).Min(x=> x.Fiyat);
            var yazarAdi = FakeDb.Kitaplar.FirstOrDefault(z=> z.Fiyat==ucuzKitap).Adi;
            
                MessageBox.Show(ucuzKitap.ToString()+yazarAdi);

        }

            private void BtnKitapHediye_Click(object sender, EventArgs e)
        {
            //Tüm kullanıcıların  kaç tane hediye kitap aldığını LbSonuc'ta listeleyin (KullanıcıAdi, HediyeKitapSayisi)
        }

        private void BtnKitapHediyeMi_Click(object sender, EventArgs e)
        {
            //TbKitapAdi'na adı girilen kitabın hediye edilip edilmediğini mbox  ile ekrana yazın

        }

        private void BtnKitapHediyeEdilmeSayisi_Click(object sender, EventArgs e)
        {
            // TbKitapAdi'na adı girilen kitabın kaç adet hediye edildiğini mbox ile ekrana yazın
        }

        private void BtnYayinEviYazar_Click(object sender, EventArgs e)
        {
            //Hangi yayınevi hangi yazar'ın kaç adet kitabını başmıs LbSonuc'ta listeleyin (YayınEviAdı, YazarAdı, KitapAdedi)
        }

        private void BtnYazarKitapİlk_Click(object sender, EventArgs e)
        {
            //TbYazarAdi'na girilen Yazarın ilk basılan kitabının adını ve Basım tarihini mbox ile ekrana yazın
        }

        private void BtnYayinEviFiyat_Click(object sender, EventArgs e)
        {
            //Tüm Yayınevlerinin Toplam Sattığı kitap adedini ve Kaç adet kitap sattığını LbSonuc'ta listeleyin
        }
    }
}
