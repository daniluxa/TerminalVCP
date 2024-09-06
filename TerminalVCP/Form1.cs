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
        string file_name = "";
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

                    serialPort.PortName = selectedPort;
                    serialPort.Open();
                    Btn_Connect.Text = "Отключиться";
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
                    Rtb_output.AppendText("\n");
                });
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    Rtb_output.AppendText(buf[i].ToString("X2"));
                }
            }
            if(isWrite_in_file)
            {

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
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.ShowDialog();
                isWrite_in_file = true;
            }
            else
            {
                isWrite_in_file = false;
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }
    }
}
