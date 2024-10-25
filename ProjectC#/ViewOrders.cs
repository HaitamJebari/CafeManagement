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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\HaitamJebari\My Projects\ProjectC#\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");

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
    }
}
