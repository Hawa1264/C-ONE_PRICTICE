using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter lines;
                lines = File.CreateText("just.txt");
                lines.WriteLine("welcome to Computer Science");
                lines.WriteLine("just");
                lines.Close();
                listBox1.Items.Add(lines);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader lines;
                lines = File.OpenText("just.txt");

                string line;

                while ((line = lines.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }

                lines.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int counts = 0;
            while (counts < 5)
            {
                MessageBox.Show("Hello");
                counts++;  // muhiim! haddaan jirin → infinite loop
                          // While + if/else + file writing
                StreamWriter outputFile = File.CreateText("results.txt");

                int count = 0;
                while (count < 5)
                {
                    if (count % 2 == 0)
                        outputFile.WriteLine(count + " is even");
                    else
                        outputFile.WriteLine(count + " is odd");

                    count++;
                }
                outputFile.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            try
            {
                reader = File.OpenText(@"C:\c#\Readline\Readline\bin\Debug\just.txt");

                while (reader.EndOfStream == false)
                {
                    string line;
                    line = reader.ReadLine();
                    listBox1.Items.Add(line);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
