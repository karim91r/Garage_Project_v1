using ComponentFactory.Krypton.Toolkit;
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

namespace WindowsFormsApp2
{
    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            kryptonTextBox1.Text = kryptonTextBox2.Text = kryptonTextBox3.Text=kryptonTextBox4.Text = null;
        }


        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Clear();
        } 

    

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 form6 = new Form6();

            form6.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Add_Car.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(kryptonTextBox4.Text+"|"+kryptonTextBox1.Text + "|" + kryptonTextBox2.Text + "|" + kryptonTextBox3.Text );
            sw.Flush();
            sw.Close();
            fs.Close();
            
            MessageBox.Show("Done");
            Clear();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Add_Car.txt", FileMode.Open, FileAccess.ReadWrite);
            sw = new StreamWriter(fs);
            sr = new StreamReader(fs);
            fs.Seek(0, SeekOrigin.Begin);
            fs.Flush();
            sw.Flush();
            int count = 0;
            string line;
            string[] arr;
            while ((line = sr.ReadLine()) != null)
            {
              
                arr = line.Split('|');
                if (arr[0] == kryptonTextBox4.Text)
                {
                    fs.Seek(count, SeekOrigin.Begin);
                    sw.Write("*");
                    sw.Flush();
                    MessageBox.Show("Deleted");
                    Clear();
                    sw.Close();
                    fs.Close();
                    return;
                }
                count += line.Length + 2;
            }
            MessageBox.Show("Not Found");
            Clear();
            sw.Close();
            fs.Close();
           
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 form4 = new Form4();

            form4.Show();
        }
    }
}
