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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Add_Custmor.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            string ID = kryptonTextBox6.Text;
            string line;
            string[] record;
            while ((line = sr.ReadLine()) != null)
            {
                record = line.Split('|');
                if (string.Equals(ID, record[0]))
                {
                    kryptonTextBox5.Text = "Name: " + record[1] +"\r\nCar Model: " + record[2] + "\r\nColor: " + record[3] + "\r\nMobile: " + record[4];
                    return;
                }
            }
            MessageBox.Show("Not Found");
        }

        private void kryptonTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Add_Car.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            string ID = kryptonTextBox6.Text;
            string line;
            string[] record;
            while ((line = sr.ReadLine()) != null)
            {
                record = line.Split('|');
                if (string.Equals(ID, record[0]))
                {
                    kryptonTextBox5.Text = "Car: "+record[1] + "\r\nColor: " + record[2] + "\r\nPrice: " + record[3];
                    return;
                }
            }
            MessageBox.Show("Not Found");
        }

        private void kryptonTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            kryptonTextBox5.Text = kryptonTextBox6.Text = null;
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
