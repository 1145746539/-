namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FuncCode = new System.Windows.Forms.ComboBox();
            this.QMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IPAddr = new System.Windows.Forms.TextBox();
            this.ComPort = new System.Windows.Forms.ComboBox();
            this.MBMode = new System.Windows.Forms.ComboBox();
            this.CommType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DataToDev = new System.Windows.Forms.TextBox();
            this.DataFromDev = new System.Windows.Forms.TextBox();
            this.DevName = new System.Windows.Forms.TextBox();
            this.DevQty = new System.Windows.Forms.TextBox();
            this.SlavAddr = new System.Windows.Forms.TextBox();
            this.ActStatus = new System.Windows.Forms.TextBox();
            this.ResData = new System.Windows.Forms.TextBox();
            this.ReqData = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.FuncCode);
            this.groupBox1.Controls.Add(this.QMode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Product);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.IPAddr);
            this.groupBox1.Controls.Add(this.ComPort);
            this.groupBox1.Controls.Add(this.MBMode);
            this.groupBox1.Controls.Add(this.CommType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(258, 12);
            this.label20.TabIndex = 8;
            this.label20.Text = "*** Coil / Discrete Input State : 0 -> Off , 1 -> On ***";
            // 
            // FuncCode
            // 
            this.FuncCode.FormattingEnabled = true;
            this.FuncCode.Items.AddRange(new object[] {
            "Read Coils",
            "Read Discrete Inputs",
            "Read Holding Registers",
            "Read Holding Registers 32-bit",
            "Read Input Registers",
            "Write Single Coil",
            "Write Single Register",
            "Write Single Register 32-bit",
            "Write Multiple Coils",
            "Write Multiple Registers",
            "Write Multiple Registers 32-bit"});
            this.FuncCode.Location = new System.Drawing.Point(132, 173);
            this.FuncCode.Name = "FuncCode";
            this.FuncCode.Size = new System.Drawing.Size(170, 20);
            this.FuncCode.TabIndex = 7;
            this.FuncCode.SelectedIndexChanged += new System.EventHandler(this.FuncCode_SelectedIndexChanged);
            // 
            // QMode
            // 
            this.QMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QMode.FormattingEnabled = true;
            this.QMode.Items.AddRange(new object[] {
            "Standard MODBUS Request",
            "DMT Wrapped Function Code"});
            this.QMode.Location = new System.Drawing.Point(132, 147);
            this.QMode.Name = "QMode";
            this.QMode.Size = new System.Drawing.Size(170, 20);
            this.QMode.TabIndex = 6;
            this.QMode.SelectedIndexChanged += new System.EventHandler(this.QMode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Function Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Query Mode";
            // 
            // Product
            // 
            this.Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product.FormattingEnabled = true;
            this.Product.Items.AddRange(new object[] {
            "RTU-EN01",
            "DVP-EN01 / DVP-12SE",
            "Other DVP Series PLC",
            "AH Series PLC",
            "AS Series PLC",
            "15MC / 50MC"});
            this.Product.Location = new System.Drawing.Point(132, 15);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(170, 20);
            this.Product.TabIndex = 1;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product";
            // 
            // IPAddr
            // 
            this.IPAddr.Location = new System.Drawing.Point(132, 119);
            this.IPAddr.Name = "IPAddr";
            this.IPAddr.Size = new System.Drawing.Size(170, 22);
            this.IPAddr.TabIndex = 5;
            // 
            // ComPort
            // 
            this.ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort.FormattingEnabled = true;
            this.ComPort.Location = new System.Drawing.Point(132, 93);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(170, 20);
            this.ComPort.TabIndex = 4;
            // 
            // MBMode
            // 
            this.MBMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MBMode.FormattingEnabled = true;
            this.MBMode.Items.AddRange(new object[] {
            "ASCII",
            "RTU"});
            this.MBMode.Location = new System.Drawing.Point(132, 67);
            this.MBMode.Name = "MBMode";
            this.MBMode.Size = new System.Drawing.Size(170, 20);
            this.MBMode.TabIndex = 3;
            // 
            // CommType
            // 
            this.CommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommType.FormattingEnabled = true;
            this.CommType.Items.AddRange(new object[] {
            "RS-232",
            "Ethernet"});
            this.CommType.Location = new System.Drawing.Point(132, 41);
            this.CommType.Name = "CommType";
            this.CommType.Size = new System.Drawing.Size(170, 20);
            this.CommType.TabIndex = 2;
            this.CommType.SelectedIndexChanged += new System.EventHandler(this.CommType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Slave IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serial Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modbus Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Communication Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.DataToDev);
            this.groupBox2.Controls.Add(this.DataFromDev);
            this.groupBox2.Controls.Add(this.DevName);
            this.groupBox2.Controls.Add(this.DevQty);
            this.groupBox2.Controls.Add(this.SlavAddr);
            this.groupBox2.Controls.Add(this.ActStatus);
            this.groupBox2.Controls.Add(this.ResData);
            this.groupBox2.Controls.Add(this.ReqData);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(189, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "(Decimal)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(189, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "(Decimal)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(255, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "(%IX0.7, %IW0, %QX127.7, %QW63, %MW32767)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(189, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "(Fixed for simple demonstration)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DataToDev
            // 
            this.DataToDev.Location = new System.Drawing.Point(110, 211);
            this.DataToDev.Name = "DataToDev";
            this.DataToDev.Size = new System.Drawing.Size(73, 22);
            this.DataToDev.TabIndex = 15;
            this.DataToDev.Text = "0";
            // 
            // DataFromDev
            // 
            this.DataFromDev.Location = new System.Drawing.Point(110, 183);
            this.DataFromDev.Name = "DataFromDev";
            this.DataFromDev.ReadOnly = true;
            this.DataFromDev.Size = new System.Drawing.Size(73, 22);
            this.DataFromDev.TabIndex = 14;
            this.DataFromDev.Text = "0";
            // 
            // DevName
            // 
            this.DevName.Location = new System.Drawing.Point(110, 155);
            this.DevName.Name = "DevName";
            this.DevName.Size = new System.Drawing.Size(73, 22);
            this.DevName.TabIndex = 13;
            this.DevName.Text = "C12";
            // 
            // DevQty
            // 
            this.DevQty.Location = new System.Drawing.Point(110, 127);
            this.DevQty.Name = "DevQty";
            this.DevQty.ReadOnly = true;
            this.DevQty.Size = new System.Drawing.Size(73, 22);
            this.DevQty.TabIndex = 12;
            this.DevQty.Text = "1";
            // 
            // SlavAddr
            // 
            this.SlavAddr.Location = new System.Drawing.Point(110, 99);
            this.SlavAddr.Name = "SlavAddr";
            this.SlavAddr.Size = new System.Drawing.Size(73, 22);
            this.SlavAddr.TabIndex = 11;
            this.SlavAddr.Text = "0";
            // 
            // ActStatus
            // 
            this.ActStatus.Location = new System.Drawing.Point(110, 71);
            this.ActStatus.Name = "ActStatus";
            this.ActStatus.ReadOnly = true;
            this.ActStatus.Size = new System.Drawing.Size(154, 22);
            this.ActStatus.TabIndex = 10;
            // 
            // ResData
            // 
            this.ResData.Location = new System.Drawing.Point(110, 43);
            this.ResData.Name = "ResData";
            this.ResData.ReadOnly = true;
            this.ResData.Size = new System.Drawing.Size(235, 22);
            this.ResData.TabIndex = 9;
            // 
            // ReqData
            // 
            this.ReqData.Location = new System.Drawing.Point(110, 15);
            this.ReqData.Name = "ReqData";
            this.ReqData.Size = new System.Drawing.Size(235, 22);
            this.ReqData.TabIndex = 8;
            this.ReqData.Text = "00050500FF00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "Data To Device";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "Data From Device";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "Device Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "Device Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Slave Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Action Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Response Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Request Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPAddr;
        private System.Windows.Forms.ComboBox ComPort;
        private System.Windows.Forms.ComboBox MBMode;
        private System.Windows.Forms.ComboBox CommType;
        private System.Windows.Forms.ComboBox FuncCode;
        private System.Windows.Forms.ComboBox QMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DataToDev;
        private System.Windows.Forms.TextBox DataFromDev;
        private System.Windows.Forms.TextBox DevName;
        private System.Windows.Forms.TextBox DevQty;
        private System.Windows.Forms.TextBox SlavAddr;
        private System.Windows.Forms.TextBox ActStatus;
        private System.Windows.Forms.TextBox ResData;
        private System.Windows.Forms.TextBox ReqData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;

    }


}

