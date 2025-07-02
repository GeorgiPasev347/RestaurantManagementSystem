using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarriageHallManagement
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
