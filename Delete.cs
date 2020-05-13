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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AQ49O2F;Initial Catalog=Window Forms LAB;Integrated Security=True");

        private void Delete_Load(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT * FROM Student";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Delete From Student where Roll_No='" + roll_box.Text.ToString() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(q, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted!!");
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roll_box.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
