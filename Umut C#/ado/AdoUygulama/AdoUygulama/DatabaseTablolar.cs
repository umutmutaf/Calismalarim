using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoUygulama
{
    public partial class DatabaseTablolar : Form
    {
        public DatabaseTablolar()
        {
            InitializeComponent();
        }
        public static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Kullanici;Integrated Security=True");

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var seciliDatabase = comboBox1.SelectedValue;
            string komutStr = $"select TABLE_NAME from {seciliDatabase},INFORMATION_SHEMA.TABLES";
           
        }
    }
}
