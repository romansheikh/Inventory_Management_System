using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Inventory_Project.Screen.products
{
    public partial class VarifyForm : MetroFramework.Forms.MetroForm
    {
        string RandomCode;
        public static string to;
        public VarifyForm()
        {
            InitializeComponent();
        }

        private void VarifyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            try
            {
                if (RandomCode == (txtvarifycode.Text).ToString())
                {
                    to = txtemail.Text;
                    ChangePassword cp = new ChangePassword();
                    this.Hide();
                    cp.Show();
                }
                else
                {
                    MessageBox.Show("Ops......" +
                                    "The Code That You Have Enter is Worng....");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rd = new Random();
            RandomCode = (rd.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtemail.Text).ToString();
            from = "roman.idb42@gmail.com";
            pass = "Francis120";
            messageBody = "Your Password Reset Varification Code is " + RandomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Rest Code..";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Varification Code Send Successfully.........");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
