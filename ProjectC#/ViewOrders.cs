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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hi\Documents\Cdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");

        void populate()
        {
            con.Open();
            string query = "select * from Orderstb";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        void FilterByCategory()
        {
            con.Open();
            string query = "select * from Itemtb where cattb = '" + Cat.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            con.Close();
        }

        DataTable table = new DataTable();

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGV.DataSource = table;
            OrdersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Cat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====My Cafe Software====",new Font("Abeezee",25,FontStyle.Bold),Brushes.Red,new Point(200,40));
            e.Graphics.DrawString("====Order Summary====", new Font("Abeezee", 25, FontStyle.Bold), Brushes.Red, new Point(208, 70));
            e.Graphics.DrawString(" Number :" + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 135));
            e.Graphics.DrawString(" Date :" + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 170));
            e.Graphics.DrawString(" Seller :" + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 205));
            e.Graphics.DrawString(" Amount :" + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 240));
            e.Graphics.DrawString("=====By Haitam=====", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208, 340));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
