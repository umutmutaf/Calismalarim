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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
            LstViewRezervListe.Items.Clear();
            for (int i = 0; i < LstViewRezervListe.Columns.Count; i++)
            {
                LstViewRezervListe.Columns[i].Width = 90;
            }
            
            foreach (var item in VeriTabani.Rezerve)
            {
                string[] row = {item.ID, item.Kullanicilar.Adi + " " +item.Kullanicilar.Soyadi, item.Tarih, item.Saat, item.Saha.SahaAdi, item.Kullanicilar.Telefon };
                var satir = new ListViewItem(row);
                LstViewRezervListe.Items.Add(satir);
            }
            
        }

        private void BtnGirisSayfasi_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
        private void BtnAdminSil_Click(object sender, EventArgs e)
        {
            string id = LstViewRezervListe.Items[LstViewRezervListe.SelectedItems[0].Index].SubItems[0].Text;
            VeriTabani.Rezerve.RemoveAll(x => x.ID == id);
            LstViewRezervListe.Items.RemoveAt(LstViewRezervListe.SelectedItems[0].Index);
        
        }
    }
}
