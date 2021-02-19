using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 简单串口调试.Service;

namespace 简单串口调试
{
    public partial class PortParameter : Form
    {
        private static PortParameter portParameter = null;

        private PortParaServcie ppService = PortParaServcie.Install();

        private Main ma = null;

        public static event Action<StatusStrip> action;

        public static PortParameter install(Main main)
        {
            if (portParameter == null || portParameter.IsDisposed)
            {
                portParameter = new PortParameter(main);
            }
            return portParameter;
        }
        private PortParameter(Main main)
        {
            MainService ms = MainService.Install();
            this.ma = main;
            action += ms.ReadParaShow;
            InitializeComponent();
        }

        
        //确定 保存
        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            ppService.SetParaMeter(gp_Parameter);
            MessageBox.Show("提示","OK");
            if (ma !=null && action !=null)
            {
                action.Invoke(ma.statusStrip1);
            }
            install(null).Close();
        }

        private void PortParameter_Load(object sender, EventArgs e)
        {
            string[] str = ppService.GetPort();
            if (str.Length > 0)
                this.cb_Port.Items.AddRange(str);
            else
                this.lb_showPortInfo.Text = "本机没有串口！";
            
                
            ppService.ReadParaMeter(gp_Parameter);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            install(null).Close();
        }
    }
}
