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
    public partial class Form4 : Form
    {
        static String sql = "Data Source = DESKTOP-MQVDGJM\\SQLEXPRESS; Initial Catalog = first database;Integrated Security=True ; User Id = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public Form4()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            employee p = new employee();
            p.setname(tbname2.Text);
            p.setage(tbage2.Text);
            p.setgender(comboBox1.Text);
            p.setphone(tbphone2.Text);
            p.setaddress(tbaddress2.Text);
            p.setsalary(tbsalary.Text);
            p.setfrom(tbtime1.Text);
            p.setto(tbtime2.Text);
            p.setdeprtment(tbdepartment.Text);
            con.Open();
            string query = "INSERT INTO employ (Name,Age,Gender,PhoneNumber,Address,Salary,Start,Finish,Department)VALUES(@Name,@Age,@Gender,@PhoneNumber,@Address,@Salary,@Start,@Finish,@Department)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", p.getname());
            cmd.Parameters.AddWithValue("@Age", p.getage());
            cmd.Parameters.AddWithValue("@Gender", p.getgender());
            cmd.Parameters.AddWithValue("@PhoneNumber", p.getphone());
            cmd.Parameters.AddWithValue("@Address", p.getaddress());
            cmd.Parameters.AddWithValue("@Salary", p.getsalary());
            cmd.Parameters.AddWithValue("@Start", p.getfrom());
            cmd.Parameters.AddWithValue("@Finish", p.getto());
            cmd.Parameters.AddWithValue("@Department", p.getdepartment());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee Saved..");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
