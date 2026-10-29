
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

        // CREATE
        private void button1_Click(object sender, EventArgs e)
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

            listBox1.Items.Add("File created: new-data.txt");
        }

        // READ
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // 1. File.ReadLines()
            foreach (string line in File.ReadLines("new-data.txt"))
            {
                listBox1.Items.Add(line);
            }

            // 2. StreamReader.ReadBlock()
            using (StreamReader reader =
                new StreamReader("new-data.txt"))
            {
                char[] buffer = new char[20];

                int count = reader.ReadBlock(
                    buffer, 0, buffer.Length
                );

                string text = new string(buffer, 0, count);

                listBox1.Items.Add("ReadBlock: " + text);
            }

            // 3. FileStream.Read()
            using (FileStream stream = new FileStream(
                "new-data.txt",
                FileMode.Open,
                FileAccess.Read))
            {
                byte[] buffer = new byte[100];

                int count = stream.Read(
                    buffer, 0, buffer.Length
                );

                string text = Encoding.UTF8.GetString(
                    buffer, 0, count
                );

                listBox1.Items.Add("FileStream.Read: " + text);
            }

            // 4. File.ReadAllBytes()
            byte[] data = File.ReadAllBytes("new-data.txt");

            string allText = Encoding.UTF8.GetString(data);

            listBox1.Items.Add("ReadAllBytes: " + allText);
        }

        // DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // 1. File.Delete()
            File.Delete("old-new-data.txt");

            listBox1.Items.Add("File.Delete executed.");

            // 2. FileInfo.Delete()
            FileInfo file = new FileInfo("old-new-data2.txt");

            file.Delete();

            listBox1.Items.Add("FileInfo.Delete executed.");

            // 3. Directory.Delete()
            Directory.Delete("OldFolder", true);

            listBox1.Items.Add("Directory.Delete executed.");
        }
    }
}
