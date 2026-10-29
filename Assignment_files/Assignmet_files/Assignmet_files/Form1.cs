
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Assignmet_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           
        
        private void button2_Click(object sender, EventArgs e)
        {
            
  
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            File.WriteAllText(
                "new-data.txt",
                "Hello from C#!"
            );

            File.AppendAllText(
                "new-data.txt",
                Environment.NewLine + "This is another line."
            );

            File.WriteAllText("old-new-data.txt", "File to delete");
            File.WriteAllText("old-new-data2.txt", "Another file to delete");

            Directory.CreateDirectory("OldFolder");
            File.WriteAllText("OldFolder/test.txt", "Test file");

            listBox1.Items.Add("Files created successfully.");
            listBox1.Items.Add("new-data.txt");
            listBox1.Items.Add("old-new-data.txt");
            listBox1.Items.Add("old-new-data2.txt");
            listBox1.Items.Add("OldFolder");
        }

        private void btnReadLines_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string line in File.ReadLines("new-data.txt"))
            {
                listBox1.Items.Add(line);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("new-data.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

        private void btnReadBlock_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (StreamReader reader = new StreamReader("new-data.txt"))
            {
                char[] buffer = new char[20];

                int count = reader.ReadBlock(buffer, 0, buffer.Length);

                string text = new string(buffer, 0, count);

                listBox1.Items.Add(text);
            }
        }

        private void btnReadAllBytes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            byte[] data = File.ReadAllBytes("new-data.txt");

            string text = Encoding.UTF8.GetString(data);

            listBox1.Items.Add(text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                File.Delete("old-new-data.txt");

                listBox1.Items.Add("File.Delete executed.");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void btnDirectoryDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                Directory.Delete("OldFolder", true);

                listBox1.Items.Add("Directory deleted successfully.");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void btnFileInfoDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                FileInfo file = new FileInfo("old-new-data2.txt");

                file.Delete();

                listBox1.Items.Add("FileInfo.Delete executed.");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
