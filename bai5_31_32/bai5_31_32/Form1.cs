using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5_31_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cgt.Items.Add("");
            cgt.Items.Add("Nữ");
            cgt.Items.Add("Nam");
            cccb.Items.Add("");
            cccb.Items.Add("Lớp Trưởng");
            cccb.Items.Add("Lớp Phó");
            cccb.Items.Add("Bí Thư");
            cccb.Items.Add("Lớp Phó Học Tập");
            cccb.Items.Add("Lớp Phó Lao Động");
            cccb.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            thienthi.Items.Add("Họ Tên : " + tname.Text);
            thienthi.Items.Add("Mã Sinh Viên : " + tmsv.Text);
            thienthi.Items.Add("Ngành : " + tn.Text);
            thienthi.Items.Add("Điểm : " + td.Text);
            thienthi.Items.Add("Xếp Loại : " + txl.Text);
            thienthi.Items.Add("Giới Tính : " + cgt.Text);
            thienthi.Items.Add("Năm Sinh : " + tns.Text);
            if (ccb.Checked == true)
            {
                thienthi.Items.Add("Cán Bộ : " + cccb.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thienthi.Items.Clear();
            tname.Text = "";
            tmsv.Text = "";
            td.Text = "";
            txl.Text = "";
            tn.Text = "";
            tns.Text = "";
            ccb.Checked = false;
            cgt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tname.Text = "";
            tmsv.Text = "";
            td.Text = "";
            txl.Text = "";
            tn.Text = "";
            tns.Text = "";
            cgt.Text = "";
            if (ccb.Checked == true)
            {
                cccb.Text = "";
                ccb.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ccb_CheckedChanged(object sender, EventArgs e)
        {
            if (ccb.Checked == true)
            {
                cccb.Visible = true;
            } else if (ccb.Checked == false)
            {
                cccb.Visible = false;
            }
        }
    }
}
