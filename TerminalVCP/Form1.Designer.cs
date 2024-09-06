namespace TerminalVCP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Cmb_VCP = new System.Windows.Forms.ComboBox();
            this.Tb_Amout_of_bytes = new System.Windows.Forms.TextBox();
            this.Rtb_output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.Cmb_vcp_baud_rate = new System.Windows.Forms.ComboBox();
            this.Cmb_vcp_stop_bits = new System.Windows.Forms.ComboBox();
            this.Cmb_vcp_parity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Chb_add_log = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 14);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(75, 21);
            this.Btn_Refresh.TabIndex = 0;
            this.Btn_Refresh.Text = "Обновить";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(164, 14);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(101, 21);
            this.Btn_Connect.TabIndex = 1;
            this.Btn_Connect.Text = "Подключиться";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Cmb_VCP
            // 
            this.Cmb_VCP.FormattingEnabled = true;
            this.Cmb_VCP.Location = new System.Drawing.Point(93, 14);
            this.Cmb_VCP.Name = "Cmb_VCP";
            this.Cmb_VCP.Size = new System.Drawing.Size(65, 21);
            this.Cmb_VCP.TabIndex = 2;
            // 
            // Tb_Amout_of_bytes
            // 
            this.Tb_Amout_of_bytes.Location = new System.Drawing.Point(389, 93);
            this.Tb_Amout_of_bytes.Name = "Tb_Amout_of_bytes";
            this.Tb_Amout_of_bytes.Size = new System.Drawing.Size(74, 20);
            this.Tb_Amout_of_bytes.TabIndex = 3;
            this.Tb_Amout_of_bytes.Text = "15";
            // 
            // Rtb_output
            // 
            this.Rtb_output.Location = new System.Drawing.Point(12, 58);
            this.Rtb_output.Name = "Rtb_output";
            this.Rtb_output.Size = new System.Drawing.Size(355, 380);
            this.Rtb_output.TabIndex = 4;
            this.Rtb_output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во байт \r\nна строке";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort
            // 
            this.serialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort_ErrorReceived);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Cmb_vcp_baud_rate
            // 
            this.Cmb_vcp_baud_rate.FormattingEnabled = true;
            this.Cmb_vcp_baud_rate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.Cmb_vcp_baud_rate.Location = new System.Drawing.Point(389, 12);
            this.Cmb_vcp_baud_rate.Name = "Cmb_vcp_baud_rate";
            this.Cmb_vcp_baud_rate.Size = new System.Drawing.Size(74, 21);
            this.Cmb_vcp_baud_rate.TabIndex = 6;
            this.Cmb_vcp_baud_rate.Text = "115200";
            // 
            // Cmb_vcp_stop_bits
            // 
            this.Cmb_vcp_stop_bits.FormattingEnabled = true;
            this.Cmb_vcp_stop_bits.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2"});
            this.Cmb_vcp_stop_bits.Location = new System.Drawing.Point(389, 39);
            this.Cmb_vcp_stop_bits.Name = "Cmb_vcp_stop_bits";
            this.Cmb_vcp_stop_bits.Size = new System.Drawing.Size(74, 21);
            this.Cmb_vcp_stop_bits.TabIndex = 7;
            this.Cmb_vcp_stop_bits.Text = "1";
            // 
            // Cmb_vcp_parity
            // 
            this.Cmb_vcp_parity.FormattingEnabled = true;
            this.Cmb_vcp_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Cmb_vcp_parity.Location = new System.Drawing.Point(389, 66);
            this.Cmb_vcp_parity.Name = "Cmb_vcp_parity";
            this.Cmb_vcp_parity.Size = new System.Drawing.Size(74, 21);
            this.Cmb_vcp_parity.TabIndex = 8;
            this.Cmb_vcp_parity.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "BaudRate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stop bits";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(271, 15);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(96, 20);
            this.Btn_Clear.TabIndex = 12;
            this.Btn_Clear.Text = "Очистить";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Chb_add_log
            // 
            this.Chb_add_log.AutoSize = true;
            this.Chb_add_log.Location = new System.Drawing.Point(389, 139);
            this.Chb_add_log.Name = "Chb_add_log";
            this.Chb_add_log.Size = new System.Drawing.Size(101, 17);
            this.Chb_add_log.TabIndex = 13;
            this.Chb_add_log.Text = "Запись в файл";
            this.Chb_add_log.UseVisualStyleBackColor = true;
            this.Chb_add_log.CheckedChanged += new System.EventHandler(this.Chb_add_log_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.Chb_add_log);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_vcp_parity);
            this.Controls.Add(this.Cmb_vcp_stop_bits);
            this.Controls.Add(this.Cmb_vcp_baud_rate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rtb_output);
            this.Controls.Add(this.Tb_Amout_of_bytes);
            this.Controls.Add(this.Cmb_VCP);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.Btn_Refresh);
            this.Name = "Form1";
            this.Text = "Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.ComboBox Cmb_VCP;
        private System.Windows.Forms.TextBox Tb_Amout_of_bytes;
        private System.Windows.Forms.RichTextBox Rtb_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox Cmb_vcp_baud_rate;
        private System.Windows.Forms.ComboBox Cmb_vcp_stop_bits;
        private System.Windows.Forms.ComboBox Cmb_vcp_parity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.CheckBox Chb_add_log;
    }
}

