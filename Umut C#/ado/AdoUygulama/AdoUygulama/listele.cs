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
    public partial class listele : Form
    {
        public listele()
        {
                InitializeComponent();
                string komutStr = "Select name from sys.databases ";
                SqlCommand komut = new SqlCommand(komutStr, sqlGiris.connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seciliDatabase = comboBox1.SelectedValue;
            string komutStr = $"Select TABLE_NAME from {seciliDatabase}.INFORMATION_SCHEMA.TABLES ";
            SqlCommand komut = new SqlCommand(komutStr, sqlGiris.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "TABLE_NAME";
            listBox1.ValueMember = "TABLE_NAME";
        }
    }
}
