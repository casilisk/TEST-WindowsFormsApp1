using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BackendCode;

namespace TEST_WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {

        BackEnd be = new BackEnd();


        public int childsum;
        public int adultsum;
        public int seniorsum;

        public Form1()
        {
            InitializeComponent();
            be.MainCode();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress...");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string AdultInput = AdultBox.Text;
            try
            {
                adultsum = Int32.Parse(AdultInput);
                MessageBox.Show("Item added!");
            }
            catch
            {
                MessageBox.Show("Number please!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ChildInput = ChildBox.Text;
            try
            {
                childsum = Int32.Parse(ChildInput);
                MessageBox.Show("Item added!");
            }
            catch
            {
                MessageBox.Show("Number please!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string seniorInput = SeniorBox.Text;
            try
            {
                seniorsum = Int32.Parse(seniorInput);
                MessageBox.Show("Item added!");
            }
            catch
            {
                MessageBox.Show("Number please!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            be.GetInts(childsum,adultsum,seniorsum);
            if (adultsum + childsum + seniorsum == 0)
            {
                MessageBox.Show("Please add at least one ticket!");
            }
            else
            {
                childsum = 0;
                adultsum = 0;
                seniorsum = 0;
                be.Checkout();
                MessageBox.Show("Purchased!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string refundInput = RefundBox.Text;
            try
            {
                int checkInput = Int32.Parse(refundInput);
                be.Refund(checkInput);
                MessageBox.Show("Refunded ID NR: " + checkInput);
            }
            catch
            {
                MessageBox.Show("Only ID number please!");
            }
        }
    }
}

