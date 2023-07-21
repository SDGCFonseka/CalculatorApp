using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fnum = int.Parse(textBox1.Text);
            int snum = int.Parse(textBox2.Text);
            int ans  = fnum + snum;
            label5.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fnum = int.Parse(textBox1.Text);
            int snum = int.Parse(textBox2.Text);
            int ans = fnum - snum;
            label5.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fnum = int.Parse(textBox1.Text);
            int snum = int.Parse(textBox2.Text);
            int ans = fnum * snum;
            label5.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double fnum = double.Parse(textBox1.Text);
            double snum = double.Parse(textBox2.Text);
            double ans = fnum / snum;
            label5.Text = ans.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
