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
using Inventory_Project.General;

namespace Inventory_Project.Screen.products
{
    
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
        string username= VarifyForm.to;

        public ChangePassword()
        {
            InitializeComponent();
        }

   

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnewpassword.Text == txtconformpassword.Text)
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE LoginUser SET password = @password WHERE username = @username", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@password", txtconformpassword.Text);
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Changed Successfully");

                }
                else
                {
                    MessageBox.Show("Enter Same Password");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                Loginform lf = new Loginform();
                this.Hide();
                lf.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

