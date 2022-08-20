using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace DHT11_View
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private DateTime datetime;
        private string in_data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {

            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = comboBox_port.Text;
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.DataReceived += myport_DataReceived;

                try
                {
                    myport.Open();
                    textBox_value.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn Port","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {           
            in_data = myport.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Day+"/"+ datetime.Month + "/" + datetime.Year + " - " + datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            textBox_value.AppendText(time + "\t\t" + in_data+"\n");
            
            int data_value = Convert.ToInt32(in_data);
            progressBar_value.Maximum = 100;
            progressBar_value.Step = 1;
            progressBar_value.Value = data_value;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
