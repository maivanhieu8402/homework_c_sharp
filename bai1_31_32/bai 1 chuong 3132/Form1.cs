using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_1_chuong_3132
{
    public partial class Form1 : Form
    {
        public float a, b, c;
        public double denta,x1,x2,kq1,kq2,kq3;

        private void rc2_CheckedChanged(object sender, EventArgs e)
        {
            tnc.Enabled = true;
        }

        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void tkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tna.Text = "";
            tnb.Text = "";
            tnc.Text = "";
            tkq.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tnc.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rc1.Checked == true)
            {
                a = float.Parse(tna.Text);
                b = float.Parse(tnb.Text);
                if(a == 0)
                {
                    if (b == 0)
                    {
                        tkq.Text = "phuong trinh vo so nghiem";//vo dinh
                    }
                    else tkq.Text = "phuong trinh vo nghiem";
                }else
                {
                    kq1 = (-b) / a;
                    tkq.Text = kq1.ToString();
                }
            }
            if(rc2.Checked == true)
            {
                a = float.Parse(tna.Text);
                b = float.Parse(tnb.Text);
                c = float.Parse(tnc.Text);
                if(a == 0)
                {
                    if(b == 0)
                    {
                        if(c == 0)
                        {
                            tkq.Text = "phuong trinh vo so nghiem";
                        }
                        else tkq.Text = "phuong trinh vo nghiem";
                    }
                    else
                    {
                        kq2 = (-c) / b;
                        tkq.Text = kq2.ToString();
                    }
                }else
                {
                    denta = (b * b) - (4 * a * c);
                    if(denta < 0)
                    {
                        tkq.Text = "phuong trinh vo nghiem";
                    }else if(denta == 0)
                    {
                        kq3 = (-b) / (2 * a);
                        tkq.Text = kq3.ToString();
                    }else if(denta > 0)
                    {
                        x1 = ((-b) + Math.Sqrt(denta)) / (2 * a);
                        x1 = ((-b) - Math.Sqrt(denta)) / (2 * a);
                        tkq.Text = x1.ToString() + x2.ToString();
                    }
                }
            }
        }
    }
}
