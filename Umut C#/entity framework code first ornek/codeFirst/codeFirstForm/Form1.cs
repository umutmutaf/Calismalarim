using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codeFirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kisi _kisi = new Kisi();
        private void BtnKisiEkle_Click(object sender, EventArgs e)
        {
            
            _kisi.Kullanicis.Add(new Kullanici
            {
                KullaniciAdi=TbEkleAdi.Text,
                KullaniciSoyadi=TbEkleSoyadi.Text,
                DogumTarihi=DateTime.Now
            });
            _kisi.SaveChanges();
            listView1.Items.Add(Convert.ToString(_kisi));
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            var kullanicis = _kisi.Kullanicis.Where(x => x.KullaniciAdi == TbSilAdi.Text&&x.KullaniciSoyadi==TbSilSoyadi.Text);
            _kisi.Kullanicis.RemoveRange(kullanicis);
            _kisi.SaveChanges();
        }

        private void BtnBilgiEkle_Click(object sender, EventArgs e)
        {
            var kullanici = _kisi.Kullanicis.FirstOrDefault(x => x.KullaniciAdi == TbBilgiAdi.Text && x.KullaniciSoyadi == TbBilgiSoyadi.Text);
            if (kullanici == null)
            {
                MessageBox.Show("Var olmayan kullanıcıya bilgi eklenemez");
            }
            else
            {
                _kisi.KullaniciBilgileris.Add(new KullaniciBilgileri
                {
                    Adi = TbBilgiAdi.Text,
                    Soyadi = TbBilgiSoyadi.Text,
                    Hobiler = TbBilgiAdi.Text,
                    TelefonNo = TbBilgiTel.Text
                });
            }
            _kisi.SaveChanges();
        }
        
        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = _kisi.KullaniciBilgileris.FirstOrDefault(x=> x.KullaniciBilgileriID==1);          
                guncelle.Adi = TbGuncelleAdi.Text;
                guncelle.Soyadi = TbGuncelleSoyadi.Text;
                guncelle.Hobiler = TbGuncelleHobi.Text;
                guncelle.TelefonNo = TbGuncelleTel.Text;
                _kisi.SaveChanges();
            
           
        }
    }
}
