using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline__Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validation - Name
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Passenger Name");
                return;
            }

            // Validation - Age
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be numeric");
                return;
            }
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100");
                return;
            }

            // Validation - Tickets
            if (!int.TryParse(txtTickets.Text, out int tickets))
            {
                MessageBox.Show("Number of tickets must be numeric");
                return;
            }
            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5");
                return;
            }

            // Validation - Baggage
            if (!double.TryParse(txtBaggage.Text, out double baggage))
            {
                MessageBox.Show("Baggage weight must be numeric");
                return;
            }
            if (baggage < 0 || baggage > 50 * tickets)
            {
                MessageBox.Show("Baggage cannot be negative or exceed 50 kg per passenger");
                return;
            }

            // Travel Class
            string travelClass = "";
            double ticketPrice = 0;

            if (radioButtonfirstclass.Checked)
            {
                if (age <= 12)
                {
                    MessageBox.Show("Passengers below 12 cannot book First Class. Booking REJECTED.");
                    listBoxdisplay.Text = "Booking Status: REJECTED\nReason: Passenger under 12 cannot book First Class.";
                    return;
                }
                travelClass = "First Class";
                ticketPrice = 500;
            }
            else if (radioButtonnormalclass.Checked)
            {
                travelClass = "Normal Class";
                ticketPrice = 200;
            }
            else if (radioButtonBusiness.Checked)
            {
                travelClass = "Business Class";
                ticketPrice = 350;
            }
            else
            {
                MessageBox.Show("Please select a Travel Class");
                return;
            }

            // Basic Cost
            double basicCost = ticketPrice * tickets;

            // Ticket Discount
            double ticketDiscount = 0;
            if (tickets >= 3 && tickets <= 4)
                ticketDiscount = basicCost * 0.05;
            else if (tickets == 5)
                ticketDiscount = basicCost * 0.10;

            // Child Discount (age < 12)
            double childDiscount = 0;
            if (age < 12)
                childDiscount = basicCost * 0.20;

            // Senior Discount (age >= 60)
            double seniorDiscount = 0;
            if (age >= 60)
                seniorDiscount = basicCost * 0.10;

            // Travel Insurance
            double insuranceCost = 0;
            if (checkBoxtravelinsurance.Checked)
                insuranceCost = 25 * tickets;

            // Baggage Cost
            double baggageCost = 0;
            double baggageLimit = 20 * tickets;
            if (baggage > baggageLimit)
                baggageCost = (baggage - baggageLimit) * 5;

            // Final Cost
            double finalCost = basicCost - ticketDiscount - childDiscount - seniorDiscount + insuranceCost + baggageCost;

            // Booking Approved
            bool bookingApproved = true;
            string status = bookingApproved ? "APPROVED" : "REJECTED";
            //Display
            listBoxdisplay.Items.Clear();
            listBoxdisplay.Items.Add("Passenger Name: " + txtName.Text);
            listBoxdisplay.Items.Add("Passenger Age: " + age);
            listBoxdisplay.Items.Add("Number of Tickets: " + tickets);
            listBoxdisplay.Items.Add("Baggage Weight: " + baggage + " kg");
            listBoxdisplay.Items.Add("Travel Class: " + travelClass);
            listBoxdisplay.Items.Add("Ticket Price: $" + ticketPrice.ToString("F2"));
            listBoxdisplay.Items.Add("Basic Cost: $" + basicCost.ToString("F2"));
            listBoxdisplay.Items.Add("Ticket Discount: $" + ticketDiscount.ToString("F2"));
            listBoxdisplay.Items.Add("Child Discount: $" + childDiscount.ToString("F2"));
            listBoxdisplay.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
            listBoxdisplay.Items.Add("Insurance Cost: $" + insuranceCost.ToString("F2"));
            listBoxdisplay.Items.Add("Baggage Cost: $" + baggageCost.ToString("F2"));
            listBoxdisplay.Items.Add("");
            listBoxdisplay.Items.Add("Final Cost: $" + finalCost.ToString("F2"));
            listBoxdisplay.Items.Add("Booking Status: " + status);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtBaggage.Text = "";
            txtTickets.Text = "";
            radioButtonBusiness.Checked = false;
            radioButtonfirstclass.Checked = false;
            radioButtonnormalclass.Checked = false;
            checkBoxtravelinsurance.Checked = false;
            listBoxdisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
