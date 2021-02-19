using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简单串口调试.Service
{
    class MainService
    {
        public static MainService mainService = null;
        public static SerialPort sp = new SerialPort();
        private MainService() { }

        /// <summary>
        /// 获取MainService对象
        /// </summary>
        /// <returns></returns>
        public static MainService Install()
        {
            if (mainService == null)
            {

                mainService = new MainService();
                
            }
            return mainService;
        }

        /// <summary>
        /// 读取参数显示到界面
        /// </summary>
        /// <param name="strip"></param>
        public void ReadParaShow(StatusStrip strip)
        {
            foreach (ToolStripStatusLabel item in strip.Items)
            {
                string key = item.Name.Split('_')[1];
                string value = INIHelper.Read("Parameter", key, "", PortParaServcie.filePath);
                item.Text = item.Text.Split('：')[0] +"："+value + " |";
            }
           
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <returns></returns>
        public bool OpenPort()
        {
            if (PortParaServcie.Install().GetPort().Length==0)
            {
                MessageBox.Show("打开串口错误，本机没有串口！", "警告");
                return false;
            }
            
            
            try
            {
                string port = INIHelper.Read("Parameter", "Port", "", PortParaServcie.filePath);
                string baudRate = INIHelper.Read("Parameter", "BaudRate", "", PortParaServcie.filePath);
                string dataBits = INIHelper.Read("Parameter", "DataBits", "", PortParaServcie.filePath);
                string stopBits = INIHelper.Read("Parameter", "StopBits", "", PortParaServcie.filePath);
                string parity = INIHelper.Read("Parameter", "Parity", "", PortParaServcie.filePath);
                
                sp.PortName = port;
                sp.BaudRate = int.Parse(baudRate);
                sp.DataBits = int.Parse(dataBits);
                sp.StopBits = (StopBits)int.Parse(stopBits);
                switch (parity)             //校验位
                {
                    case "无":
                        sp.Parity = Parity.None;
                        break;
                    case "奇校检":
                        sp.Parity = Parity.Odd;
                        break;
                    case "偶校检":
                        sp.Parity = Parity.Even;
                        break;
                }
                sp.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口参数设置错误!" + ex.Message, "错误");
            }
            
            return false;
        }

        
    }
}
