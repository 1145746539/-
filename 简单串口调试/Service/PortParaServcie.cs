using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简单串口调试.Service
{
    class PortParaServcie
    {
        public static PortParaServcie paraServcie = null;
        public static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "para.ini");


        private PortParaServcie() { }
        public static PortParaServcie Install()
        {
            if (paraServcie == null)
                paraServcie = new PortParaServcie();

            return paraServcie;
        }

        public void SetParaMeter(Control control)
        {
            foreach (Control conn in control.Controls)
            {
                if (conn.HasChildren)
                {
                    SetParaMeter(conn);
                }
                if (conn is ComboBoxEx) //ComboBoxEx 控件
                {
                    string key = conn.Name.Split('_')[1];
                    string value = conn.Text;
                    INIHelper.Write("Parameter", key, value, filePath);
                }
            }
        }

        public void ReadParaMeter(Control control)
        {
            foreach (Control conn in control.Controls)
            {
                if (conn.HasChildren)
                {
                    ReadParaMeter(conn);
                }
                if (conn is ComboBoxEx) //TextBoxX 控件
                {
                    string key = conn.Name.Split('_')[1];
                    string value = INIHelper.Read("Parameter", key, "", filePath);
                    conn.Text = value;
                    //string value = conn.Text;
                    //INIHelper.Write("Parameter", key, value, filePath);
                }
            }


        }

        /// <summary>
        /// 获取本机串口
        /// </summary>
        /// <returns></returns>
        public string[] GetPort()
        {
            string[] str = SerialPort.GetPortNames();
            return str;
        }
        
        /// <summary>
        /// 将字符串转成byte数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public byte[] TransformString(string value)
        {
            byte[] byteBuffer = new byte[value.Length];
            char[] valueChar = value.ToArray();
            for (int i = 0; i < valueChar.Count(); i++)
            {
                int transNum = Convert.ToInt32(valueChar[i].ToString(), 16);
                byteBuffer[i] = Convert.ToByte(transNum);

            }
            
            return byteBuffer;
        }
    }
}
