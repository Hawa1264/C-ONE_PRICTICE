using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_nasted_loops
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

        private void btnCheckqultifiction_Click(object sender, EventArgs e)
        {
            try
            {
                //creating varibles
                double salary, years;

                //asigning varible

                salary=double.Parse(txtslary.Text);
                years=double.Parse(txtyears.Text);

                // checkong

                if (salary > 300)
                {
                    if (years >= 2)
                    {
                        lbloutput.Text=("quelitfy on loan");
                    }
                    else
                    {
                        lbloutput.Text = ("sorry! we can't quelity lon with Experisence");
                    }
                }
                else {
                    lbloutput.Text=(" Your salar is not enough to take a loan");
                }



            }
            catch (Exception ex)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtslary.Text = "";
            txtyears.Text = "";
        }
    }
}
