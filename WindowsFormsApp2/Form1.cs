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
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string ID = Logintext.Text;

            if (File.Exists("employee.txt"))
            {
                fs = new FileStream("employee.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                fs.Seek(0, SeekOrigin.Begin);
                string line;
                string[] arr;
                while ((line = sr.ReadLine()) != null)
                {
                    arr=line.Split('|');
                   
                    if (ID == arr[0])
                    {
                        MessageBox.Show("Welcome "+arr[1]);
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                        sr.Close();
                        fs.Close();
                        return;
                    }
                }
                MessageBox.Show("Wrong ID");
                Logintext.Text = null;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();

            form2.Show();
        }

        private void Logintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
