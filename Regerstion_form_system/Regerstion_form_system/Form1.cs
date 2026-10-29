using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regerstion_form_system
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

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxLevel.Items.Add("Year 1");
            listBoxLevel.Items.Add("Year 2");
            listBoxLevel.Items.Add("Year 3");
            listBoxLevel.Items.Add("Year 4");
    }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validation - Name
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Student Name");
                return;
            }

            // Validation - ID
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter Student ID");
                return;
            }

            // Validation - Courses
            if (!int.TryParse(txtCourses.Text, out int courses))
            {
                MessageBox.Show("Number of Courses must be numeric");
                return;
            }

            if (courses < 1 || courses > 8)
            {
                MessageBox.Show("Number of Courses must be between 1 and 8");
                return;
            }

            // Validation - Study Level
            if (listBoxLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Study Level");
                return;
            }

            // Variables
            string name = txtName.Text;
            string id = txtID.Text;
            string level = listBoxLevel.SelectedItem.ToString();

            // Fee per course
            double feePerCourse = 0;
            if (level == "Year 1") feePerCourse = 40;
            else if (level == "Year 2") feePerCourse = 45;
            else if (level == "Year 3") feePerCourse = 50;
            else if (level == "Year 4") feePerCourse = 55;

            // Tuition Fee
            double tuitionFee = courses * feePerCourse;

            // Accommodation
            double accommodationFee = 0;
            if (rdnAccYes.Checked) accommodationFee = 120;

            // Transport
            double transportFee = 0;
            if (rdnTransYes.Checked) transportFee = 50;

            // Subtotal
            double subtotal = tuitionFee + accommodationFee + transportFee;

            // Discount - 5 or more courses
            double discount = 0;
            if (courses >= 5) discount = 35;

            // Insurance - 10% of tuition
            double insurance = tuitionFee * 0.10;

            // Surcharge - 5% of subtotal
            double surcharge = subtotal * 0.05;

            // Final Cost
            double finalCost = subtotal - discount + insurance + surcharge;

            // Rental Status
            string status = finalCost <= 500 ? "Approved" : "Rejected";

            // Display Summary
            lblSummary.Text =
                "Student Name: " + name + "\n" +
                "Student ID: " + id + "\n" +
                "Study Level: " + level + "\n" +
                "Tuition Fee: $" + tuitionFee.ToString("F2") + "\n" +
                "Accommodation Fee: $" + accommodationFee.ToString("F2") + "\n" +
                "Transport Fee: $" + transportFee.ToString("F2") + "\n" +
                "Discount: $" + discount.ToString("F2") + "\n" +
                "Insurance Cost: $" + insurance.ToString("F2") + "\n" +
                "Surcharge: $" + surcharge.ToString("F2") + "\n" +
                "Final Rental Cost: $" + finalCost.ToString("F2") + "\n" +
                "Rental Status: " + status;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtID.Text = "";
            txtCourses.Text = "";
            listBoxLevel.ClearSelected();
            rdnAccNo.Checked = true;
            rdnTransNo.Checked = true;
            lblSummary.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void y_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
