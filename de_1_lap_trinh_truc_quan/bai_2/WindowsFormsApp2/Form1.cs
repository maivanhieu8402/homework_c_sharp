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
        public double sodau, socuoi,tong;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tsd.Text = "";
            tsc.Text = "";
            hienthi.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn thoát chương trình !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sodau = double.Parse(tsd.Text);
                socuoi = double.Parse(tsc.Text);
            }
            catch(Exception a)
            {
                DialogResult dlr = MessageBox.Show("Bạn vừa nhập sai thông số !!",
                     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                {

                }
                else
                {
                    tsd.Text = "";
                    tsc.Text = "";
                }
            }
            int b = Convert.ToInt32(tong);
            if (sodau < socuoi && sodau >= 0)
            {
                tong = sodau + socuoi;
                for (int i = Convert.ToInt32(sodau); i <= tong; i++)
                {
                    hienthi.Items.Add(i);
                }
            }
        }
    }
}
