using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        public void Clear()
        {
            kryptonTextBox2.Text = kryptonTextBox1.Text = null;
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
            fs = new FileStream("employee.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(kryptonTextBox2.Text + "|" + kryptonTextBox1.Text );
            sw.Flush();
            MessageBox.Show("Done");
            Clear();
            sw.Close();
            fs.Close();
        

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
