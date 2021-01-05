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
    public partial class Form8 : Form
    {
        static String sql = "Data Source = DESKTOP-MQVDGJM\\SQLEXPRESS; Initial Catalog = first database;Integrated Security=True ; User Id = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public Form8()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            employee p = new employee();
            p.setname(nametb.Text);
            p.setage(agetb.Text);
            p.setgender(comboBox1.Text);
            p.setphone(phonetb.Text);
            p.setaddress(addresstb.Text);
            p.setsalary(salarytb.Text);
            p.setfrom(starttb.Text);
            p.setto(finishtb.Text);
            p.setdeprtment(departmenttb.Text);
            con.Open();
            string query = "UPDATE employ SET Name = @Name ,Age = @Age, Gender = @Gender, PhoneNumber = @PhoneNumber, Address = @Address, Salary = @Salary, Start = @Start, Finish = @Finish, Department = @Department WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
            dataGridView1.DataSource = updateemployee();
            MessageBox.Show("Information Updated");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = updateemployee();
        }
        public DataTable updateemployee()
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            nametb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            agetb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            phonetb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            addresstb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            salarytb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            starttb.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            finishtb.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            departmenttb.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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
