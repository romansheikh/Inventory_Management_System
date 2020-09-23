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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Project.Screen.products
{
    public partial class Registerform : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
      
        public Registerform()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into LoginUser values (@id, @username, @Password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtsearch.Text));
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Passwordadmin roman", txtpassword.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Regestration Successfull....... ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Customers where customerid =" + int.Parse((txtsearch.Text)), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                txtcustomername.Text = dt.Rows[0][1].ToString();
                txtphoneNumber.Text = dt.Rows[0][2].ToString();
                txtaddress.Text = dt.Rows[0][5].ToString();
                txtemail.Text = dt.Rows[0][6].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginform lf = new Loginform();
            this.Hide();
            lf.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard  dbs = new Dashboard();
            dbs.Show();
        }
    }
}
