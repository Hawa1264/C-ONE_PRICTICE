using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnShowinfo_Click(object sender, EventArgs e)
        {

            
        }
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();   
            txtdepatment.Clear();
            txtsemester.Clear();
            lbloutput.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowinfo_(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int studentID = int.Parse(txtstudentid.Text);
            string department = txtdepatment.Text;
            string semester = txtsemester.Text;

            lbloutput.Text = name + " " + studentID + " " + department + " " + semester;
        }
    }
}
