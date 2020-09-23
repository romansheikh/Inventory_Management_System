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
using System.IO;
using System.Drawing.Imaging;

namespace Inventory_Project.Screen.products
{
    public partial class ProductEntry : MetroFramework.Forms.MetroForm
    {
        public ProductEntry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
        SqlCommand cmd;
        string imgloc = "";
        private void DefineProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierdata.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.supplierdata.Suppliers);
            // TODO: This line of code loads data into the 'inventory_ProjectDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.inventory_ProjectDataSet1.Category);
            // TODO: This line of code loads data into the 'inventory_ProjectDataSet.ListType' table. You can move, or remove it, as needed.

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] img = br.ReadBytes((int)fs.Length);
                string sql = "insert into Product values (" + cmbcategory.SelectedValue + ",'" + txtname.Text + "'," + txtpurchaseprice.Text + "," + txtsalesprice.Text + ", " + cmbsupplierid.SelectedValue + ", @image )";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@image", img));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayData();
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

        private void btnshow_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from product", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Jpg File (.jgp) (*.jpg)|*jpg| PNG File (*.png)|*.png| All Files (*.*)|*.*";
                of.Title = "Select Product Picture";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    imgloc = of.FileName.ToString();
                    pictureBox1.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] img = br.ReadBytes((int)fs.Length);

                cmd = new SqlCommand(@"UPDATE product SET CategoryID = @categoryid, ProductName= @name, PurchasePirce=@purchaseprice, SalesPrice=@salesprice, SupplierID=@supplierid, Images=@imgs WHERE productid = @id", con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@categoryid", cmbcategory.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@purchaseprice", txtpurchaseprice.Text);
                cmd.Parameters.AddWithValue("@salesprice", txtsalesprice.Text);
                cmd.Parameters.AddWithValue("@supplierid", cmbsupplierid.SelectedItem.ToString());
                cmd.Parameters.Add(new SqlParameter("@imgs", pictureBox1.Image));
                cmd.Parameters.AddWithValue("@id", int.Parse((txtsearch.Text)));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Update Successfully");
                DisplayData();
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
                SqlDataAdapter sda = new SqlDataAdapter("select * from product where productid =" + int.Parse((txtsearch.Text)), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                txtname.Text = dt.Rows[0][2].ToString();
                cmbcategory.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
                txtpurchaseprice.Text = dt.Rows[0][3].ToString();
                txtsalesprice.Text = dt.Rows[0][4].ToString();
                cmbsupplierid.SelectedValue = Convert.ToInt32(dt.Rows[0][5].ToString());
                byte[] img = (byte[])dt.Rows[0][6];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}