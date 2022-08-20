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
namespace cam_bien_sieu_am_arduino
{
    public partial class Form1 : Form
    {
        private DateTime datetime;
        private string in_data;
        static SerialPort SerialPort1 = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            congcom.DataSource = SerialPort.GetPortNames(); // lấy tất cả cổng com đang nối vào trong máy tính
            string[] BoardRateArray = { "1200", "2400", "4800", "9600", "19200", "38400", "57600" };
            // thêm tốc độ PaudRead vào combobox
            com2.DataSource = BoardRateArray;
            com2.SelectedIndex = 3;//lấy giá trị mặc định của PaudRead luôn là 9600

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(SerialPort1.IsOpen)//nếu đang mở rồi thì sẽ thông báo
                {
                    MessageBox.Show("Ket noi da ton tai !!");
                }else
                {
                    SerialPort1.PortName = congcom.Text;
                    //lấy cổng com từ congcom.Text
                    SerialPort1.BaudRate = Convert.ToInt32(com2.Text);
                    //tốc độ PaudRead  lấy từ cổng PaudRead từ com2 
                    SerialPort1.Open();//mở kết nối cổng com
                    MessageBox.Show("Ket noi hoan tat !!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dong ket noi khong thanh cong !!" + ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SerialPort1.IsOpen)//nếu đã đóng rồi thì sẽ thông báo
                {
                    MessageBox.Show("Ket noi da song !!");
                }
                else
                {
                    SerialPort1.Close();//đóng kết nối cổng com
                    MessageBox.Show("Dong ket noi hoan tat !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dong ket noi khong thanh cong !!" + ex.Message);
            }
        }

        public event EventHandler OnUpdateConnection;// câu lệnh EventHandler cần tìm hiểu sau
        private void timerConnection_Tick(object sender, EventArgs e)//cứ sau 3s thì nó lại chạy 1 lần để kiểm tra
                                                                      // xem cổng kết nối hay chưa và nó sẽ thay
                                                                      //đổi câu lệnh hiện trên winform
        {
            if(this.OnUpdateConnection == null)
            {
                this.OnUpdateConnection += UpdateConnection;
            }
            this.OnUpdateConnection(this, EventArgs.Empty);// tìm hiểu câu lệnh sau
        }
        private void UpdateConnection(object sender, EventArgs e)
            //hiện trạng thái kết nối khi dây cắm hay chưa
        {
            if(SerialPort1.IsOpen)
            {
                Lon.Text = "ON";
                Lon.ForeColor = Color.Green;
            }
            else
            {
                Lon.Text = "OFF";
                Lon.ForeColor = Color.Red;
            }
        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = SerialPort1.ReadLine(); //đọc giá trị từ kết nối vào , trên arduino

            this.Invoke(new EventHandler(displaydata_event));// câu lệnh cần tìm hiểu sau
        }
        private void displaydata_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Day + "/" + datetime.Month + "/" + datetime.Year + " - " + datetime.Hour + ":" 
                + datetime.Minute + ":" + datetime.Second;
            textBox1.AppendText(time + "\t\t" + in_data + "\n");// câu lệnh nối văn bản
            /*File.AppendText () là một phương thức lớp Tệp có sẵn được sử dụng để tạo một StreamWriter nối văn 
             * bản được mã hóa UTF-8 vào một tệp hiện có, nó sẽ tạo một tệp mới nếu tệp được chỉ định không tồn 
             * tại.*/

            int data_value = Convert.ToInt32(in_data);
            progressBar1.Maximum = 500;
            progressBar1.Step = 1;
            progressBar1.Value = data_value;
            // ProgressBar để hiển thị quá trình theo phần trăm để cho biết
            // chương trình xử lý đã được bao nhiêu phần trăm, sắp xong hay chưa

            /*Minimum : Đặt giá trị nhỏ nhất cho biến Value của 1 tác vụ trên ProgressBar.
              Maximum : Đặt giá trị lớn nhất cho biến Value của 1 tác vụ trên ProgressBar.
              Value   : Thuộc tính này là giá trị hiện tại của 1 tác vụ trên ProgressBar.*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SerialPort1.Parity = Parity.None;// câu lệnh cần tìm hiểu
            SerialPort1.StopBits = StopBits.One;
            SerialPort1.DataReceived += myport_DataReceived;
            
        }
    }
}
