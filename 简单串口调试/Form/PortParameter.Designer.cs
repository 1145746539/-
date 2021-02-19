namespace 简单串口调试
{
    partial class PortParameter
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
            this.gp_Parameter = new System.Windows.Forms.GroupBox();
            this.lb_showPortInfo = new System.Windows.Forms.Label();
            this.cb_Port = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cb_BaudRate = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbI_BaudRate1 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate2 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate3 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate4 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate5 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate6 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate7 = new DevComponents.Editors.ComboItem();
            this.cbI_BaudRate8 = new DevComponents.Editors.ComboItem();
            this.cb_DataBits = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbI_DataBits1 = new DevComponents.Editors.ComboItem();
            this.cbI_DataBits2 = new DevComponents.Editors.ComboItem();
            this.cbI_DataBits3 = new DevComponents.Editors.ComboItem();
            this.cbI_DataBits4 = new DevComponents.Editors.ComboItem();
            this.cb_Parity = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbI_Parity1 = new DevComponents.Editors.ComboItem();
            this.cbI_Parity2 = new DevComponents.Editors.ComboItem();
            this.cbI_Parity3 = new DevComponents.Editors.ComboItem();
            this.cb_StopBits = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbI_StopBit1 = new DevComponents.Editors.ComboItem();
            this.cbI_StopBit2 = new DevComponents.Editors.ComboItem();
            this.cbI_StopBit3 = new DevComponents.Editors.ComboItem();
            this.cbI_StopBit4 = new DevComponents.Editors.ComboItem();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lb_Parity = new System.Windows.Forms.Label();
            this.lb_StopBit = new System.Windows.Forms.Label();
            this.lb_DataBits = new System.Windows.Forms.Label();
            this.lb_BaudRate = new System.Windows.Forms.Label();
            this.lb_Port = new System.Windows.Forms.Label();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.gp_Parameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_Parameter
            // 
            this.gp_Parameter.Controls.Add(this.lb_showPortInfo);
            this.gp_Parameter.Controls.Add(this.cb_Port);
            this.gp_Parameter.Controls.Add(this.cb_BaudRate);
            this.gp_Parameter.Controls.Add(this.cb_DataBits);
            this.gp_Parameter.Controls.Add(this.cb_Parity);
            this.gp_Parameter.Controls.Add(this.cb_StopBits);
            this.gp_Parameter.Controls.Add(this.buttonX2);
            this.gp_Parameter.Controls.Add(this.buttonX1);
            this.gp_Parameter.Controls.Add(this.lb_Parity);
            this.gp_Parameter.Controls.Add(this.lb_StopBit);
            this.gp_Parameter.Controls.Add(this.lb_DataBits);
            this.gp_Parameter.Controls.Add(this.lb_BaudRate);
            this.gp_Parameter.Controls.Add(this.lb_Port);
            this.gp_Parameter.Location = new System.Drawing.Point(-3, -7);
            this.gp_Parameter.Name = "gp_Parameter";
            this.gp_Parameter.Size = new System.Drawing.Size(246, 326);
            this.gp_Parameter.TabIndex = 0;
            this.gp_Parameter.TabStop = false;
            // 
            // lb_showPortInfo
            // 
            this.lb_showPortInfo.AutoSize = true;
            this.lb_showPortInfo.ForeColor = System.Drawing.Color.Red;
            this.lb_showPortInfo.Location = new System.Drawing.Point(97, 16);
            this.lb_showPortInfo.Name = "lb_showPortInfo";
            this.lb_showPortInfo.Size = new System.Drawing.Size(0, 12);
            this.lb_showPortInfo.TabIndex = 34;
            // 
            // cb_Port
            // 
            this.cb_Port.DisplayMember = "Text";
            this.cb_Port.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Port.FormattingEnabled = true;
            this.cb_Port.ItemHeight = 15;
            this.cb_Port.Location = new System.Drawing.Point(89, 34);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(121, 21);
            this.cb_Port.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Port.TabIndex = 33;
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.DisplayMember = "Text";
            this.cb_BaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.ItemHeight = 15;
            this.cb_BaudRate.Items.AddRange(new object[] {
            this.cbI_BaudRate1,
            this.cbI_BaudRate2,
            this.cbI_BaudRate3,
            this.cbI_BaudRate4,
            this.cbI_BaudRate5,
            this.cbI_BaudRate6,
            this.cbI_BaudRate7,
            this.cbI_BaudRate8});
            this.cb_BaudRate.Location = new System.Drawing.Point(89, 78);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.cb_BaudRate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_BaudRate.TabIndex = 32;
            // 
            // cbI_BaudRate1
            // 
            this.cbI_BaudRate1.Text = "6";
            // 
            // cbI_BaudRate2
            // 
            this.cbI_BaudRate2.Text = "600";
            // 
            // cbI_BaudRate3
            // 
            this.cbI_BaudRate3.Text = "1200";
            // 
            // cbI_BaudRate4
            // 
            this.cbI_BaudRate4.Text = "2400";
            // 
            // cbI_BaudRate5
            // 
            this.cbI_BaudRate5.Text = "4800";
            // 
            // cbI_BaudRate6
            // 
            this.cbI_BaudRate6.Text = "9600";
            // 
            // cbI_BaudRate7
            // 
            this.cbI_BaudRate7.Text = "19200";
            // 
            // cbI_BaudRate8
            // 
            this.cbI_BaudRate8.Text = "38400";
            // 
            // cb_DataBits
            // 
            this.cb_DataBits.DisplayMember = "Text";
            this.cb_DataBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_DataBits.FormattingEnabled = true;
            this.cb_DataBits.ItemHeight = 15;
            this.cb_DataBits.Items.AddRange(new object[] {
            this.cbI_DataBits1,
            this.cbI_DataBits2,
            this.cbI_DataBits3,
            this.cbI_DataBits4});
            this.cb_DataBits.Location = new System.Drawing.Point(89, 122);
            this.cb_DataBits.Name = "cb_DataBits";
            this.cb_DataBits.Size = new System.Drawing.Size(121, 21);
            this.cb_DataBits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_DataBits.TabIndex = 31;
            // 
            // cbI_DataBits1
            // 
            this.cbI_DataBits1.Text = "5";
            // 
            // cbI_DataBits2
            // 
            this.cbI_DataBits2.Text = "6";
            // 
            // cbI_DataBits3
            // 
            this.cbI_DataBits3.Text = "7";
            // 
            // cbI_DataBits4
            // 
            this.cbI_DataBits4.Text = "8";
            // 
            // cb_Parity
            // 
            this.cb_Parity.DisplayMember = "Text";
            this.cb_Parity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Parity.FormattingEnabled = true;
            this.cb_Parity.ItemHeight = 15;
            this.cb_Parity.Items.AddRange(new object[] {
            this.cbI_Parity1,
            this.cbI_Parity2,
            this.cbI_Parity3});
            this.cb_Parity.Location = new System.Drawing.Point(89, 211);
            this.cb_Parity.Name = "cb_Parity";
            this.cb_Parity.Size = new System.Drawing.Size(121, 21);
            this.cb_Parity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_Parity.TabIndex = 30;
            // 
            // cbI_Parity1
            // 
            this.cbI_Parity1.Text = "无";
            // 
            // cbI_Parity2
            // 
            this.cbI_Parity2.Text = "奇校检";
            // 
            // cbI_Parity3
            // 
            this.cbI_Parity3.Text = "偶校检";
            // 
            // cb_StopBits
            // 
            this.cb_StopBits.DisplayMember = "Text";
            this.cb_StopBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_StopBits.FormattingEnabled = true;
            this.cb_StopBits.ItemHeight = 15;
            this.cb_StopBits.Items.AddRange(new object[] {
            this.cbI_StopBit1,
            this.cbI_StopBit2,
            this.cbI_StopBit3,
            this.cbI_StopBit4});
            this.cb_StopBits.Location = new System.Drawing.Point(89, 166);
            this.cb_StopBits.Name = "cb_StopBits";
            this.cb_StopBits.Size = new System.Drawing.Size(121, 21);
            this.cb_StopBits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_StopBits.TabIndex = 29;
            // 
            // cbI_StopBit1
            // 
            this.cbI_StopBit1.Text = "0";
            // 
            // cbI_StopBit2
            // 
            this.cbI_StopBit2.Text = "1";
            // 
            // cbI_StopBit3
            // 
            this.cbI_StopBit3.Text = "1.5";
            // 
            // cbI_StopBit4
            // 
            this.cbI_StopBit4.Text = "2";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX2.Location = new System.Drawing.Point(140, 265);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(58, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 23;
            this.buttonX2.Text = "取消";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.Location = new System.Drawing.Point(39, 265);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(58, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 22;
            this.buttonX1.Text = "确定";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // lb_Parity
            // 
            this.lb_Parity.AutoSize = true;
            this.lb_Parity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Parity.Location = new System.Drawing.Point(32, 211);
            this.lb_Parity.Name = "lb_Parity";
            this.lb_Parity.Size = new System.Drawing.Size(56, 17);
            this.lb_Parity.TabIndex = 17;
            this.lb_Parity.Text = "校验位：";
            // 
            // lb_StopBit
            // 
            this.lb_StopBit.AutoSize = true;
            this.lb_StopBit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_StopBit.Location = new System.Drawing.Point(32, 166);
            this.lb_StopBit.Name = "lb_StopBit";
            this.lb_StopBit.Size = new System.Drawing.Size(56, 17);
            this.lb_StopBit.TabIndex = 16;
            this.lb_StopBit.Text = "停止位：";
            // 
            // lb_DataBits
            // 
            this.lb_DataBits.AutoSize = true;
            this.lb_DataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_DataBits.Location = new System.Drawing.Point(32, 122);
            this.lb_DataBits.Name = "lb_DataBits";
            this.lb_DataBits.Size = new System.Drawing.Size(56, 17);
            this.lb_DataBits.TabIndex = 15;
            this.lb_DataBits.Text = "数据位：";
            // 
            // lb_BaudRate
            // 
            this.lb_BaudRate.AutoSize = true;
            this.lb_BaudRate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_BaudRate.Location = new System.Drawing.Point(32, 78);
            this.lb_BaudRate.Name = "lb_BaudRate";
            this.lb_BaudRate.Size = new System.Drawing.Size(56, 17);
            this.lb_BaudRate.TabIndex = 14;
            this.lb_BaudRate.Text = "波特率：";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Port.Location = new System.Drawing.Point(31, 34);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(56, 17);
            this.lb_Port.TabIndex = 12;
            this.lb_Port.Text = "串口号：";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "6";
            // 
            // PortParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 319);
            this.Controls.Add(this.gp_Parameter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PortParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯参数设置";
            this.Load += new System.EventHandler(this.PortParameter_Load);
            this.gp_Parameter.ResumeLayout(false);
            this.gp_Parameter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_Parameter;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label lb_Parity;
        private System.Windows.Forms.Label lb_StopBit;
        private System.Windows.Forms.Label lb_DataBits;
        private System.Windows.Forms.Label lb_BaudRate;
        private System.Windows.Forms.Label lb_Port;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_StopBits;
        private DevComponents.Editors.ComboItem cbI_StopBit1;
        private DevComponents.Editors.ComboItem cbI_StopBit2;
        private DevComponents.Editors.ComboItem cbI_StopBit3;
        private DevComponents.Editors.ComboItem cbI_StopBit4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Parity;
        private DevComponents.Editors.ComboItem cbI_Parity1;
        private DevComponents.Editors.ComboItem cbI_Parity2;
        private DevComponents.Editors.ComboItem cbI_Parity3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_DataBits;
        private DevComponents.Editors.ComboItem cbI_DataBits1;
        private DevComponents.Editors.ComboItem cbI_DataBits2;
        private DevComponents.Editors.ComboItem cbI_DataBits3;
        private DevComponents.Editors.ComboItem cbI_DataBits4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_BaudRate;
        private DevComponents.Editors.ComboItem cbI_BaudRate1;
        private DevComponents.Editors.ComboItem cbI_BaudRate2;
        private DevComponents.Editors.ComboItem cbI_BaudRate3;
        private DevComponents.Editors.ComboItem cbI_BaudRate4;
        private DevComponents.Editors.ComboItem cbI_BaudRate5;
        private DevComponents.Editors.ComboItem cbI_BaudRate6;
        private DevComponents.Editors.ComboItem cbI_BaudRate7;
        private DevComponents.Editors.ComboItem cbI_BaudRate8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_Port;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.Label lb_showPortInfo;
    }
}