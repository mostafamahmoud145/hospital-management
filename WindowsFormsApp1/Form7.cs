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
namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {

        static String sql = "Data Source = DESKTOP-MQVDGJM\\SQLEXPRESS; Initial Catalog = first database;Integrated Security=True ; User Id = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = removeemployee();
        }

        public DataTable removeemployee()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM employ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM employ WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = removeemployee();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM employ WHERE Name LIKE'%" + textBox1.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
