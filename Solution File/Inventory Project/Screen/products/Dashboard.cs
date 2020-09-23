using Inventory_Project.Screen.products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Project
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnitementry_Click(object sender, EventArgs e)
        {
            ProductEntry productEntry = new ProductEntry();
            productEntry.Show();
        }

        private void btncustomermanage_Click(object sender, EventArgs e)
        {
            Customer_Management CM = new Customer_Management();
            CM.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Registerform rf = new Registerform();
            rf.Show();

        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginform lf = new Loginform();
                lf.Show();
            
        }

        private void btnsupplierentry_Click(object sender, EventArgs e)
        {
            Supplierdata sd = new Supplierdata();
            sd.Show();
        }

        private void btnstockmanagement_Click(object sender, EventArgs e)
        {
            Stock_Management sm = new Stock_Management();
            sm.Show();
            
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            this.Hide();
            cp.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            frmProductReport frmpRODUCT = new frmProductReport();
            this.Hide();
            frmpRODUCT.Show();
        }
    }
}
