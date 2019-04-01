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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            Yenile();
        }
        private void Yenile()
        {
            string komutStr = "Select GunlukID,Icerik from Gunluk where KullaniciID=" + Form1.KullaniciID + "";
            SqlCommand komut = new SqlCommand(komutStr, Form1.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seciliRow = dataGridView1.SelectedCells[0].RowIndex;
            var seciliId = dataGridView1.Rows[seciliRow].Cells["GunlukID"].Value;
            string komutStr = "Select Icerik from Gunluk where GunlukID=" + seciliId + "";
            SqlCommand komut = new SqlCommand(komutStr, Form1.connection);
            var text = komut.ExecuteScalar();
            MessageBox.Show(text.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Gunluk(Icerik,KullaniciID) values('" + textBox1.Text + "','"+Form1.KullaniciID+"')", Form1.connection);
            komut.ExecuteNonQuery();
            Yenile();
        }
    }
}
