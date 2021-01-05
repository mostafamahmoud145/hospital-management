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
    public partial class Form5 : Form
    {

        static String sql = "Data Source = DESKTOP-MQVDGJM\\SQLEXPRESS; Initial Catalog = first database;Integrated Security=True ; User Id = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public DataTable addemployee()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = addemployee();
        }
    }
}
