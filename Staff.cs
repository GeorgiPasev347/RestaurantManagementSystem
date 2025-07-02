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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\MarriageDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPassTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO StaffTbl VALUES ('" + StaffNameTb.Text + "','" + StaffPhoneTb.Text + "','" + StaffPassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Succesfully Added");
                    populate();
                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int staffkey = 0;
        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffPhoneTb.Text = "";
            StaffNameTb.Text = "";
            StaffPassTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (staffkey == 0)
            {
                MessageBox.Show("Select the staff to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM StaffTbl WHERE StaffId" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff deleted");
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
            if (StaffNameTb.Text == "" || StaffNameTb.Text == "" || StaffPassTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update StaffTbl set StaffName='" + StaffNameTb.Text + "',StaffPhone='" + StaffPhoneTb.Text + "',StaffPassword='" + StaffPassTb.Text + "' where StaffId=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Succesfully Updated");
                    populate();
                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffNameTb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            StaffPhoneTb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            StaffPassTb.Text = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (StaffNameTb.Text == "")
            {
                staffkey = 0;
            }
            else
            {
                staffkey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
