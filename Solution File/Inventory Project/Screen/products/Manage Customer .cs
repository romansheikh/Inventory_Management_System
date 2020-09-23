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
    public partial class Customer_Management : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString());
        int customerid;

        public Customer_Management()
        {
            InitializeComponent();
            DisplayData();
        }
        
     

        public void DisplayData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from customers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into customers values(@name, @phone, @dob, @gender,@address,@email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtcustomername.Text);
                cmd.Parameters.AddWithValue("@phone", txtphoneNumber.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@gender", cmbgender.SelectedIndex);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inseted Successfully");
                DisplayData();
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
                SqlCommand cmd = new SqlCommand(@"UPDATE customers SET CustomerName = @name, PhoneNumber= @phone, DoB=@dateofbirth, Gender=@gender, Address=@address, email=@email WHERE Customerid = @id", con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtcustomername.Text);
                cmd.Parameters.AddWithValue("@phone", txtphoneNumber.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@gender", cmbgender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtcustomername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtphoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbgender.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Customers where customerid =" + int.Parse((txtsearch.Text)), con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                txtcustomername.Text = dt.Rows[0][1].ToString();
                txtphoneNumber.Text = dt.Rows[0][2].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                txtaddress.Text = dt.Rows[0][5].ToString();
                cmbgender.SelectedItem = dt.Rows[0][4].ToString();
                txtemail.Text = dt.Rows[0][6].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (true)
            {
                SqlCommand cmd = new SqlCommand(@"Delete from customers WHERE Customerid = @id", con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", int.Parse((txtsearch.Text)));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Delted Successfully");
                DisplayData();
            }
            else
            {
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
