using Inventory_Project.General;
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

namespace Inventory_Project.Screen.products
{
    public partial class Stock_Management : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
        public Stock_Management()
        {
            InitializeComponent();
        }

        private void Stock_Management_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Suppliers values (@Quentity, @purchaseprice, @sealsprice)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Quentity", txtquentity.Text);
                cmd.Parameters.AddWithValue("@purchaseprice", txtpurchaseprice.Text);
                cmd.Parameters.AddWithValue("@sealsprice", txtsalesprice.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }

    
    }
}
