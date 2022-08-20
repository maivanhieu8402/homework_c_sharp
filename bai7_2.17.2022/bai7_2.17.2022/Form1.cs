using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7_2._17._2022
{
    public partial class Form1 : Form
    {
        public double tien,tiengiam,tongtien,tongtien1,tienvat,tiengia,h,k;
        public int a, b, c, d;
        public int z,x;

        private void button2_Click(object sender, EventArgs e)
        {
            nguoiban.Text = "";
            ngayban.Text = "";
            cthit.Checked = false;
            cca.Checked = false;
            crx.Checked = false;
            cb.Checked = false;
            ccc.Checked = false;
            cnk.Checked = false;
            thit.Visible = false;
            ca.Visible = false;
            rauxanh.Visible = false;
            coca.Visible = false;
            nuockhoang.Visible = false;
            bia.Visible = false;
            rtt.Checked = false;
            rt.Checked = false;
            tienkhachtra.Text = "";
            tinhtien.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
            thit.Visible = false;
            ca.Visible = false;
            rauxanh.Visible = false;
            coca.Visible = false;
            nuockhoang.Visible = false;
            bia.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tinhtien.Items.Add("Người Bán : " + nguoiban.Text);
            tinhtien.Items.Add("Ngày Mua : " + ngayban.Text);
            tinhtien.Items.Add("Mặt Hàng      Đơn Giá      Số Lượng      Tính Tiền ");
            tien = 0;
            tiengiam = 0;
            if (cthit.Checked == true)//thit 60k
            {
                a = int.Parse(thit.Text);
                tien = tien + (60 * a);
                tinhtien.Items.Add("Thịt       60.000      " + thit.Text + "      " + tien);
            }
            if(cca.Checked == true)//ca 50k
            {
                b = int.Parse(ca.Text);
                tien = tien + (b * 50);
                tinhtien.Items.Add("Cá       50.000      " + ca.Text + "      " + tien);
            }
            if (crx.Checked == true)//rauxanh 10k
            {
                c = int.Parse(rauxanh.Text);
                tien = tien + (b * 10);
                tinhtien.Items.Add("Rau Xanh      10.000      " + rauxanh.Text + "      " + tien);
            }
            if (ccc.Checked == true)//coca 10k
            {
                d = int.Parse(coca.Text);
                tien = tien + (d * 10);
                tinhtien.Items.Add("cocacola      10.000      " + coca.Text + "      " + tien);
            }
            if (cb.Checked == true)//bia 15k
            {
                z = int.Parse(bia.Text);
                tien = tien + (z * 15);
                tinhtien.Items.Add("Bia       15.000      " + bia.Text + "      " + tien);
            }
            if (cnk.Checked == true)//bia 10k
            {
                x = int.Parse(nuockhoang.Text);
                tien = tien + (x * 10);
                tinhtien.Items.Add("Nước Khoáng      10.000      " + nuockhoang.Text + "      " + tien);
            }
            if(rtt.Checked == true)
            {
                tiengiam = tiengiam + tien * 0.1;
            }
            h = double.Parse(tienkhachtra.Text);
            tongtien = tien - tiengiam;
            tienvat = tongtien * 0.1;
            tongtien1 = tongtien - tienvat;
            tiengia = h - tongtien1;
            k = h - tiengia;
            tinhtien.Items.Add("Tiền Phải Thanh Toán :                                " + tongtien1);
            tinhtien.Items.Add("Tổng Đã Tiền Giảm :                                " + tiengiam);
            tinhtien.Items.Add("Tổng Tiền Thuế Đã Giảm :                                " + tienvat);
            tinhtien.Items.Add("Tiền Khách Trả :                                " + tienkhachtra.Text);
            tinhtien.Items.Add("tiền giả :                                " + tiengia);
            tinhtien.Items.Add("tiền khách còn lại :                                " + k);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cthit_CheckedChanged(object sender, EventArgs e)
        {
            if (cthit.Checked == true)
            {
                thit.Visible = true;
            }else if(cthit.Checked == false)
            {
                thit.Visible = false;
            }
        }

        private void cca_CheckedChanged(object sender, EventArgs e)
        {
            if (cca.Checked == true)
            {
                ca.Visible = true;
            }else if(cca.Checked == false)
            {
                ca.Visible = false;
            }
        }

        private void crx_CheckedChanged(object sender, EventArgs e)
        {
            if (crx.Checked == true)
            {
                rauxanh.Visible = true;
            }else if(crx.Checked == false)
            {
                rauxanh.Visible = false;
            }
        }

        private void ccc_CheckedChanged(object sender, EventArgs e)
        {
            if (ccc.Checked == true)
            {
                coca.Visible = true;
            }else if(ccc.Checked == false)
            {
                coca.Visible = false;
            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked == true)
            {
                bia.Visible = true;
            }else if(cb.Checked == false)
            {
                bia.Visible = false;
            }
        }

        private void nuockhoang_TextChanged(object sender, EventArgs e)
        {
            if (cnk.Checked == true)
            {
                nuockhoang.Visible = true;
            }else if(cnk.Checked == false)
            {
                nuockhoang.Visible = false;
            }
        }
    }
}
