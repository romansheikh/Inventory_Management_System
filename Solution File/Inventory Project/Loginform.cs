using Inventory_Project.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory_Project.Screen.products;

namespace Inventory_Project
{
    public partial class Loginform : MetroFramework.Forms.MetroForm
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            if (isvalid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_loginverify", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            this.Hide();
                            Dashboard db = new Dashboard();
                            db.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is not Valid", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }

        }

        private bool isvalid()
        {
            if (txtusername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User Name is Require");
                txtusername.Focus();
                return false;
            }
            if (txtpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required");
                txtpassword.Focus();
                return false;
            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblforget_Click(object sender, EventArgs e)
        {
            VarifyForm vf = new VarifyForm();
            this.Hide();
            vf.Show();
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            Registerform rf = new Registerform();
            this.Hide();
            rf.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}