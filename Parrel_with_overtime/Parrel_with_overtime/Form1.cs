using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parrel_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateGross_Click(object sender, EventArgs e)
        {

            //creating Varribles
            double Hourse_worked, payrate, Gross_pay ,Validition;

            //perevent exception date converstion using try pasre  method

            if (double.TryParse(txtHoursework.Text, out Validition) && double.TryParse(txtPayrate.Text, out Validition))
            {
                //assign varibles
                Hourse_worked = double.Parse(txtHoursework.Text);
                payrate=double.Parse(txtPayrate.Text);

                // cheking validition
                if (Hourse_worked > 0 && payrate > 0) { 
                    //calculte the gross pay
                    Gross_pay=Hourse_worked * payrate;
                    llboutputGross.Text = Gross_pay.ToString("c");

                }
                else
                {
                    MessageBox.Show("Hourse woerkd  or payrate  must be great");
                     
                }
            }
            else 
            {
                MessageBox.Show("txthourse txtpayraye  only ecexpt double");

            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             //clear
            txtHoursework.Text = "";
            txtPayrate.Text = "";
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        { //close
            Close();
            
        }
    }
}
