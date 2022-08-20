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
    public partial class Form1 : Form
    {
        public int a,b;
        public int snt, tscc,sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(tns.Text);
            b = a;
            sum = 0;
            for (int i = a; i >= 2; i--)
            {
                int c = i / 2;
                int dem = 0;
                for (int j = 2; j <= c; j++)
                {
                    if(i % j == 0)
                    {
                        dem++;
                        break;
                    }
                }
                if(dem==0)
                {
                    tkq.Items.Add(i);
                }
            }
            for(int i = 1 ; i <= b; i++)
            {
                if(i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            tsc.Text = sum.ToString();
        }

        private void tkq_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
