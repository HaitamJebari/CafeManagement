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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hi\Documents\Cdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string user;
        private void button1_Click(object sender, EventArgs e)
        {
            user=UnameTb.Text;  
            if (UnameTb.Text==""|| PasswordTb.Text=="")
            {
                MessageBox.Show("Enter Username or Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Userstb where Uname ='"+UnameTb.Text+"' and Upassword = '"+PasswordTb.Text+"'",con);  
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    UserOrder uOrder = new UserOrder();
                    uOrder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GuestOrder guestOrder = new GuestOrder();
            guestOrder.Show();
        }
        
    }
}
