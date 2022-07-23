namespace Telemetri
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.COM_Port_Label = new System.Windows.Forms.Label();
            this.Baud_Rate_Label = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Ports_Combobox = new System.Windows.Forms.ComboBox();
            this.Baud_Rate_Combobox = new System.Windows.Forms.ComboBox();
            this.Clear_Data_Button = new System.Windows.Forms.Button();
            this.Data_TextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Data_Send_Textbox = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // COM_Port_Label
            // 
            this.COM_Port_Label.AutoSize = true;
            this.COM_Port_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.COM_Port_Label.Location = new System.Drawing.Point(33, 44);
            this.COM_Port_Label.Name = "COM_Port_Label";
            this.COM_Port_Label.Size = new System.Drawing.Size(97, 24);
            this.COM_Port_Label.TabIndex = 0;
            this.COM_Port_Label.Text = "COM Port:";
            // 
            // Baud_Rate_Label
            // 
            this.Baud_Rate_Label.AutoSize = true;
            this.Baud_Rate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Baud_Rate_Label.Location = new System.Drawing.Point(28, 84);
            this.Baud_Rate_Label.Name = "Baud_Rate_Label";
            this.Baud_Rate_Label.Size = new System.Drawing.Size(102, 24);
            this.Baud_Rate_Label.TabIndex = 1;
            this.Baud_Rate_Label.Text = "Baud Rate:";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(288, 44);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(134, 64);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Ports_Combobox
            // 
            this.Ports_Combobox.FormattingEnabled = true;
            this.Ports_Combobox.Location = new System.Drawing.Point(136, 44);
            this.Ports_Combobox.Name = "Ports_Combobox";
            this.Ports_Combobox.Size = new System.Drawing.Size(121, 24);
            this.Ports_Combobox.TabIndex = 3;
            this.Ports_Combobox.SelectedIndexChanged += new System.EventHandler(this.Ports_Combobox_SelectedIndexChanged);
            // 
            // Baud_Rate_Combobox
            // 
            this.Baud_Rate_Combobox.FormattingEnabled = true;
            this.Baud_Rate_Combobox.Location = new System.Drawing.Point(136, 84);
            this.Baud_Rate_Combobox.Name = "Baud_Rate_Combobox";
            this.Baud_Rate_Combobox.Size = new System.Drawing.Size(121, 24);
            this.Baud_Rate_Combobox.TabIndex = 4;
            this.Baud_Rate_Combobox.SelectedIndexChanged += new System.EventHandler(this.Baud_Rate_Combobox_SelectedIndexChanged);
            // 
            // Clear_Data_Button
            // 
            this.Clear_Data_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Clear_Data_Button.Location = new System.Drawing.Point(446, 44);
            this.Clear_Data_Button.Name = "Clear_Data_Button";
            this.Clear_Data_Button.Size = new System.Drawing.Size(134, 64);
            this.Clear_Data_Button.TabIndex = 5;
            this.Clear_Data_Button.Text = "Clear Data";
            this.Clear_Data_Button.UseVisualStyleBackColor = true;
            this.Clear_Data_Button.Click += new System.EventHandler(this.Clear_Data_Button_Click);
            // 
            // Data_TextBox
            // 
            this.Data_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Data_TextBox.Location = new System.Drawing.Point(32, 127);
            this.Data_TextBox.Name = "Data_TextBox";
            this.Data_TextBox.ReadOnly = true;
            this.Data_TextBox.Size = new System.Drawing.Size(548, 287);
            this.Data_TextBox.TabIndex = 6;
            this.Data_TextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(28, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data:";
            // 
            // Data_Send_Textbox
            // 
            this.Data_Send_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Data_Send_Textbox.Location = new System.Drawing.Point(86, 435);
            this.Data_Send_Textbox.Name = "Data_Send_Textbox";
            this.Data_Send_Textbox.Size = new System.Drawing.Size(364, 28);
            this.Data_Send_Textbox.TabIndex = 8;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(456, 435);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(124, 28);
            this.Send_Button.TabIndex = 9;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 536);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Data_Send_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_TextBox);
            this.Controls.Add(this.Clear_Data_Button);
            this.Controls.Add(this.Baud_Rate_Combobox);
            this.Controls.Add(this.Ports_Combobox);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Baud_Rate_Label);
            this.Controls.Add(this.COM_Port_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label COM_Port_Label;
        private System.Windows.Forms.Label Baud_Rate_Label;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ComboBox Ports_Combobox;
        private System.Windows.Forms.ComboBox Baud_Rate_Combobox;
        private System.Windows.Forms.Button Clear_Data_Button;
        private System.Windows.Forms.RichTextBox Data_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Data_Send_Textbox;
        private System.Windows.Forms.Button Send_Button;
    }
}

