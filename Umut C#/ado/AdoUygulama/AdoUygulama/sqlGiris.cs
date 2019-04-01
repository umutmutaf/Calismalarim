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
    public partial class sqlGiris : Form
    {
        public sqlGiris()
        {
            InitializeComponent();
        }
        public static SqlConnection connection;

        private void BtConnect_Click(object sender, EventArgs e)
        {
            
            if (CbAuthen.SelectedIndex==0)
            {
                 connection = new SqlConnection($"Server=.;database=master;UID={textBox1.Text};PWD={TxtPassword.Text}");
               
            }
            else 
            {
               
                connection = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=true");
               
            }
            connection.Open();
            listele listele = new listele();
            listele.Show();
            this.Hide();
            

        }
    }
}
