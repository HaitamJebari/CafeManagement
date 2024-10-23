using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectC_
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Iform = new ItemsForm();
            Iform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm Uform = new UsersForm();
            Uform.Show();
        }
    }
}
