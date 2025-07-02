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
using Microsoft.Data.SqlClient;
namespace MarriageHallManagement
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\MarriageDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO CustTbl VALUES ('" + CustNameTb.Text + "','" + CustAddTb.Text + "','" + CustPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succesfully Added");
                    populate();
                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM CustTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAddTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (CustPhoneTb.Text == "")
            {
                custkey = 0;
            }
            else
            {
                custkey = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();
        }
        int custkey = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            CustPhoneTb.Text = "";
            CustAddTb.Text = "";
            CustNameTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (custkey == 0)
            {
                MessageBox.Show("Select the customer to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM CustTbl where CustId" + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustTbl set CustName='" + CustNameTb.Text + "',CustAdd='" + CustAddTb.Text + "',CustPhone='" + CustPhoneTb.Text + "' where CustId=" + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succesfully Updated");
                    populate();
                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
