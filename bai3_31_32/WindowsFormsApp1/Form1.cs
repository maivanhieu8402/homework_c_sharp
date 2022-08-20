using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public float a, b;
        public double kq,kq1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            a = float.Parse(tst1.Text);
            b = float.Parse(tst2.Text);
            kq = a + b;
            kq1 = Math.Round(kq, 2);
        }
        private void butto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a = float.Parse(tst1.Text);
            b = float.Parse(tst2.Text);
            kq = a - b;
            kq1 = Math.Round(kq, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(tst1.Text);
            b = float.Parse(tst2.Text);
            kq = a * b;
            kq1 = Math.Round(kq, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(tst1.Text);
            b = float.Parse(tst2.Text);
            kq = a / b;
            kq1 = Math.Round(kq, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tst1.Text = "";
            tst2.Text = "";
            tkq.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tkq.Text = kq1.ToString();
        }
    }
    
}
