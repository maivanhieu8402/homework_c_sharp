using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)//nếu đang mở rồi thì sẽ thông báo
                {
                    MessageBox.Show("Ket noi da ton tai !!", "thong bao");
                }
                else
                {
                    serialPort1.Close();
                    MessageBox.Show("Dong ket noi hoan tat !!", "thong bao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dong ket noi khong thanh cong !!" + ex.Message);
            }
            ton.Clear();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)//nếu đang mở rồi thì sẽ thông báo
                {
                    MessageBox.Show("Ket noi da ton tai !!", "thong bao");
                }
                else
                {
                    serialPort1.PortName = congcom.Text;
                    //lấy cổng com từ congcom.Text
                    serialPort1.BaudRate = Convert.ToInt32(cong2.Text);
                    //tốc độ PaudRead  lấy từ cổng PaudRead từ com2 
                    serialPort1.Open();//mở kết nối cổng com
                    timer1.Start();
                    MessageBox.Show("Ket noi hoan tat !!", "thong bao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi khong thanh cong !!" + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            congcom.DataSource = SerialPort.GetPortNames(); // lấy tất cả cổng com đang nối vào trong máy tính
            string[] BoardRateArray = { "1200", "2400", "4800", "9600", "19200", "38400", "57600" };
            // thêm tốc độ PaudRead vào combobox
            cong2.DataSource = BoardRateArray;
            cong2.SelectedIndex = 3;//lấy giá trị mặc định của PaudRead luôn là 9600
        }
        //public event EventHandler Timer;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                tton.Text = "ON";
                tton.ForeColor = Color.Green;
                ton.Text = serialPort1.ReadExisting();
                int number = int.Parse(ton.Text);
                if (ton.Text != null)
                {
                    //var number = Convert.ToDouble(ton.Text);
                    if (number < 150)
                    {
                        ton.BackColor = Color.Green;
                        ton.ForeColor = Color.Green;
                    }
                    else if (number > 800)
                    {
                        ton.BackColor = Color.Red;
                        ton.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                tton.Text = "OFF";
                tton.ForeColor = Color.Red;
            }
        }
        /*private void UpdateConnection(object sender, EventArgs e)//hiện trạng thái kết nối khi dây cắm hay chưa
        {
            
        }*/
    }
}
