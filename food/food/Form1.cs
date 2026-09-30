using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //declaring varible
                string food1, food2;
                double price1, price2 , sales , subtoal ,tips ,total;
                //constant varibles
                const double sales_price = 7;
                const double tip_price = 15;
                //storing date
                food1 = (txtFood1.Text);
                food2 = (txtFood2.Text);
                price1 = double.Parse(txtprice1.Text);
                price2 = double.Parse(txtprice2.Text);
                //calculate subtotal first
                subtoal = price1 + price2;

                //now calculate sales tax
                sales = subtoal * (sales_price / 100);

                // now calculate tips
                tips = subtoal * (tip_price / 100);

                //now calculate the total amount
                total = subtoal + sales + tips;

                //display
                lblouputsales.Text = sales.ToString("f2");
                lbloutputtips.Text = tips.ToString("f2");
                lbloutputtotal.Text = total.ToString("f2");






            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
