namespace Telemetri
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.activeSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.COMPort_Label = new System.Windows.Forms.Label();
            this.BaudRate_Label = new System.Windows.Forms.Label();
            this.Minimize_Button = new System.Windows.Forms.PictureBox();
            this.Maximize_Button = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new System.Windows.Forms.PictureBox();
            this.TopRight_Panel = new System.Windows.Forms.Panel();
            this.Ports_Combobox = new System.Windows.Forms.ComboBox();
            this.BaudRate_Combobox = new System.Windows.Forms.ComboBox();
            this.Settings_Panel = new System.Windows.Forms.Panel();
            this.SelectLogFile_Button = new System.Windows.Forms.PictureBox();
            this.TubitakLogFile_Textbox = new System.Windows.Forms.TextBox();
            this.TubitakLogFile_Label = new System.Windows.Forms.Label();
            this.FullLogFile_Textbox = new System.Windows.Forms.TextBox();
            this.FullLogFile_Label = new System.Windows.Forms.Label();
            this.Header_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.ClearData_Button = new System.Windows.Forms.Button();
            this.Packet_TextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PacketVariablesDataGridView = new System.Windows.Forms.DataGridView();
            this.BatteryCellDataGridView0 = new System.Windows.Forms.DataGridView();
            this.BatteryCellDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.TopRight_Panel.SuspendLayout();
            this.Settings_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLogFile_Button)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacketVariablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryCellDataGridView0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryCellDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // activeSerialPort
            // 
            this.activeSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ActiveSerialPort_DataReceived);
            // 
            // COMPort_Label
            // 
            this.COMPort_Label.AutoSize = true;
            this.COMPort_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.COMPort_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.COMPort_Label.Location = new System.Drawing.Point(7, 10);
            this.COMPort_Label.Name = "COMPort_Label";
            this.COMPort_Label.Size = new System.Drawing.Size(97, 24);
            this.COMPort_Label.TabIndex = 0;
            this.COMPort_Label.Text = "COM Port:";
            // 
            // BaudRate_Label
            // 
            this.BaudRate_Label.AutoSize = true;
            this.BaudRate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BaudRate_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BaudRate_Label.Location = new System.Drawing.Point(2, 49);
            this.BaudRate_Label.Name = "BaudRate_Label";
            this.BaudRate_Label.Size = new System.Drawing.Size(102, 24);
            this.BaudRate_Label.TabIndex = 1;
            this.BaudRate_Label.Text = "Baud Rate:";
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Image = global::Telemetri.Properties.Resources.minimize;
            this.Minimize_Button.Location = new System.Drawing.Point(0, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(50, 50);
            this.Minimize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize_Button.TabIndex = 12;
            this.Minimize_Button.TabStop = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Maximize_Button
            // 
            this.Maximize_Button.Image = global::Telemetri.Properties.Resources.maximize;
            this.Maximize_Button.Location = new System.Drawing.Point(56, 3);
            this.Maximize_Button.Name = "Maximize_Button";
            this.Maximize_Button.Size = new System.Drawing.Size(50, 50);
            this.Maximize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximize_Button.TabIndex = 11;
            this.Maximize_Button.TabStop = false;
            this.Maximize_Button.Click += new System.EventHandler(this.Maximize_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = global::Telemetri.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(112, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(50, 50);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_Button.TabIndex = 10;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // TopRight_Panel
            // 
            this.TopRight_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopRight_Panel.Controls.Add(this.Maximize_Button);
            this.TopRight_Panel.Controls.Add(this.Minimize_Button);
            this.TopRight_Panel.Controls.Add(this.Exit_Button);
            this.TopRight_Panel.Location = new System.Drawing.Point(1272, 15);
            this.TopRight_Panel.Name = "TopRight_Panel";
            this.TopRight_Panel.Size = new System.Drawing.Size(162, 56);
            this.TopRight_Panel.TabIndex = 13;
            // 
            // Ports_Combobox
            // 
            this.Ports_Combobox.BackColor = System.Drawing.SystemColors.Window;
            this.Ports_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ports_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ports_Combobox.FormattingEnabled = true;
            this.Ports_Combobox.Location = new System.Drawing.Point(110, 5);
            this.Ports_Combobox.Name = "Ports_Combobox";
            this.Ports_Combobox.Size = new System.Drawing.Size(135, 33);
            this.Ports_Combobox.TabIndex = 14;
            this.Ports_Combobox.Click += new System.EventHandler(this.Ports_Combobox_Click);
            // 
            // BaudRate_Combobox
            // 
            this.BaudRate_Combobox.BackColor = System.Drawing.SystemColors.Window;
            this.BaudRate_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaudRate_Combobox.FormattingEnabled = true;
            this.BaudRate_Combobox.Location = new System.Drawing.Point(110, 44);
            this.BaudRate_Combobox.Name = "BaudRate_Combobox";
            this.BaudRate_Combobox.Size = new System.Drawing.Size(135, 33);
            this.BaudRate_Combobox.TabIndex = 15;
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Settings_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Settings_Panel.Controls.Add(this.SelectLogFile_Button);
            this.Settings_Panel.Controls.Add(this.TubitakLogFile_Textbox);
            this.Settings_Panel.Controls.Add(this.TubitakLogFile_Label);
            this.Settings_Panel.Controls.Add(this.FullLogFile_Textbox);
            this.Settings_Panel.Controls.Add(this.FullLogFile_Label);
            this.Settings_Panel.Controls.Add(this.BaudRate_Combobox);
            this.Settings_Panel.Controls.Add(this.COMPort_Label);
            this.Settings_Panel.Controls.Add(this.Ports_Combobox);
            this.Settings_Panel.Controls.Add(this.BaudRate_Label);
            this.Settings_Panel.Location = new System.Drawing.Point(12, 77);
            this.Settings_Panel.Name = "Settings_Panel";
            this.Settings_Panel.Size = new System.Drawing.Size(1422, 87);
            this.Settings_Panel.TabIndex = 16;
            // 
            // SelectLogFile_Button
            // 
            this.SelectLogFile_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLogFile_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectLogFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("SelectLogFile_Button.Image")));
            this.SelectLogFile_Button.Location = new System.Drawing.Point(1365, 10);
            this.SelectLogFile_Button.Name = "SelectLogFile_Button";
            this.SelectLogFile_Button.Size = new System.Drawing.Size(47, 65);
            this.SelectLogFile_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectLogFile_Button.TabIndex = 33;
            this.SelectLogFile_Button.TabStop = false;
            this.SelectLogFile_Button.Click += new System.EventHandler(this.SelectLogFile_Button_Click);
            // 
            // TubitakLogFile_Textbox
            // 
            this.TubitakLogFile_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TubitakLogFile_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.TubitakLogFile_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TubitakLogFile_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TubitakLogFile_Textbox.ForeColor = System.Drawing.Color.White;
            this.TubitakLogFile_Textbox.Location = new System.Drawing.Point(445, 45);
            this.TubitakLogFile_Textbox.MaxLength = 32;
            this.TubitakLogFile_Textbox.Name = "TubitakLogFile_Textbox";
            this.TubitakLogFile_Textbox.Size = new System.Drawing.Size(914, 30);
            this.TubitakLogFile_Textbox.TabIndex = 34;
            this.TubitakLogFile_Textbox.Text = "C:\\AKS_Telemetri\\tubitak_log.txt";
            // 
            // TubitakLogFile_Label
            // 
            this.TubitakLogFile_Label.AutoSize = true;
            this.TubitakLogFile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TubitakLogFile_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TubitakLogFile_Label.Location = new System.Drawing.Point(273, 49);
            this.TubitakLogFile_Label.Name = "TubitakLogFile_Label";
            this.TubitakLogFile_Label.Size = new System.Drawing.Size(166, 24);
            this.TubitakLogFile_Label.TabIndex = 33;
            this.TubitakLogFile_Label.Text = "TUBITAK Log File:";
            // 
            // FullLogFile_Textbox
            // 
            this.FullLogFile_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullLogFile_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FullLogFile_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullLogFile_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FullLogFile_Textbox.ForeColor = System.Drawing.Color.White;
            this.FullLogFile_Textbox.Location = new System.Drawing.Point(445, 10);
            this.FullLogFile_Textbox.MaxLength = 32;
            this.FullLogFile_Textbox.Name = "FullLogFile_Textbox";
            this.FullLogFile_Textbox.Size = new System.Drawing.Size(914, 30);
            this.FullLogFile_Textbox.TabIndex = 32;
            this.FullLogFile_Textbox.Text = "C:\\AKS_Telemetri\\telemetri_log.txt";
            // 
            // FullLogFile_Label
            // 
            this.FullLogFile_Label.AutoSize = true;
            this.FullLogFile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FullLogFile_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FullLogFile_Label.Location = new System.Drawing.Point(320, 10);
            this.FullLogFile_Label.Name = "FullLogFile_Label";
            this.FullLogFile_Label.Size = new System.Drawing.Size(119, 24);
            this.FullLogFile_Label.TabIndex = 16;
            this.FullLogFile_Label.Text = "Full Log File:";
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Header_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header_Label.Location = new System.Drawing.Point(3, 3);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(464, 48);
            this.Header_Label.TabIndex = 16;
            this.Header_Label.Text = "Atılım Racing Telemetry";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Header_Label);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 56);
            this.panel1.TabIndex = 17;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Connect_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Connect_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Connect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Connect_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Connect_Button.Location = new System.Drawing.Point(3, 3);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(727, 72);
            this.Connect_Button.TabIndex = 29;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = false;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // ClearData_Button
            // 
            this.ClearData_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearData_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.ClearData_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearData_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearData_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearData_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ClearData_Button.Location = new System.Drawing.Point(3, 3);
            this.ClearData_Button.Name = "ClearData_Button";
            this.ClearData_Button.Size = new System.Drawing.Size(675, 72);
            this.ClearData_Button.TabIndex = 30;
            this.ClearData_Button.Text = "Clear Data";
            this.ClearData_Button.UseVisualStyleBackColor = false;
            this.ClearData_Button.Click += new System.EventHandler(this.ClearData_Button_Click);
            // 
            // Packet_TextBox
            // 
            this.Packet_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Packet_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Packet_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Packet_TextBox.DetectUrls = false;
            this.Packet_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Packet_TextBox.ForeColor = System.Drawing.Color.White;
            this.Packet_TextBox.Location = new System.Drawing.Point(12, 507);
            this.Packet_TextBox.Name = "Packet_TextBox";
            this.Packet_TextBox.Size = new System.Drawing.Size(1422, 317);
            this.Packet_TextBox.TabIndex = 31;
            this.Packet_TextBox.Text = "";
            this.Packet_TextBox.TextChanged += new System.EventHandler(this.Packet_TextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 170);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.splitContainer1.Panel1.Controls.Add(this.Connect_Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.splitContainer1.Panel2.Controls.Add(this.ClearData_Button);
            this.splitContainer1.Size = new System.Drawing.Size(1422, 80);
            this.splitContainer1.SplitterDistance = 735;
            this.splitContainer1.TabIndex = 38;
            // 
            // PacketVariablesDataGridView
            // 
            this.PacketVariablesDataGridView.AllowUserToAddRows = false;
            this.PacketVariablesDataGridView.AllowUserToDeleteRows = false;
            this.PacketVariablesDataGridView.AllowUserToResizeColumns = false;
            this.PacketVariablesDataGridView.AllowUserToResizeRows = false;
            this.PacketVariablesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PacketVariablesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PacketVariablesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PacketVariablesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.PacketVariablesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PacketVariablesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.PacketVariablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PacketVariablesDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.PacketVariablesDataGridView.EnableHeadersVisualStyles = false;
            this.PacketVariablesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PacketVariablesDataGridView.Location = new System.Drawing.Point(12, 252);
            this.PacketVariablesDataGridView.MultiSelect = false;
            this.PacketVariablesDataGridView.Name = "PacketVariablesDataGridView";
            this.PacketVariablesDataGridView.ReadOnly = true;
            this.PacketVariablesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PacketVariablesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.PacketVariablesDataGridView.RowHeadersVisible = false;
            this.PacketVariablesDataGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PacketVariablesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.PacketVariablesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PacketVariablesDataGridView.RowTemplate.Height = 30;
            this.PacketVariablesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PacketVariablesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PacketVariablesDataGridView.Size = new System.Drawing.Size(1422, 79);
            this.PacketVariablesDataGridView.TabIndex = 39;
            // 
            // BatteryCellDataGridView0
            // 
            this.BatteryCellDataGridView0.AllowUserToAddRows = false;
            this.BatteryCellDataGridView0.AllowUserToDeleteRows = false;
            this.BatteryCellDataGridView0.AllowUserToResizeColumns = false;
            this.BatteryCellDataGridView0.AllowUserToResizeRows = false;
            this.BatteryCellDataGridView0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatteryCellDataGridView0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BatteryCellDataGridView0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BatteryCellDataGridView0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.BatteryCellDataGridView0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BatteryCellDataGridView0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.BatteryCellDataGridView0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BatteryCellDataGridView0.DefaultCellStyle = dataGridViewCellStyle18;
            this.BatteryCellDataGridView0.EnableHeadersVisualStyles = false;
            this.BatteryCellDataGridView0.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BatteryCellDataGridView0.Location = new System.Drawing.Point(12, 337);
            this.BatteryCellDataGridView0.MultiSelect = false;
            this.BatteryCellDataGridView0.Name = "BatteryCellDataGridView0";
            this.BatteryCellDataGridView0.ReadOnly = true;
            this.BatteryCellDataGridView0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BatteryCellDataGridView0.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.BatteryCellDataGridView0.RowHeadersVisible = false;
            this.BatteryCellDataGridView0.RowHeadersWidth = 30;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BatteryCellDataGridView0.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.BatteryCellDataGridView0.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BatteryCellDataGridView0.RowTemplate.Height = 30;
            this.BatteryCellDataGridView0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BatteryCellDataGridView0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BatteryCellDataGridView0.Size = new System.Drawing.Size(1422, 79);
            this.BatteryCellDataGridView0.TabIndex = 40;
            // 
            // BatteryCellDataGridView1
            // 
            this.BatteryCellDataGridView1.AllowUserToAddRows = false;
            this.BatteryCellDataGridView1.AllowUserToDeleteRows = false;
            this.BatteryCellDataGridView1.AllowUserToResizeColumns = false;
            this.BatteryCellDataGridView1.AllowUserToResizeRows = false;
            this.BatteryCellDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatteryCellDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BatteryCellDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BatteryCellDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.BatteryCellDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BatteryCellDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.BatteryCellDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BatteryCellDataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
            this.BatteryCellDataGridView1.EnableHeadersVisualStyles = false;
            this.BatteryCellDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BatteryCellDataGridView1.Location = new System.Drawing.Point(12, 422);
            this.BatteryCellDataGridView1.MultiSelect = false;
            this.BatteryCellDataGridView1.Name = "BatteryCellDataGridView1";
            this.BatteryCellDataGridView1.ReadOnly = true;
            this.BatteryCellDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BatteryCellDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.BatteryCellDataGridView1.RowHeadersVisible = false;
            this.BatteryCellDataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BatteryCellDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.BatteryCellDataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BatteryCellDataGridView1.RowTemplate.Height = 30;
            this.BatteryCellDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BatteryCellDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BatteryCellDataGridView1.Size = new System.Drawing.Size(1422, 79);
            this.BatteryCellDataGridView1.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1446, 836);
            this.Controls.Add(this.BatteryCellDataGridView1);
            this.Controls.Add(this.BatteryCellDataGridView0);
            this.Controls.Add(this.PacketVariablesDataGridView);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Packet_TextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Settings_Panel);
            this.Controls.Add(this.TopRight_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.TopRight_Panel.ResumeLayout(false);
            this.Settings_Panel.ResumeLayout(false);
            this.Settings_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLogFile_Button)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PacketVariablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryCellDataGridView0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryCellDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort activeSerialPort;
        private System.Windows.Forms.Label COMPort_Label;
        private System.Windows.Forms.Label BaudRate_Label;
        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.PictureBox Maximize_Button;
        private System.Windows.Forms.PictureBox Minimize_Button;
        private System.Windows.Forms.Panel TopRight_Panel;
        private System.Windows.Forms.ComboBox Ports_Combobox;
        private System.Windows.Forms.ComboBox BaudRate_Combobox;
        private System.Windows.Forms.Panel Settings_Panel;
        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Button ClearData_Button;
        private System.Windows.Forms.RichTextBox Packet_TextBox;
        private System.Windows.Forms.TextBox FullLogFile_Textbox;
        private System.Windows.Forms.Label FullLogFile_Label;
        private System.Windows.Forms.PictureBox SelectLogFile_Button;
        private System.Windows.Forms.TextBox TubitakLogFile_Textbox;
        private System.Windows.Forms.Label TubitakLogFile_Label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView PacketVariablesDataGridView;
        private System.Windows.Forms.DataGridView BatteryCellDataGridView0;
        private System.Windows.Forms.DataGridView BatteryCellDataGridView1;
    }
}

