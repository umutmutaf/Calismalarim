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
    public partial class SonKisim : Form
    {
        public SonKisim(string adi,string tarih,string saat)
        {
            InitializeComponent();
            LblAdSoyad.Text = adi;
            LblMacSaati.Text = tarih;
            LblMacGunu.Text = saat;
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnYeniRezerve_Click(object sender, EventArgs e)
        {
            Secim bsk = new Secim();
            bsk.Show();
            this.Hide();
        }
    }
}
