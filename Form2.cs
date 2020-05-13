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
        public Form2()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-AQ49O2F;Initial Catalog=Window Forms LAB;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string name = name_box.Text.ToString();
                string address = address_box.Text.ToString();
                string cnic = cnic_box.Text.ToString();
                string Class = class_box.Text.ToString();
                string section = section_box.Text.ToString();
                string roll = roll_box.Text.ToString();
                string dob = dob_box.Text.ToString();

                string q = "insert into Student values ('" + name +"','" + address + "','"+cnic+"','"+Class+"','"+section+"','"+roll+"','"+dob+"')";
               // string q = "SELECT * FROM DEPT WHERE id = ('"+ textBox1.Text.ToString() +"')";
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
                MessageBox.Show("Data insert successfuly..!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
