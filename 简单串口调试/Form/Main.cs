using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 简单串口调试.Service;

namespace 简单串口调试
{
    public partial class Main : Form
    {

        private MainService mService = MainService.Install();
        public Main()
        {
            InitializeComponent();
            
        }

        private void bt_set_Click(object sender, EventArgs e)
        {
            
            
            PortParameter.install(this).ShowDialog();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainService.Install().ReadParaShow(statusStrip1);
            rdSendStr.Checked = true;
            rbRcvStr.Checked = true;
            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            MainService.sp.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (MainService.sp.IsOpen)     //此处可能没有必要判断是否打开串口，但为了严谨性，我还是加上了
            {
                
                txtReceive.SelectionColor = Color.Blue;         //改变字体的颜色

                byte[] byteRead = new byte[MainService.sp.BytesToRead];    //BytesToRead:sp1接收的字符个数
                if (rdSendStr.Checked)                          //'发送字符串'单选按钮
                {
                    txtReceive.Text += MainService.sp.ReadLine() + "\r\n"; //注意：回车换行必须这样写，单独使用"\r"和"\n"都不会有效果
                    MainService.sp.DiscardInBuffer();                      //清空SerialPort控件的Buffer 
                }
                else                                            //'发送16进制按钮'
                {
                    try
                    {
                        Byte[] receivedData = new Byte[MainService.sp.BytesToRead];        //创建接收字节数组
                        MainService.sp.Read(receivedData, 0, receivedData.Length);         //读取数据
                                                                                           //string text = sp1.Read();   //Encoding.ASCII.GetString(receivedData);
                        MainService.sp.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                       
                        string strRcv = null;
                        //int decNum = 0;//存储十进制
                        for (int i = 0; i < receivedData.Length; i++) //窗体显示
                        {

                            strRcv += receivedData[i].ToString("X2");  //16进制显示
                        }
                        txtReceive.Text += strRcv + "\r\n";
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                        richTextBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }


        private void bt_OpenOrClose_Click(object sender, EventArgs e)
        {
            if (!MainService.sp.IsOpen)//串口没有打开 
            {
                
                if (mService.OpenPort())
                    //打开成功 
                    bt_OpenOrClose.Text = "关闭串口";
            }
            else
            {
                MainService.sp.Close(); //关闭串口
                bt_OpenOrClose.Text = "打开串口";
            }
        }

        private void bt_sendInfo_Click(object sender, EventArgs e)
        {
            //if (!MainService.sp.IsOpen) //串口没有打开
            //{
            //    MessageBox.Show("串口没有打开！请先打开串口", "警告");
            //    return;
            //}

            if (cbTimeSend.Checked)
                timerSend.Enabled = true;
            else
                timerSend.Enabled = false;

            String strSend = richTextBox1.Text;
            if (radio1.Checked == true)	//“HEX发送” 按钮 
            {
                //处理数字转换
                string sendBuf = strSend;
                string sendnoNull = sendBuf.Trim();
                string sendNOComma = sendnoNull.Replace(',', ' ');    //去掉英文逗号
                string sendNOComma1 = sendNOComma.Replace('，', ' '); //去掉中文逗号
                string strSendNoComma2 = sendNOComma1.Replace("0x", "");   //去掉0x
                strSendNoComma2.Replace("0X", "");   //去掉0X
                string[] strArray = strSendNoComma2.Split(' ');

                int byteBufferLength = strArray.Length;
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == "")
                    {
                        byteBufferLength--;
                    }
                }
                // int temp = 0;
                byte[] byteBuffer = new byte[byteBufferLength];
                int ii = 0;
                for (int i = 0; i < strArray.Length; i++)        //对获取的字符做相加运算
                {

                    int decNum = 0;
                    if (strArray[i] == "")
                    {
                        
                        continue;
                    }
                    else
                    {
                        decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                    }

                    try    //防止输错，使其只能输入一个字节的字符
                    {
                        byteBuffer[ii] = Convert.ToByte(decNum);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                        
                        return;
                    }

                    ii++;
                }
                MainService.sp.Write(byteBuffer, 0, byteBuffer.Length);
            }
            else		//以字符串形式发送时 
            {
                MainService.sp.WriteLine(richTextBox1.Text);    //写入数据
            }

        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            string strSecond = txtSecond.Text;
            try
            {
                int isecond = int.Parse(strSecond) * 1000;//微秒为单位
                timerSend.Interval = isecond;
                if (timerSend.Enabled == true)
                {
                    bt_sendInfo.PerformClick();//触发发送事件
                }
            }
            catch (System.Exception ex)
            {
                timerSend.Enabled = false;
                MessageBox.Show("错误的定时输入！", "Error");
            }
        }
    }
}
