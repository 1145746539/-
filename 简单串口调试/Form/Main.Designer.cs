namespace 简单串口调试
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_set = new DevComponents.DotNetBar.ButtonX();
            this.bt_OpenOrClose = new DevComponents.DotNetBar.ButtonX();
            this.gp_sendManage = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_sendInfo = new DevComponents.DotNetBar.ButtonX();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lb_sendInfo = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gp_receive = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.lb_receiveInfo = new DevComponents.DotNetBar.LabelX();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Port = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_BaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_DataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_StopBit = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Parity = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimeSend = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.rdSendStr = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.gp_sendManage.SuspendLayout();
            this.gp_receive.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_set
            // 
            this.bt_set.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_set.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_set.Location = new System.Drawing.Point(173, 11);
            this.bt_set.Name = "bt_set";
            this.bt_set.Size = new System.Drawing.Size(75, 23);
            this.bt_set.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_set.TabIndex = 1;
            this.bt_set.Text = "设置串口";
            this.bt_set.Tooltip = "设置串口";
            this.bt_set.Click += new System.EventHandler(this.bt_set_Click);
            // 
            // bt_OpenOrClose
            // 
            this.bt_OpenOrClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_OpenOrClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_OpenOrClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_OpenOrClose.Location = new System.Drawing.Point(376, 11);
            this.bt_OpenOrClose.Name = "bt_OpenOrClose";
            this.bt_OpenOrClose.Size = new System.Drawing.Size(75, 23);
            this.bt_OpenOrClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_OpenOrClose.TabIndex = 2;
            this.bt_OpenOrClose.Text = "打开串口";
            this.bt_OpenOrClose.Tooltip = "关闭串口";
            this.bt_OpenOrClose.Click += new System.EventHandler(this.bt_OpenOrClose_Click);
            // 
            // gp_sendManage
            // 
            this.gp_sendManage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gp_sendManage.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.gp_sendManage.Controls.Add(this.bt_sendInfo);
            this.gp_sendManage.Controls.Add(this.richTextBox1);
            this.gp_sendManage.Controls.Add(this.lb_sendInfo);
            this.gp_sendManage.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp_sendManage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gp_sendManage.Location = new System.Drawing.Point(12, 89);
            this.gp_sendManage.Name = "gp_sendManage";
            this.gp_sendManage.Size = new System.Drawing.Size(616, 173);
            // 
            // 
            // 
            this.gp_sendManage.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_sendManage.Style.BackColorGradientAngle = 90;
            this.gp_sendManage.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_sendManage.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_sendManage.Style.BorderBottomWidth = 1;
            this.gp_sendManage.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_sendManage.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_sendManage.Style.BorderLeftWidth = 1;
            this.gp_sendManage.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_sendManage.Style.BorderRightWidth = 1;
            this.gp_sendManage.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_sendManage.Style.BorderTopWidth = 1;
            this.gp_sendManage.Style.CornerDiameter = 4;
            this.gp_sendManage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_sendManage.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_sendManage.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_sendManage.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_sendManage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_sendManage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_sendManage.TabIndex = 3;
            this.gp_sendManage.Text = "发送管理";
            // 
            // bt_sendInfo
            // 
            this.bt_sendInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_sendInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_sendInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_sendInfo.Location = new System.Drawing.Point(511, 107);
            this.bt_sendInfo.Name = "bt_sendInfo";
            this.bt_sendInfo.Size = new System.Drawing.Size(75, 23);
            this.bt_sendInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_sendInfo.TabIndex = 3;
            this.bt_sendInfo.Text = "发送数据";
            this.bt_sendInfo.Tooltip = "发送数据";
            this.bt_sendInfo.Click += new System.EventHandler(this.bt_sendInfo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(85, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 139);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lb_sendInfo
            // 
            this.lb_sendInfo.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.lb_sendInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_sendInfo.Location = new System.Drawing.Point(12, 5);
            this.lb_sendInfo.Name = "lb_sendInfo";
            this.lb_sendInfo.SingleLineColor = System.Drawing.SystemColors.Control;
            this.lb_sendInfo.Size = new System.Drawing.Size(67, 23);
            this.lb_sendInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lb_sendInfo.TabIndex = 0;
            this.lb_sendInfo.Text = "发送数据：";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // gp_receive
            // 
            this.gp_receive.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gp_receive.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.gp_receive.Controls.Add(this.buttonX2);
            this.gp_receive.Controls.Add(this.txtReceive);
            this.gp_receive.Controls.Add(this.lb_receiveInfo);
            this.gp_receive.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp_receive.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gp_receive.Location = new System.Drawing.Point(12, 277);
            this.gp_receive.Name = "gp_receive";
            this.gp_receive.Size = new System.Drawing.Size(616, 173);
            // 
            // 
            // 
            this.gp_receive.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_receive.Style.BackColorGradientAngle = 90;
            this.gp_receive.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_receive.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_receive.Style.BorderBottomWidth = 1;
            this.gp_receive.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_receive.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_receive.Style.BorderLeftWidth = 1;
            this.gp_receive.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_receive.Style.BorderRightWidth = 1;
            this.gp_receive.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_receive.Style.BorderTopWidth = 1;
            this.gp_receive.Style.CornerDiameter = 4;
            this.gp_receive.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_receive.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_receive.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_receive.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_receive.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_receive.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_receive.TabIndex = 4;
            this.gp_receive.Text = "接收管理";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX2.Location = new System.Drawing.Point(511, 107);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "清空内容";
            this.buttonX2.Tooltip = "清空内容";
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtReceive.Location = new System.Drawing.Point(85, 5);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(409, 139);
            this.txtReceive.TabIndex = 1;
            this.txtReceive.Text = "";
            // 
            // lb_receiveInfo
            // 
            this.lb_receiveInfo.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.lb_receiveInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_receiveInfo.Location = new System.Drawing.Point(12, 5);
            this.lb_receiveInfo.Name = "lb_receiveInfo";
            this.lb_receiveInfo.SingleLineColor = System.Drawing.SystemColors.Control;
            this.lb_receiveInfo.Size = new System.Drawing.Size(67, 23);
            this.lb_receiveInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lb_receiveInfo.TabIndex = 0;
            this.lb_receiveInfo.Text = "接收数据：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Port,
            this.tssl_BaudRate,
            this.tssl_DataBits,
            this.tssl_StopBit,
            this.tssl_Parity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(645, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Port
            // 
            this.tssl_Port.Name = "tssl_Port";
            this.tssl_Port.Size = new System.Drawing.Size(56, 17);
            this.tssl_Port.Text = "端口号：";
            // 
            // tssl_BaudRate
            // 
            this.tssl_BaudRate.Name = "tssl_BaudRate";
            this.tssl_BaudRate.Size = new System.Drawing.Size(56, 17);
            this.tssl_BaudRate.Text = "波特率：";
            // 
            // tssl_DataBits
            // 
            this.tssl_DataBits.Name = "tssl_DataBits";
            this.tssl_DataBits.Size = new System.Drawing.Size(56, 17);
            this.tssl_DataBits.Text = "数据位：";
            // 
            // tssl_StopBit
            // 
            this.tssl_StopBit.Name = "tssl_StopBit";
            this.tssl_StopBit.Size = new System.Drawing.Size(56, 17);
            this.tssl_StopBit.Text = "停止位：";
            // 
            // tssl_Parity
            // 
            this.tssl_Parity.Name = "tssl_Parity";
            this.tssl_Parity.Size = new System.Drawing.Size(56, 17);
            this.tssl_Parity.Text = "校检位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "秒";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(559, 55);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(44, 21);
            this.txtSecond.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "时间间隔：";
            // 
            // cbTimeSend
            // 
            this.cbTimeSend.AutoSize = true;
            this.cbTimeSend.Location = new System.Drawing.Point(370, 58);
            this.cbTimeSend.Name = "cbTimeSend";
            this.cbTimeSend.Size = new System.Drawing.Size(96, 16);
            this.cbTimeSend.TabIndex = 20;
            this.cbTimeSend.Text = "定时发送数据";
            this.cbTimeSend.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radio1);
            this.groupBox7.Controls.Add(this.rdSendStr);
            this.groupBox7.Location = new System.Drawing.Point(27, 46);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(134, 37);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "发送数据格式";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(9, 15);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(59, 16);
            this.radio1.TabIndex = 7;
            this.radio1.TabStop = true;
            this.radio1.Text = "16进制";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // rdSendStr
            // 
            this.rdSendStr.AutoSize = true;
            this.rdSendStr.Location = new System.Drawing.Point(73, 15);
            this.rdSendStr.Name = "rdSendStr";
            this.rdSendStr.Size = new System.Drawing.Size(59, 16);
            this.rdSendStr.TabIndex = 6;
            this.rdSendStr.TabStop = true;
            this.rdSendStr.Text = "字符串";
            this.rdSendStr.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbRcvStr);
            this.groupBox8.Controls.Add(this.rbRcv16);
            this.groupBox8.Location = new System.Drawing.Point(189, 46);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(142, 36);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "接收数据格式";
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Location = new System.Drawing.Point(72, 14);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(59, 16);
            this.rbRcvStr.TabIndex = 2;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.Location = new System.Drawing.Point(9, 14);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(59, 16);
            this.rbRcv16.TabIndex = 1;
            this.rbRcv16.TabStop = true;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            // 
            // timerSend
            // 
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 486);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTimeSend);
            this.Controls.Add(this.gp_receive);
            this.Controls.Add(this.gp_sendManage);
            this.Controls.Add(this.bt_OpenOrClose);
            this.Controls.Add(this.bt_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS232串口通讯";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gp_sendManage.ResumeLayout(false);
            this.gp_receive.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX bt_set;
        private DevComponents.DotNetBar.ButtonX bt_OpenOrClose;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_sendManage;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX lb_sendInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevComponents.DotNetBar.ButtonX bt_sendInfo;
        private DevComponents.DotNetBar.LabelX lb_receiveInfo;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_receive;
        private System.Windows.Forms.RichTextBox txtReceive;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Port;
        private System.Windows.Forms.ToolStripStatusLabel tssl_BaudRate;
        private System.Windows.Forms.ToolStripStatusLabel tssl_DataBits;
        private System.Windows.Forms.ToolStripStatusLabel tssl_StopBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTimeSend;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton rdSendStr;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Parity;
        private System.Windows.Forms.Timer timerSend;
    }
}

