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
    public partial class Form2 : Form
    {
        static String sql = "Data Source = DESKTOP-MQVDGJM\\SQLEXPRESS; Initial Catalog = first database;Integrated Security=True ; User Id = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public Form2()
        {
            InitializeComponent();
        }

        private void btnaddpatient_Click(object sender, EventArgs e)
        {
            patient m = new patient();
            m.setname(tbname.Text);
            m.setage(tbage.Text);
            m.setgender(comboBox1.Text);
            m.setphone(tbphone.Text);
            m.setaddress(tbaddress.Text);
            m.setblood(tbblood.Text);
            m.setroom(tbroom.Text);
            con.Open();
            string query = "INSERT INTO patienttt (Name,Age,Gender,PhoneNumber,Address,RoomNumber,BloodType)VALUES(@Name, @Age,@Gender,@PhoneNumber,@Address,@RoomNumber,@BloodType)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Name", m.getname());
            cmd.Parameters.AddWithValue("@Age", m.getage());
            cmd.Parameters.AddWithValue("@Gender", m.getgender());
            cmd.Parameters.AddWithValue("@PhoneNumber", m.getphone());
            cmd.Parameters.AddWithValue("@Address", m.getaddress());
            cmd.Parameters.AddWithValue("@BloodType", m.getblood());
            cmd.Parameters.AddWithValue("@RoomNumber", m.getroom());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Patient Saved..");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
