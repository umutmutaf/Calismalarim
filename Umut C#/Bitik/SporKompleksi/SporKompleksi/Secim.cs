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
    public partial class Secim : Form
    {
        public Secim()
        {
            InitializeComponent();
        }
        private void BtnSecimFutbol_Click(object sender, EventArgs e)
        {
            FutbolSecim fbs = new FutbolSecim();
            fbs.Show();
            this.Hide();
        }
        private void BtnSecimBasketbol_Click(object sender, EventArgs e)
        {
            Basketbol bsk = new Basketbol();
            bsk.Show();
            this.Hide();
        }
        private void BtnSecimVoleybol_Click(object sender, EventArgs e)
        {
            Voleybol vly = new Voleybol();
            vly.Show();
            this.Hide();
        }
        private void BtnSecimMenu_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }
        private void BtnSecimFutbol_MouseHover(object sender, EventArgs e)
        {
           
            BtnSecimFutbol.BackgroundImage = Properties.Resources.futboldegis;
        }
        private void BtnSecimBasketbol_MouseHover(object sender, EventArgs e)
        {
            BtnSecimBasketbol.BackgroundImage = Properties.Resources.basketboldegis;
        }
        private void BtnSecimVoleybol_MouseHover(object sender, EventArgs e)
        {
            BtnSecimVoleybol.BackgroundImage = Properties.Resources.voleyboldegis;
            
        }
        private void BtnSecimFutbol_MouseLeave(object sender, EventArgs e)
        {
            BtnSecimFutbol.BackgroundImage = Properties.Resources.futbol2;
        }
        private void BtnSecimBasketbol_MouseLeave(object sender, EventArgs e)
        {
            BtnSecimBasketbol.BackgroundImage = Properties.Resources.basketbol2;
        }
        private void BtnSecimVoleybol_MouseLeave(object sender, EventArgs e)
        {
            BtnSecimVoleybol.BackgroundImage = Properties.Resources.voleybol2;
        }
    }
}
