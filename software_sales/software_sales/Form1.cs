using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {   // Validation - Package
                if (!int.TryParse(txtPackage.Text, out int package))
                {
                    MessageBox.Show("Number of packages must be numeric");
                    return;
                }
                if (package <= 0)
                {
                    MessageBox.Show("Number of packages cannot be negative or zero");
                    return;
                }

                // Validation - Price
                if (!double.TryParse(txtprice.Text, out double price))
                {
                    MessageBox.Show("Price must be numeric");
                    return;
                }
                if (price <= 0)
                {
                    MessageBox.Show("Price cannot be negative or zero");
                    return;
                }

                // Subtotal
                double subtotal = package * price;

                // Discount Rate
                double discountRate = 0;

                if (package >= 1 && package <= 9)
                    discountRate = 0;
                else if (package >= 10 && package <= 19)
                    discountRate = 0.20;
                else if (package >= 20 && package <= 49)
                    discountRate = 0.30;
                else if (package >= 50 && package <= 99)
                    discountRate = 0.40;
                else if (package >= 100)
                    discountRate = 0.50;

                // Calculations
                double discountAmount = subtotal * discountRate;
                double totalAmount = subtotal - discountAmount;

                // Display
                listBox1.Items.Clear();
                listBox1.Items.Add("Number of Packages : " + package);
                listBox1.Items.Add("Price per Package  : $" + price.ToString("F2"));
                listBox1.Items.Add("Subtotal           : $" + subtotal.ToString("F2"));
                listBox1.Items.Add("Discount Rate      : " + (discountRate * 100) + "%");
                listBox1.Items.Add("Discount Amount    : $" + discountAmount.ToString("F2"));
                listBox1.Items.Add("Total Amount       : $" + totalAmount.ToString("F2"));
            

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
           

 }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtPackage.Text = "";
            txtprice.Text = "";
            lblpackages.Text = "";
            lblprice.Text = "";
            listBox1.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    }

