using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectC_
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hi\Documents\Cdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");

        void populate()
        {
            con.Open();
            string query = "select * from Itemtb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }
        void FilterByCategory()
        {
            con.Open();
            string query = "select * from Itemtb where cattb = '"+Cat.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
        }

        int num = 0;
        int price, total;
        string item,cat;

        DataTable table=new DataTable();
        int flag = 0;
        int sum = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGV.DataSource = table;
            OrdersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Date.Text = DateTime.Today.Date.ToString() +"/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Month.ToString() +"/"+ DateTime.Today.Year.ToString();
            SellerName.Text = Form1.user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm itm = new ItemsForm();    
            itm.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm users = new UsersForm();
            users.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void Cat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Orderstb values (" + OrderNum.Text + ",'" + Date.Text + "','" + SellerName.Text + "'," + OrderAmnt.Text + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Succefully Created");
            con.Close();
            populate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewOrders Vorders = new ViewOrders();
            Vorders.Show(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Quantity.Text=="")
            {
                MessageBox.Show("What is The Quantity of The Item");
            }
            else if(flag==0)
                {
                MessageBox.Show("Select The Product to be ordered");
            }
            else
            {
                num = num + 1;
                total=price*Convert.ToInt32(Quantity.Text);
                table.Rows.Add(num,item,cat,price,total);
                OrdersGV.DataSource=table;  
                flag = 0;
            }
            sum = sum + total;
            OrderAmnt.Text = "" + sum;
        }

       

        private void UList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
