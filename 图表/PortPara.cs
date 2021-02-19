using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace 图表
{
    public partial class PortPara : UserControl
    {
        //串口对象
        public static SerialPort sp = new SerialPort();
        public static readonly string _iniFilePath = Application.StartupPath + "\\" + "Para.ini";
        private ModBusTools mTools = new ModBusTools();


        public PortPara()
        {

            InitializeComponent();
            this.Load += new EventHandler((sender, e) =>
            {
                ReadPara(this);
            });
            //保存数据
            SaveSerialPort.Click += new EventHandler((sender, e) =>
            {
                SavePara(this);
            });
            Port.Items.AddRange(GetPort());
            //explainData("01030505478474");
        }

        #region 保存与读取参数
        //读取INI文件到控件
        private void ReadPara(Control cor)
        {
            foreach (Control item in cor.Controls)
            {
                if (item.HasChildren)
                {
                    ReadPara(item);
                }
                if (item is ComboBox)
                {
                    item.Text = INIHelper.Read("Parameter", item.Name, "", _iniFilePath);
                }
            }
        }

        //保存至ini
        private void SavePara(Control cor)
        {
            foreach (Control item in cor.Controls)
            {
                if (item.HasChildren)
                {
                    SavePara(item);
                }
                if (item is ComboBox)
                {
                    INIHelper.Write("Parameter", item.Name, item.Text, _iniFilePath);
                }
            }
            OpenPort();
        }
        #endregion

        /// <summary>
        /// 获取本机串口
        /// </summary>
        /// <returns></returns>
        public string[] GetPort()
        {
            string[] str = SerialPort.GetPortNames();
            return str;
        }

        public bool OpenPort()
        {
            //if (GetPort().Length == 0)
            //{
            //    MessageBox.Show("打开串口错误，本机没有串口！", "警告");
            //    return false;
            //}
            if (!sp.IsOpen)
            {
                try
                {
                    sp.PortName = INIHelper.Read("Parameter", "Port", "", _iniFilePath);
                    sp.BaudRate = int.Parse(INIHelper.Read("Parameter", "BaudRate", "", _iniFilePath));
                    sp.StopBits = (StopBits)int.Parse(INIHelper.Read("Parameter", "StopBit", "", _iniFilePath));
                    sp.DataBits = int.Parse(INIHelper.Read("Parameter", "DataBits", "", _iniFilePath));
                    string parity = INIHelper.Read("Parameter", "Parity", "", _iniFilePath);
                    System.IO.Ports.Parity Pa = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parity);
                    sp.Parity = Pa;
                    //超时读取
                    sp.ReadTimeout = -1;
                    sp.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
                    sp.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口参数错误！" + ex.Message, "警告");
                }

            }

            return true;

        }

        //串口接收函数
        private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receive = "";

            while (sp.BytesToRead > 0)
            {
                byte[] readBuffer = new byte[sp.ReadBufferSize + 1];
                int count = sp.Read(readBuffer, 0, sp.ReadBufferSize);
                for (int i = 0; i < count; i++)
                {
                    receive = receive + readBuffer[i].ToString("X2");
                }
                Thread.Sleep(50);
            }
            if (!string.IsNullOrEmpty(receive))
            {

                // WriteLog.WriteOrCreateLog(null, ParaService.infostring + "--收到数据：" + receive);
                //实时解析串口返回数据
                //new ModBusTools().ReceiveData(receive);

            }
        }


        /// <summary>
        /// 穴位启动
        /// </summary>
        bool isGetStart = true;
        /// <summary>
        /// 是否采集数据
        /// </summary>
        bool[] isMini = new bool[4];
        //监控类
        public void Monitor()
        {
            int cave = 1;
            if (isGetStart) //读到了穴位的启动信号，
            {
                isMini[cave] = true;
                isGetStart = false; //置位信号 
                //如果收到了PLC给的启动测试信号 启动计时器 

                int count = ChartPictrue.dicWatch.Count / 3;
                for (int i = (cave - 1) * count + 1; i <= cave * count; i++)
                {
                    ChartPictrue.dicWatch[i].Start();
                    ChartPictrue.dicData.Add(i, new Queue<PointXY>());
                }
                //dicData.Add(sum, new System.Collections.Generic.Queue<PointXY>());
            }


            if (true)//读到了穴位的完成测试信号
            {
                //置位信号 
                int count = ChartPictrue.dicWatch.Count / 3;
                for (int i = (cave - 1) * count + 1; i <= cave * count; i++)
                {
                    ChartPictrue.dicWatch[i].Reset();
                    ChartPictrue.dicData.Remove(i);
                }

            }

            foreach (int item in ChartPictrue.dicData.Keys)
            {
                //如果有值就要显示出来
                if (ChartPictrue.dicData.ContainsKey(item) && ChartPictrue.dicData[item].Count>0)
                {
                    //显示
                }
            }
        }

        //数据解析
        public void explainData(string receive)
        {
            bool isOK = mTools.CRC_Check(receive);
            if (isOK)
            {
                char[] cArray = receive.ToCharArray();
                string head1 = cArray[0].ToString() + cArray[1];//从站地址
                string head2 = cArray[2].ToString() + cArray[3];//功能码
                string value = cArray[6].ToString() + cArray[7] + cArray[8] + cArray[9] + cArray[10] + cArray[11] + cArray[12] + cArray[13];
                if (head2.Equals("03")) //读取
                {
                    int code = int.Parse(head1); //从站地址从01开始，代表第一个仪器
                    if (Judge(code) && ChartPictrue.dicData.ContainsKey(code)) //根据从站地址放入对应的键值对中
                    {

                        Queue<PointXY> p = ChartPictrue.dicData[code];
                        PointXY xY = new PointXY();
                        //解析数据并添加
                        string Yvalue = ConvertBase(value, 2, 10);

                        xY.X = ChartPictrue.dicWatch[code].ElapsedMilliseconds / 1000;
                        xY.Y = Convert.ToDouble(Yvalue);
                        p.Enqueue(xY);


                    }

                }
                Console.WriteLine(head2);
            }
        }

        /// <summary>
        /// 判断电缸属于哪个穴位,是否收集数据
        /// </summary>
        /// <returns></returns>
        public bool Judge(int n)
        {

            double index = n / 3.0 + 0.33;
            int c = Convert.ToInt32(Math.Round(index));
            return isMini[c];
        }


        /// <summary>
        /// 实现各进制数间的转换。ConvertBase("15",10,16)表示将十进制数15转换为16进制的数。
        /// </summary>
        /// <param name="value">要转换的值,即原值</param>
        /// <param name="from">原值的进制,只能是2,8,10,16四个值。</param>
        /// <param name="to">要转换到的目标进制，只能是2,8,10,16四个值。</param>
        public static string ConvertBase(string value, int from, int to)
        {
            try
            {
                int intValue = Convert.ToInt32(value, from);  //先转成10进制
                string result = Convert.ToString(intValue, to);  //再转成目标进制
                if (to == 2)
                {
                    int resultLength = result.Length;  //获取二进制的长度
                    switch (resultLength)
                    {
                        case 7:
                            result = "0" + result;
                            break;
                        case 6:
                            result = "00" + result;
                            break;
                        case 5:
                            result = "000" + result;
                            break;
                        case 4:
                            result = "0000" + result;
                            break;
                        case 3:
                            result = "00000" + result;
                            break;
                    }
                }
                return result;
            }
            catch
            {

                //LogHelper.WriteTraceLog(TraceLogLevel.Error, ex.Message);
                return "0";
            }
        }

    }

    enum Para
    {
        /// <summary>
        /// 校检位
        /// </summary>
        Parity,
        /// <summary>
        /// 波特率
        /// </summary>
        BaudRate,
        /// <summary>
        /// 数据位
        /// </summary>
        DataBits,

        StopBit,

        Port
    }
}
