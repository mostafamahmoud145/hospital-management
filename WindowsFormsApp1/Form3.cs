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
    public partial class Form3 : Form
    {
        static String sql = "Data Source = DESKTOP-MQVDGJM\\SQLEXPRESS; Initial Catalog = first database;Integrated Security=True ; User Id = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = addpatient();
        }

        public DataTable addpatient()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM patienttt";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
