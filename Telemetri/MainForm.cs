using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using static Telemetri.Packet;
using static Telemetri.Data;

namespace Telemetri
{
    public partial class MainForm : Form
    {
        List<string> ports = SerialPort.GetPortNames().ToList();

        string defaultPath = @"C:\AKS_Telemetri";
        string defaultFullLogFile = @"telemetri_log.txt";
        string defaultTubitakLogFile = @"tubitak_log.txt";

        public MainForm()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts

            InitializeComponent();

            BaudRate_Combobox.Items.AddRange(new object[] { 9600, 115200 });
            Ports_Combobox.Items.AddRange(ports.ToArray());

            Packet.datas = new List<Data> {
                new Data("Time", "GMT+3", "time", DataTypes.eString),
                new Data("Speed", "km/h", "speed", DataTypes.eINT),
                new Data("Max Temperature", "°C", "temperature", DataTypes.eINT),
                new Data("Total Voltage", "V", "voltage", DataTypes.eFLOAT_2),
                new Data("Remaining Energy", "Wh", "remainingEnergy", DataTypes.eFLOAT_2),
                new Data("State of Charge", "%", "stateOfCharge", DataTypes.eFLOAT_2),
                new Data("Current", "A", "current", DataTypes.eFLOAT_2)
            };

            Packet.variableCount = Packet.datas.Count;

            CreateColumns();
            ResizeDataGridViews();

            DataGridViewRow row = new DataGridViewRow();
            for (int i = 0; i < variableCount; i++)
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = i;
                row.Cells.Add(cell);
            }
            row.Height = 50;
            PacketVariablesDataGridView.Rows.Add(row);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FullLogFile_Textbox.Text = defaultPath + @"\" + defaultFullLogFile;
            TubitakLogFile_Textbox.Text = defaultPath + @"\" + defaultTubitakLogFile;
        }

        private void SelectLogFile_Button_Click(object sender, EventArgs e)
        {
            if (Connect_Button.Text == "Disconnect")
            {
                return;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FullLogFile_Textbox.Text = folderBrowserDialog.SelectedPath + @"\" + defaultFullLogFile;
                TubitakLogFile_Textbox.Text = folderBrowserDialog.SelectedPath + @"\" + defaultTubitakLogFile;
            }
        }

        private void Ports_Combobox_Click(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames().ToList();
            Ports_Combobox.Items.Clear();
            Ports_Combobox.Items.AddRange(ports.ToArray());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activeSerialPort.IsOpen == true)
            {
                activeSerialPort.Close();
            }
        }

        private void ClearData_Button_Click(object sender, EventArgs e)
        {
            Data_TextBox.Text = "";
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (Ports_Combobox.SelectedIndex == -1)
            {
                return;
            }
            if (BaudRate_Combobox.SelectedIndex == -1)
            {
                return;
            }
            if (Connect_Button.Text == "Connect")
            {
                Connect_Button.Text = "Disconnect";
                activeSerialPort.PortName = Ports_Combobox.SelectedItem.ToString();
                activeSerialPort.BaudRate = Convert.ToInt32(BaudRate_Combobox.SelectedItem.ToString());
                activeSerialPort.Open();
                Ports_Combobox.Enabled = false;
                BaudRate_Combobox.Enabled = false;
                FullLogFile_Textbox.Enabled = false;
                TubitakLogFile_Textbox.Enabled = false;
            }
            else
            {
                Connect_Button.Text = "Connect";
                activeSerialPort.Close();
                Ports_Combobox.Enabled = true;
                BaudRate_Combobox.Enabled = true;
                FullLogFile_Textbox.Enabled = true;
                TubitakLogFile_Textbox.Enabled = true;
            }

        }

        private void ActiveSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = activeSerialPort.ReadLine();
            /*
            List<string> temp_values = data.Split(',').ToList();

            if (temp_values.Count != varAmount)
            {
                return;
            }

            list = temp_values.ToArray();

            Packet.time = list[(int)Indexes.timeIndex];
            Packet.speed = list[(int)Indexes.speedIndex];
            Packet.maxTemperature = list[(int)Indexes.maxTemperatureIndex];
            Packet.totalVoltage = list[(int)Indexes.totalVoltageIndex];
            Packet.remainingEnergy = list[(int)Indexes.remainingEnergyIndex];
            Packet.stateOfCharge = list[(int)Indexes.stateOfChargeIndex];
            Packet.current = list[(int)Indexes.currentIndex];

            for (int i = 0; i < Packet.batteryCount; i++)
            {
                Packet.batteryVoltages[i] = list[(int)Indexes.batteryVoltagesStartIndex + i];
            }

            Packet.checksum = list[(int)Indexes.checksumIndex];








            /*
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

            File.AppendAllText(path, data + Environment.NewLine);
            if (Data_TextBox.InvokeRequired)
            {
                Data_TextBox.Invoke(new MethodInvoker(delegate
                {
                    Data_TextBox.Text += data + "\n";
                }));
            }
            */
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Button_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea; // Avoids covering of the taskbar.
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ResizeDataGridViews()
        {
            int columnCount = BatteryCellDataGridView0.ColumnCount;
            int totalWidth = BatteryCellDataGridView0.Width;
            int width = totalWidth / columnCount;

            for (int i = 0; i < columnCount; i++)
            {
                BatteryCellDataGridView0.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                BatteryCellDataGridView0.Columns[i].Width = width;
            }

            columnCount = BatteryCellDataGridView1.ColumnCount;
            totalWidth = BatteryCellDataGridView1.Width;
            width = totalWidth / columnCount;

            for (int i = 0; i < columnCount; i++)
            {
                BatteryCellDataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                BatteryCellDataGridView1.Columns[i].Width = width;
            }

            columnCount = PacketVariablesDataGridView.ColumnCount;
            totalWidth = PacketVariablesDataGridView.Width;
            width = totalWidth / columnCount;

            for (int i = 0; i < columnCount; i++)
            {
                PacketVariablesDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                PacketVariablesDataGridView.Columns[i].Width = width;
            }
        }

        private void CreateColumns()
        {
            for (int i = 0; i < 10; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "cell" + i.ToString();
                column.HeaderText = "Cell " + i.ToString();
                BatteryCellDataGridView0.Columns.Add(column);
            }

            for (int i = 0; i < 10; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "cell" + (i + 10).ToString();
                column.HeaderText = "Cell " + (i + 10).ToString();
                BatteryCellDataGridView1.Columns.Add(column);
            }

            for (int i = 0; i < Packet.variableCount; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = Packet.datas[i].varName;
                column.HeaderText = Packet.datas[i].name + " (" + Packet.datas[i].unit + ")";
                PacketVariablesDataGridView.Columns.Add(column);
            }
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }

        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                base.OnMouseDown(e);
                if (e.Button == MouseButtons.Left)
                {
                    this.Capture = false;
                    Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                    this.WndProc(ref msg);
                }
            }
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;

                ResizeDataGridViews();
            }
        }
    }
}
