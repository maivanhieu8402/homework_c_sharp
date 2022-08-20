using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4_31_32
{
    public partial class Form1 : Form
    {
        public int ngayden,ngaydi,tinhtien;

        private void button2_Click(object sender, EventArgs e)
        {
            tname.Text = "";
            tdiachi.Text = "";
            tnden.Text = "";
            tndi.Text = "";
            tndent.Text = "";
            tndenn.Text = "";
            tndit.Text = "";
            tndin.Text = "";
            ttinhtien.Items.Clear();
            rpdoi.Checked = false;
            rpdon.Checked = false;
            cinternet.Checked = false;
            cgiatna.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ttinhtien.Items.Add("ho va ten : " + tname.Text);
            ttinhtien.Items.Add("dia chi  : " + tdiachi.Text);
            ttinhtien.Items.Add("ngay den  : " + tnden.Text +"/"+ tndent.Text +"/"+ tndenn.Text);
            ttinhtien.Items.Add("ngay di  : " + tndi.Text + "/" + tndit.Text + "/" + tndin.Text);
            if(rpdon.Checked == true)//200k
            {
                ttinhtien.Items.Add("loai phong : phong don" );
                if (cinternet.Checked == true)//50k
                {
                    if (cgiatna.Checked == true)//50k
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet + giat na");
                        ttinhtien.Items.Add("thanh toan : 300k (phong don : 200k + internet : 50k + giatla : 50k");
                    }
                    else
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet");
                        ttinhtien.Items.Add("thanh toan : 250k (phong don : 200k + internet : 50k");
                    }
                }else if(cgiatna.Checked == true)
                {
                    if(cinternet.Checked == true)
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet + giat na");
                        ttinhtien.Items.Add("thanh toan : 300k (phong don : 200k + internet : 50k + giatla : 50k");
                    }else
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet + giat na");
                        ttinhtien.Items.Add("thanh toan : 250k (phong don : 200k + giatla : 50k");
                    }
                }
            }
            else if(rpdoi.Checked == true)//300k
            {
                ttinhtien.Items.Add("loai phong : phong doi");
                if (cinternet.Checked == true)//50k
                {
                    if (cgiatna.Checked == true)//50k
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet + giat na");
                        ttinhtien.Items.Add("thanh toan : 400k (phong doi : 200k + internet : 50k + giatla : 50k");
                    }
                    else
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet");
                        ttinhtien.Items.Add("thanh toan : 350k (phong doi : 200k + internet : 50k");
                    }
                }
                else if (cgiatna.Checked == true)
                {
                    if (cinternet.Checked == true)
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet + giat na");
                        ttinhtien.Items.Add("thanh toan : 400k (phong doi : 200k + internet : 50k + giatla : 50k");
                    }
                    else
                    {
                        ttinhtien.Items.Add("loai dich vu su dung : internet + giat na");
                        ttinhtien.Items.Add("thanh toan : 350k (phong doi : 200k + giatla : 50k");
                    }
                }
            }
            
        }
    }
}
