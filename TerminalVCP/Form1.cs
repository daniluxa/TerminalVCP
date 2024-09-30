using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace TerminalVCP
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        bool isWrite_in_file = false;
        public Form1()
        {
            InitializeComponent();
            //Btn_Refresh.PerformClick();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Cmb_VCP.Items.Clear();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0)
            {
                MessageBox.Show("Нет доступных COM-портов");
            }
            foreach (string portName in portnames)
            {   
                Cmb_VCP.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    Cmb_VCP.SelectedItem = portnames[0];
                }
            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                isConnected = true;
                string selectedPort = Cmb_VCP.GetItemText(Cmb_VCP.SelectedItem);
                if (selectedPort.Length != 0)
                {
                    try
                    {
                        serialPort.BaudRate = Convert.ToInt32(Cmb_vcp_baud_rate.Text);
                        serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Cmb_vcp_stop_bits.Text);
                        serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), Cmb_vcp_parity.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Поля настроек COM-порта не должны быть пустыми!");
                    }
                    try
                    {
                        serialPort.PortName = selectedPort;
                        serialPort.Open();
                        Btn_Connect.Text = "Отключиться";
                    }
                    catch(Exception ex)
                    {  
                        MessageBox.Show(ex.ToString()); 
                    }
                }
            }
            else
            {
                isConnected = false;
                string selectedPort = Cmb_VCP.GetItemText(Cmb_VCP.SelectedItem);
                serialPort.Close();
                Btn_Connect.Text = "Подключиться";
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Rtb_output.Clear();
        }


        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //string data = sp.ReadExisting();

            int length = sp.BytesToRead;
            byte[] buf = new byte[length];

            sp.Read(buf, 0, length);

            if (Rtb_output.InvokeRequired)
            {
                Rtb_output.Invoke((MethodInvoker)delegate
                {
                    for (int i = 0; i < length; i++)
                    {
                        Rtb_output.AppendText(buf[i].ToString("X2") + " ");
                    }
                    //Rtb_output.AppendText("\n");
                });
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    Rtb_output.AppendText(buf[i].ToString("X2"));
                }
                Rtb_output.AppendText("\n");
            }
            if(isWrite_in_file)
            {
                string file_name = @Tb_log_file_name.Text + ".txt";
                if (!File.Exists(file_name)) // If file does not exists
                {
                    File.Create(file_name).Close(); // Create file
                    using (StreamWriter sw = File.AppendText(file_name))
                    {
                        for (int i = 0; i < length; i++)
                        {
                            sw.Write(buf[i].ToString("X2") + " ");
                        }
                        sw.Write(DateTime.Now + "\n");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(file_name))
                    {
                        for (int i = 0; i < length; i++)
                        {
                            sw.Write(buf[i].ToString("X2") + " ");
                        }
                        sw.Write(DateTime.Now + "\n");
                    }
                }
            }
        }

        private void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Serial port error: " + e.EventType);
        }

        private void Chb_add_log_CheckedChanged(object sender, EventArgs e)
        {
            if(Chb_add_log.CheckState == CheckState.Checked)
            {
                //SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                //SaveFileDialog1.ShowDialog();
                Tb_log_file_name.Visible = true;
                label_file_log_name.Visible = true;
                isWrite_in_file = true;
            }
            else
            {
                Tb_log_file_name.Visible = false;
                label_file_log_name.Visible = false;
                isWrite_in_file = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            ////string data = "AA 55 33 00 03 10 05 01 11 00 01 00 00 00 00\r\nAA 55 42 15 01 14 04 01 11 00 01 00 00 00 00\r\nAA 55 3D 11 02 10 04 01 11 00 01 00 00 00 00\r\nAA 55 44 11 02 10 04 01 11 00 00 00 00 00 00";
            //byte[] buf1 = { 0xAA, 0x55 ,0x33 ,0x00 ,0x03 ,0x10 ,0x05 ,0x01 ,0x11 ,0x00 ,0x01 ,0x00 ,0x00 ,0x00 ,0x00};
            //byte[] buf2 = { 0xAA, 0x55 ,0x44 ,0x11 ,0x02 ,0x10 ,0x04 ,0x01 ,0x11 ,0x00 ,0x00 ,0x00 ,0x00 ,0x00 ,0x00};
            //byte[] buf3 = { 0xAA, 0x55 ,0x42 ,0x15 ,0x01 ,0x14 ,0x04 ,0x01 ,0x11 ,0x00 ,0x01 ,0x00 ,0x00 ,0x00 ,0x00};
            //byte[] buf4 = { 0xAA, 0x55 ,0x3D ,0x11 ,0x02 ,0x10 ,0x04 ,0x01 ,0x11 ,0x00 ,0x01 ,0x00 ,0x00 ,0x00 ,0x00};
            //while (true)
            //{
            //    try
            //    {
            //        serialPort.Write(buf1, 0, buf1.Length);
            //        //System.Threading.Thread.Sleep(10);
            //        serialPort.Write(buf2, 0, buf2.Length);
            //        //System.Threading.Thread.Sleep(10);
            //        serialPort.Write(buf3, 0, buf3.Length);
            //        //System.Threading.Thread.Sleep(10);
            //        serialPort.Write(buf4, 0, buf4.Length);
            //        //System.Threading.Thread.Sleep(10);

            //        //System.Threading.Thread.Sleep(1000);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }
    }
}
