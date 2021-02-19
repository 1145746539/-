namespace 图表
{
    partial class PortPara
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Parity = new System.Windows.Forms.Label();
            this.lb_StopBit = new System.Windows.Forms.Label();
            this.lb_DataBits = new System.Windows.Forms.Label();
            this.lb_BaudRate = new System.Windows.Forms.Label();
            this.lb_Port = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.ComboBox();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.SaveSerialPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Parity
            // 
            this.lb_Parity.AutoSize = true;
            this.lb_Parity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Parity.Location = new System.Drawing.Point(319, 101);
            this.lb_Parity.Name = "lb_Parity";
            this.lb_Parity.Size = new System.Drawing.Size(56, 17);
            this.lb_Parity.TabIndex = 39;
            this.lb_Parity.Text = "校验位：";
            // 
            // lb_StopBit
            // 
            this.lb_StopBit.AutoSize = true;
            this.lb_StopBit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_StopBit.Location = new System.Drawing.Point(20, 101);
            this.lb_StopBit.Name = "lb_StopBit";
            this.lb_StopBit.Size = new System.Drawing.Size(56, 17);
            this.lb_StopBit.TabIndex = 38;
            this.lb_StopBit.Text = "停止位：";
            // 
            // lb_DataBits
            // 
            this.lb_DataBits.AutoSize = true;
            this.lb_DataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_DataBits.Location = new System.Drawing.Point(20, 177);
            this.lb_DataBits.Name = "lb_DataBits";
            this.lb_DataBits.Size = new System.Drawing.Size(56, 17);
            this.lb_DataBits.TabIndex = 37;
            this.lb_DataBits.Text = "数据位：";
            // 
            // lb_BaudRate
            // 
            this.lb_BaudRate.AutoSize = true;
            this.lb_BaudRate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_BaudRate.Location = new System.Drawing.Point(319, 25);
            this.lb_BaudRate.Name = "lb_BaudRate";
            this.lb_BaudRate.Size = new System.Drawing.Size(56, 17);
            this.lb_BaudRate.TabIndex = 36;
            this.lb_BaudRate.Text = "波特率：";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Port.Location = new System.Drawing.Point(20, 25);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(56, 17);
            this.lb_Port.TabIndex = 35;
            this.lb_Port.Text = "串口号：";
            // 
            // Port
            // 
            this.Port.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Port.FormattingEnabled = true;
            this.Port.Location = new System.Drawing.Point(84, 25);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(121, 20);
            this.Port.TabIndex = 40;
            // 
            // StopBit
            // 
            this.StopBit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.StopBit.Location = new System.Drawing.Point(82, 101);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(121, 20);
            this.StopBit.TabIndex = 41;
            // 
            // DataBits
            // 
            this.DataBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBits.Location = new System.Drawing.Point(82, 173);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(121, 20);
            this.DataBits.TabIndex = 42;
            // 
            // BaudRate
            // 
            this.BaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.BaudRate.Location = new System.Drawing.Point(391, 25);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 20);
            this.BaudRate.TabIndex = 43;
            // 
            // Parity
            // 
            this.Parity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Parity.Location = new System.Drawing.Point(391, 101);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 20);
            this.Parity.TabIndex = 44;
            // 
            // SaveSerialPort
            // 
            this.SaveSerialPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveSerialPort.Location = new System.Drawing.Point(319, 171);
            this.SaveSerialPort.Name = "SaveSerialPort";
            this.SaveSerialPort.Size = new System.Drawing.Size(75, 23);
            this.SaveSerialPort.TabIndex = 45;
            this.SaveSerialPort.Text = "保存";
            this.SaveSerialPort.UseVisualStyleBackColor = false;
            // 
            // PortPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveSerialPort);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.DataBits);
            this.Controls.Add(this.StopBit);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.lb_Parity);
            this.Controls.Add(this.lb_StopBit);
            this.Controls.Add(this.lb_DataBits);
            this.Controls.Add(this.lb_BaudRate);
            this.Controls.Add(this.lb_Port);
            this.Name = "PortPara";
            this.Size = new System.Drawing.Size(544, 232);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Parity;
        private System.Windows.Forms.Label lb_StopBit;
        private System.Windows.Forms.Label lb_DataBits;
        private System.Windows.Forms.Label lb_BaudRate;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox DataBits;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.Button SaveSerialPort;
    }
}
