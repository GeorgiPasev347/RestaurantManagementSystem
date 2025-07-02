using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarriageHallManagement
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BeerPrice.Enabled = true;
            BeerQty.Enabled = true;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                BeerPrice.Enabled = true;
                BeerQty.Enabled = true;
            }
            else
            {
                BeerPrice.Enabled = false;
                BeerQty.Enabled = false;
            }
        }

        private void SodaCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (SodaCheck.Checked == true)
            {
                SodaPrice.Enabled = true;
                SodaQty.Enabled = true;
            }
            else
            {
                SodaPrice.Enabled = false;
                SodaQty.Enabled = false;
            }
        }

        private void WineCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WineCheck.Checked == true)
            {
                WinePrice.Enabled = true;
                WineQty.Enabled = true;
            }
            else
            {
                WinePrice.Enabled = false;
                WineQty.Enabled = false;
            }
        }

        private void WaterCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WaterCheck.Checked == true)
            {
                WaterPrice.Enabled = true;
                WaterQty.Enabled = true;
            }
            else
            {
                WaterPrice.Enabled = false;
                WaterQty.Enabled = false;
            }
        }

        private void FriesCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (FriesCheck.Checked == true)
            {
                FriesPrice.Enabled = true;
                FriesQty.Enabled = true;
            }
            else
            {
                FriesPrice.Enabled = false;
                FriesQty.Enabled = false;
            }
        }

        private void PastaCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (PastaCheck.Checked == true)
            {
                PastaPrice.Enabled = true;
                PastaQty.Enabled = true;
            }
            else
            {
                PastaPrice.Enabled = false;
                PastaQty.Enabled = false;
            }
        }

        private void MuttonCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (MuttonCheck.Checked == true)
            {
                MuttonPrice.Enabled = true;
                MuttonQty.Enabled = true;
            }
            else
            {
                MuttonPrice.Enabled = false;
                MuttonQty.Enabled = false;
            }
        }

        private void LambCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LambCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (LambCheck.Checked == true)
            {
                LambPrice.Enabled = true;
                LambQty.Enabled = true;
            }
            else
            {
                LambPrice.Enabled = false;
                LambQty.Enabled = false;
            }
        }

        private void BevCost_Click(object sender, EventArgs e)
        {
            int beer = 0, soda = 0, wine = 0, water = 0;
            if (checkBox1.Checked == true && BeerQty.Text == "" && BeerPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                beer = Convert.ToInt32(BeerPrice.Text) * Convert.ToInt32(BeerQty.Text);
            }

            if (SodaCheck.Checked == true && SodaQty.Text == "" && SodaPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                soda = Convert.ToInt32(SodaPrice.Text) * Convert.ToInt32(SodaQty.Text);
            }
            if (WineCheck.Checked == true && WineQty.Text == "" && WinePrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                wine = Convert.ToInt32(WinePrice.Text) * Convert.ToInt32(WineQty.Text);
            }
            if (WaterCheck.Checked == true && WaterQty.Text == "" && WaterPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                water = Convert.ToInt32(WaterPrice.Text) * Convert.ToInt32(WaterQty.Text);
            }
            int bevcost = beer + water + wine + soda;
            BevCostLbl.Text = "" + bevcost;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fries = 0, pasta = 0, mutton = 0, lamb = 0;
            if (FriesCheck.Checked == true && FriesQty.Text == "" && FriesPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                fries = Convert.ToInt32(FriesPrice.Text) * Convert.ToInt32(FriesQty.Text);
            }

            if (PastaCheck.Checked == true && PastaQty.Text == "" && PastaPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                pasta = Convert.ToInt32(PastaPrice.Text) * Convert.ToInt32(PastaQty.Text);
            }
            if (MuttonCheck.Checked == true && MuttonQty.Text == "" && MuttonPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                mutton = Convert.ToInt32(MuttonPrice.Text) * Convert.ToInt32(MuttonQty.Text);
            }
            if (LambCheck.Checked == true && LambQty.Text == "" && LambPrice.Text == "")
            {
                MessageBox.Show("Enter price and quantity");
            }
            else
            {
                lamb = Convert.ToInt32(WaterPrice.Text) * Convert.ToInt32(WaterQty.Text);
            }
            int foodcost = fries + mutton + lamb + pasta;
            FoodCostLbl.Text = "" + foodcost;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //int total = Convert.ToInt32(FoodCostLbl.Text) + Convert.ToInt32(BevCostLbl.Text);
            //textBox18.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int total = Convert.ToInt32(FoodCostLbl.Text) + Convert.ToInt32(BevCostLbl.Text);
            textBox18.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BevCostLbl.Text = " ";
            FoodCostLbl.Text = " ";
            textBox18.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\MarriageDb.mdf;Integrated Security=True;Connect Timeout=30");

            DateTime dta = dateTimePicker1.Value;
            string daynight = comboBox1.Text;
            int people = Convert.ToInt32(PplTb.Text);
            int bevcost = Convert.ToInt32(BevCostLbl.Text);
            int foodcost = Convert.ToInt32(BevCostLbl.Text);
            int total = Convert.ToInt32(BevCostLbl.Text) + Convert.ToInt32(FoodCostLbl.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO Bookingtbl (Date,Time,People,CostDrink,CostFood,Total) VALUES (@Date,@Time,@People,@CostDrink,@CostFood,@Total)";
                SqlCommand cmd = new SqlCommand(query, conn);
                {
                    cmd.Parameters.AddWithValue("@Date", dta);
                    cmd.Parameters.AddWithValue("@Time", daynight);
                    cmd.Parameters.AddWithValue("@People", people);
                    cmd.Parameters.AddWithValue("@CostDrink", bevcost);
                    cmd.Parameters.AddWithValue("@CostFood", foodcost);
                    cmd.Parameters.AddWithValue("@Total", total);


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Поръчката е записана успешно!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Грешка " + ex.Message);

                    }

                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
