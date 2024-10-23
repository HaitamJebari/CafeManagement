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

namespace ProjectC_
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\HaitamJebari\My Projects\ProjectC#\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30");


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder Uorder = new UserOrder();
            Uorder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Iform = new ItemsForm();
            Iform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UsersTbl values ('"+UnameTb.Text+ "','"+UphoneTb.Text+"','"+UpassTb.Text+"')";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Succefully Created");
            con.Close();
            populate();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        void populate()
        {
            con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UList.DataSource = ds.Tables[0];
            con.Close();
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UList.SelectedRows[0].Cells[0].Value.ToString();
            UphoneTb.Text = UList.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UList.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Select The User want to Delete");
            }
            else
            {
                con.Open();
                string query = "delete from UsersTbl where Uphone = '"+UphoneTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted");
                con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "" || UphoneTb.Text == "" || UnameTb.Text == "")
            {
                MessageBox.Show("Fill all The fields");
            }
            else
            {
                con.Open();
                string query = "update UsersTbl set Uname = '"+UnameTb.Text+"', Upassword = '"+UpassTb.Text+"',where Uphone = '"+UphoneTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Succefull");
                con.Close();
                populate();
            }
        }
    }
}
