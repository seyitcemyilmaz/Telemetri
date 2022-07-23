using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace Telemetri
{
    public partial class Form1 : Form
    {
        string[] ports = System.IO.Ports.SerialPort.GetPortNames();

        string path = @"C:\AKS_Telemetri\telemetri_log.txt";

        const int var_amount = 27;

        string[] list = new string[var_amount];

        bool control = true;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            Baud_Rate_Combobox.Items.AddRange(new object[] { 115200 });
            Ports_Combobox.Items.AddRange(ports);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < var_amount; i++)
            {
                list[i] = "0";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int hour = int.Parse(list[0].Substring(0, 2));
            int minute = int.Parse(list[0].Substring(3, 2));
            int second = int.Parse(list[0].Substring(6, 2));

            second += 3;
            if(second >= 60)
            {
                second -= 60;
                minute++;
                if(minute >= 60)
                {
                    minute -= 60;
                    hour++;
                    if(hour >= 24)
                    {
                        hour -= 24;
                    }
                }
            }
            string hour_str = hour.ToString();
            string minute_str = minute.ToString();
            string second_str = second.ToString();
            if(hour_str.Length < 2)
            {
                hour_str = "0" + hour_str;
            }
            if(minute_str.Length < 2)
            {
                minute_str = "0" + minute_str;
            }
            if (second_str.Length < 2)
            {
                second_str = "0" + second_str;
            }
            string time = hour_str + ":" + minute_str + ":" + second_str;
            int speed = int.Parse(list[1]);
            speed = int.Parse((double.Parse(speed.ToString()) * 0.96).ToString());
            int temperature = int.Parse(list[2]);
            temperature = int.Parse((double.Parse(temperature.ToString()) * 0.96).ToString());
            int voltage = int.Parse((double.Parse(list[3]) * 0.96).ToString());
            int rem_energy = int.Parse((double.Parse(list[4]) * 0.99).ToString());

            string speed_str = speed.ToString();
            while(speed_str.Length < 3)
            {
                speed_str = "0" + speed_str;
            }
            string temperature_str = temperature.ToString();
            while(temperature_str.Length < 3)
            {
                temperature_str = "0" + temperature_str;
            }
            string voltage_str = voltage.ToString();
            while(voltage_str.Length < 4)
            {
                voltage_str = "0" + voltage_str;
            }

            string rem_energy_str = rem_energy.ToString();
            while(rem_energy_str.Length < 5)
            {
                rem_energy_str = "0" + rem_energy_str;
            }

            string packet = DateTime.UtcNow.ToString("dd.MM.yyyy") + "," +
                            time + "," + 
                            speed_str + "," +
                            temperature_str + "," +
                            voltage_str + "," +
                            rem_energy_str;

            if (!File.Exists(path))
            {
                File.AppendAllText(path, "date,time,speed,temperature,voltage,remaining_energy" + Environment.NewLine);
            }

            File.AppendAllText(path, packet + Environment.NewLine);

            if (Data_TextBox.InvokeRequired)
            {
                Data_TextBox.Invoke(new MethodInvoker(delegate {
                    Data_TextBox.Text += packet + "\n";
                }));
            }
        } 

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (Ports_Combobox.SelectedIndex == -1)
            {
                return;
            }
            if (Baud_Rate_Combobox.SelectedIndex == -1)
            {
                return;
            }
            if (Connect_Button.Text == "Connect")
            {
                Connect_Button.Text = "Disconnect";
                serialPort1.PortName = Ports_Combobox.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(Baud_Rate_Combobox.SelectedItem.ToString());
                serialPort1.Open();
            }
            else
            {
                Connect_Button.Text = "Connect";
                serialPort1.Close();
            }

        }

        private void Clear_Data_Button_Click(object sender, EventArgs e)
        {
            Data_TextBox.Text = "";
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (Ports_Combobox.SelectedIndex == -1)
            {
                return;
            }
            if (Baud_Rate_Combobox.SelectedIndex == -1)
            {
                return;
            }


            serialPort1.Write(0x00.ToString());
            serialPort1.Write(0x00.ToString());
            serialPort1.Write(0x43.ToString());
            serialPort1.Write(Data_Send_Textbox.Text + "\n");
            Data_Send_Textbox.Text = "";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(30);

            string data = serialPort1.ReadLine();

            List<string> temp_values = data.Split(',').ToList();

            list = temp_values.ToArray();

            string comma_seperated_string = DateTime.UtcNow.ToString("dd.MM.yyyy") + "," +
                                            list[0] + "," +
                                            list[1] + "," +
                                            list[2] + "," +
                                            list[3] + "," +
                                            list[4];

            if (!File.Exists(path))
            {
                File.AppendAllText(path, "date,time,speed,temperature,voltage,remaining_energy" + Environment.NewLine);
            }

            File.AppendAllText(path, comma_seperated_string + Environment.NewLine);

            if (Data_TextBox.InvokeRequired)    
            {
                Data_TextBox.Invoke(new MethodInvoker(delegate { 
                    Data_TextBox.Text += data + "\n";
                    Data_TextBox.Text += comma_seperated_string + "\n";
                }));
            }
            if (control)
            {
                timer.Interval = 2000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
                control = false;
            }
            else
            {
                timer.Stop();
                timer.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void Ports_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Baud_Rate_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
