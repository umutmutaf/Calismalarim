using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.RememberPassword == true)
            {
                TbSifre.Text = Properties.Settings.Default.Password;
            }
        }
        public static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Kullanici;Integrated Security=True");

        public static object KullaniciID;

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.Password = TbSifre.Text;
                Properties.Settings.Default.RememberPassword = true;
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrWhiteSpace(TbKullaniciAdi.Text)==false && string.IsNullOrWhiteSpace(TbSifre.Text)==false)
            {              
                SqlCommand command = new SqlCommand($"Select KullaniciID from KullaniciGiris Where KullaniciAdi = '{TbKullaniciAdi.Text}' and Sifre = '{TbSifre.Text}'", connection);
                connection.Open();
                 KullaniciID=command.ExecuteScalar();
                if (KullaniciID != null)
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
            }          
        }
    }
}
