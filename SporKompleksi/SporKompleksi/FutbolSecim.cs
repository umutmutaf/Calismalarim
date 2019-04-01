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
    public partial class FutbolSecim : Form
    {
      
        public FutbolSecim()
        {
            InitializeComponent();
        }
        private void BtnBuyukFutbolSecim_Click(object sender, EventArgs e)
        {
            BuyukFutbol bfb = new BuyukFutbol();
            bfb.Show();
            this.Hide();
        }
        private void BtnKucukFutbolSecim_Click(object sender, EventArgs e)
        {
            KucukFutbol kfb = new KucukFutbol();
            kfb.Show();
            this.Hide();
        }
        private void BtnFutbolSecimMenu_Click(object sender, EventArgs e)
        {
            Secim scm = new Secim();
            scm.Show();
            this.Hide();
        }
    }
}
