using System;
using System.Windows.Forms;

namespace Booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Validation - Name
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Guest Name");
                return;
            }

            // Validation - Age
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be numeric");
                return;
            }
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90");
                return;
            }

            // Validation - Nights
            if (!int.TryParse(txtnight.Text, out int nights))
            {
                MessageBox.Show("Nights must be numeric");
                return;
            }
            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30");
                return;
            }

            // Validation - Guests
            if (!int.TryParse(txtGuest.Text, out int guests))
            {
                MessageBox.Show("Guests must be numeric");
                return;
            }

            // Room Type
            string roomType = "";
            double roomRate = 0;

            if (radioButtonhight.Checked)
            {
                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("High room: guests must be between 1 and 6");
                    return;
                }
                roomType = "Hight";
                roomRate = 130;
            }
            else if (radioButtonstandrad.Checked)
            {
                if (guests < 1 || guests > 2)
                {
                    MessageBox.Show("Standard room: guests must be between 1 and 2");
                    return;
                }
                roomType = "Standard";
                roomRate = 50;
            }
            else if (radioButtonnormal.Checked)
            {
                if (guests < 1 || guests > 4)
                {
                    MessageBox.Show("Normal room: guests must be between 1 and 4");
                    return;
                }
                roomType = "Normal";
                roomRate = 80;
            }
            else
            {
                MessageBox.Show("Please select a Room Type");
                return;
            }

            // Basic Cost
            double basicCost = roomRate * nights * guests;

            // Stay Discount (by nights)
            double stayDiscount = 0;
            if (nights >= 1 && nights <= 3)
                stayDiscount = 0;
            else if (nights >= 4 && nights <= 9)
                stayDiscount = basicCost * 0.12;
            else if (nights >= 10)
                stayDiscount = basicCost * 0.15;

            // Senior Discount (age 60+)
            double seniorDiscount = 0;
            if (age >= 60)
                seniorDiscount = basicCost * 0.05;

            // Breakfast
            double breakfastCost = 0;
            if (checkBoxbreakfast.Checked)
                breakfastCost = 10 * guests * nights;

            // Service Surcharge 8%
            double serviceSurcharge = basicCost * 0.08;

            // Final Cost
            double finalCost = basicCost - stayDiscount - seniorDiscount + breakfastCost + serviceSurcharge;

            // Status
            string status = finalCost <= 1500 ? "APPROVED" : "REJECTED";

            // Display
            listBoxdisplay.Items.Clear();
            listBoxdisplay.Items.Add("Guest Name: " + txtName.Text);
            listBoxdisplay.Items.Add("Guest Age: " + age);
            listBoxdisplay.Items.Add("Number of Guests: " + guests);
            listBoxdisplay.Items.Add("Number of Nights: " + nights);
            listBoxdisplay.Items.Add("Room Type: " + roomType);
            listBoxdisplay.Items.Add("Rate Per Night: $" + roomRate.ToString("F2"));
            listBoxdisplay.Items.Add("Basic Room Cost: $" + basicCost.ToString("F2"));
            listBoxdisplay.Items.Add("Stay Discount: $" + stayDiscount.ToString("F2"));
            listBoxdisplay.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
            listBoxdisplay.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("F2"));
            listBoxdisplay.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("F2"));
            listBoxdisplay.Items.Add("Final Cost: $" + finalCost.ToString("F2"));
            listBoxdisplay.Items.Add("Booking Status: " + status);
        }






        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtnight.Text = "";
            txtGuest.Text = "";
            radioButtonnormal.Checked = false;
            radioButtonstandrad.Checked = false;
            radioButtonhight.Checked = false;
            checkBoxbreakfast.Checked = false;
            lblbookingsystem.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}