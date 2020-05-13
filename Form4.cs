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
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Window Forms LAB;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT * FROM Student";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_box.Text.ToString();
            string address = address_box.Text.ToString();
            string cnic = cnic_box.Text.ToString();
            string Class = class_box.Text.ToString();
            string section = section_box.Text.ToString();
            string roll = roll_box.Text.ToString();
            string dob = dob_box.Text.ToString();
            con.Open();
            string q = "Update Student Set  Name = '" + name + "',Address ='" + address + "', CNIC='" + cnic + "',Class='" + Class + "',section='" + section + "',Roll_No='" + roll + "',DOB='" + dob + "' Where Roll_No ='" + roll + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            name_box.Clear();
            section_box.Clear();
            address_box.Clear();
            cnic_box.Clear();
            class_box.Clear();
            roll_box.Clear();
            dob_box.Clear();
            con.Close();
            MessageBox.Show("Data Update successfuly..!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            name_box.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            address_box.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cnic_box.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            class_box.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            section_box.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            roll_box.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dob_box.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT * FROM Student";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
