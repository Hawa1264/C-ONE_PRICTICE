using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_button_check_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Creating variables
            String name, gender;
            string faculty = "";
            int age, validation;

            // Validation of data
            if (int.TryParse(textBoxAge.Text, out validation))
            {
                // Assign values to variables
                name = textBoxName.Text;
                age = int.Parse(textBoxAge.Text);

                // Checking age validation
                if (age > 0)
                {
                    // Checking gender
                    if (radiobtnfemale.Checked)
                    {
                        gender = "Female";
                        MessageBox.Show("Gender: " + gender);
                    }
                    else if (radiobtnmale.Checked)
                    {
                        gender = "Male";
                        MessageBox.Show("Gender: " + gender);
                    }
                    else
                    {
                        MessageBox.Show("Please select one gender");
                    }

                    // Checking faculty 
                    if (checkBoxcomputer.Checked && checkBoxit.Checked && checkBoxBusiness.Checked)
                    {
                        faculty = "Computer\nIT\nBusiness";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                    
                    else if (checkBoxcomputer.Checked && checkBoxit.Checked)
                    {
                        faculty = "Computer\nIT";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                    else if (checkBoxcomputer.Checked && checkBoxBusiness.Checked)
                    {
                        faculty = "Computer\nBusiness";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                    else if (checkBoxit.Checked && checkBoxBusiness.Checked)
                    {
                        faculty = "IT\nBusiness";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                   
                    else if (checkBoxcomputer.Checked)
                    {
                        faculty = "Computer";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                    else if (checkBoxit.Checked)
                    {
                        faculty = "IT";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                    else if (checkBoxBusiness.Checked)
                    {
                        faculty = "Business";
                        MessageBox.Show("Faculty:\n" + faculty);
                    }
                    else
                    {
                        MessageBox.Show("Please select at least one faculty");
                    }
                }
                else
                {
                    MessageBox.Show("Age only accepts positive numbers");
                }
            }
            else
            {
                MessageBox.Show("Age only accepts numeric values");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAge.Text = "";
            textBoxName.Text = "";
            radiobtnfemale.Checked = false;
            radiobtnfemale.Enabled = false;
            checkBoxBusiness.Checked = false;   
            checkBoxcomputer.Checked = false;
            checkBoxit.Checked = false;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}