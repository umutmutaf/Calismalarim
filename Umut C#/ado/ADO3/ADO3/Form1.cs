using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO3
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dataReader;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;database=NORTHWND;UID=ayvansaray;PWD=123456");
            con.Open();
            Yenile();
        }
        //ctrl+. hızlı metod oluşturma
        private void button2_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            DataTable dtb = new DataTable();
            adapt = new SqlDataAdapter("select * from Categories", con);
            adapt.Fill(dtb);
            dataGridView1.DataSource = dtb;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Categories(CategoryName,Description) values('"+textBox1.Text+"','"+textBox2.Text+"')", con);
            komut.ExecuteNonQuery();
            Yenile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //seçilmiş olan satırın ıcınden istenılen alanı getiren yapı
            int seciliRow = dataGridView1.SelectedCells[0].RowIndex;
            var seciliId = dataGridView1.Rows[seciliRow].Cells["CategoryID"].Value;
            //sql kodu
            string komustr = "update Categories set CategoryName='" + textBox1.Text + "',Description='" + textBox2.Text + "'where CategoryID = '" + seciliId + "'";

            SqlCommand komut = new SqlCommand(komustr,con);

            komut.ExecuteNonQuery();
            Yenile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int seciliRow = dataGridView1.SelectedCells[0].RowIndex;
            var seciliId = dataGridView1.Rows[seciliRow].Cells["CategoryID"].Value;
            string komutStr = "delete from Categories where CategoryID=" + seciliId + "";
            SqlCommand komut = new SqlCommand(komutStr, con);
            int affectedRowCount = komut.ExecuteNonQuery();
            MessageBox.Show(affectedRowCount+ " Rows affected");
            Yenile();
        }
        
    }
}
