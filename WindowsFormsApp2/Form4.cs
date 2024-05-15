using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 form5 = new Form5();

            form5.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form7 form7 = new Form7();

            form7.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
