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
using System.Collections;

namespace ProjectC_
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\HaitamJebari\My Projects\ProjectC#\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");

        void populate()
        {
            con.Open();
            string query = "select * from Itemtb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemL.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ItemNum.Text == "")
            {
                MessageBox.Show("Select The Item want to Delete");
            }
            else
            {
                con.Open();
                string query = "delete from Itemtb where ItemNumtb = '" + ItemNum.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm Uform = new UsersForm();
            Uform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder Uorder = new UserOrder();
            Uorder.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ItemNum.Text == "" || ItemNum.Text == "" || ItemPrice.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                con.Open();
                string query = "insert into Itemtb values ('" + ItemNum.Text + "','" + ItemName.Text + "','" + Cat.SelectedItem.ToString() + "','" + ItemPrice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succefully Created");
                con.Close();
                populate();
            }


        }



        private void ItemL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ItemNum.Text = ItemL.SelectedRows[0].Cells[0].Value.ToString();
            ItemName.Text = ItemL.SelectedRows[0].Cells[1].Value.ToString();
            Cat.SelectedItem = ItemL.SelectedRows[0].Cells[2].Value.ToString();
            ItemPrice.Text = ItemL.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ItemNum.Text == "" || ItemName.Text == "" || ItemPrice.Text == "")
            {
                MessageBox.Show("Fill all The fields");
            }
            else
            {
                con.Open();
                string query = "update Itemtb set ItemNumtb = '" + ItemNum.Text + "' , ItemNametb = '" + ItemName.Text + "' , Cattb = '" + Cat.SelectedItem.ToString() + "'  where ItemNumtb = '" + ItemNum.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Succefull");
                con.Close();
                populate();

            }
        }
    }
}
