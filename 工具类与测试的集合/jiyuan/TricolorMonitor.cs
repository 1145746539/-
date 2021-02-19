using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using 工具类与测试的集合.Util;

namespace 工具类与测试的集合.jiyuan
{
    /// <summary>
    /// 三色灯监控类（线程类）
    /// </summary>
    class TricolorMonitor
    {
        /// <summary>
        /// 红色灯地址
        /// </summary>
        public static string redAdr = "Y0E3";
        /// <summary>
        /// 绿色灯地址
        /// </summary>
        public static string greenAdr = "Y0E1";
        /// <summary>
        /// MX工具类
        /// </summary>
        private static MxCommuniUtil MXUtil = MxCommuniUtil.Instance();
        /// <summary>
        /// Access数据库操作类
        /// </summary>
        private static AccessHelper acHelper = AccessHelper.Instance();

        /// <summary>
        /// 报警地址表的映射集合
        /// </summary>
        private List<Alarm> AList = new List<Alarm>();

        /// <summary>
        /// 线程锁
        /// </summary>
        private static readonly object locker = new object();

        /// <summary>
        /// 报警账户
        /// </summary>
        public static Dictionary<string, Alarm> dicPr = new Dictionary<string, Alarm>();

        public bool readstate = false;

        private Form1 mForm = null;


        public TricolorMonitor(Form1 mainForm)
        {
            this.mForm = mainForm;
        }

        public void ShowText()
        {
            if (mForm.richTextBox1.Lines.Length > 6)
            {
                string[] newlines = new string[6];
                Array.Copy(mForm.richTextBox1.Lines, mForm.richTextBox1.Lines.Length - 6, newlines, 0, 6);
                mForm.richTextBox1.Lines = newlines;
            }
            mForm.richTextBox1.AppendText(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "\n");

        }

        /// <summary>
        /// 读取红色灯
        /// </summary>
        public void ReadRed()
        {
            try
            {
                DataTable da = acHelper.ExecuteDatable("select * from Alarm"); //读取报警地址数据库
                AList = acHelper.GetEntityFromDataTable<Alarm>(da); //映射实例对象
                int oData = 0, nData = 0;
                while (true)
                {
                    bool pState = MXUtil.Open();
                    if (pState)
                    {
                        bool AState = MXUtil.GetDevice(redAdr, out nData);
                        if (AState & nData != oData & nData == 1) //红色信号出现
                        {
                            oData = nData;
                            //线程 存
                            Thread thread1 = new Thread(ReadAddressRandom);
                            thread1.IsBackground = true;
                            thread1.Start();

                            //线程 取
                            Thread thread2 = new Thread(MonitorAddress);
                            thread2.IsBackground = true;
                            thread2.Start();
                        }
                        int gData;
                        bool gState = MXUtil.GetDevice(greenAdr, out gData);
                        if (gState & gData == 1) //绿色灯
                        {
                            AddOrCutDicPr("clear", new Alarm());

                        }

                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// 读取所有报警地址
        /// </summary>
        /// <param name="AList"></param>
        /// <returns></returns>
        private void ReadAddressRandom()
        {
            readstate = true;
            int n = 0;
            StringBuilder szDevice = new StringBuilder();
            while (readstate)
            {
                Thread.Sleep(500);
                //一百个地址为一组去读取

                if (AList.Count == 0)
                {
                    return;
                }
                int size = AList.Count / 100;
                int count = AList.Count % 100;
                if (count != 0)
                    ++size;
                for (int i = 0; i < size; i++)
                {
                    if (i == size - 1 && 0 != AList.Count % 100)
                        n = i * 100 + count;
                    else
                        n = (i + 1) * 100;
                    for (int p = 100 * i; p < n; p++)
                    {
                        string plcAddress = AList[p].Plc + AList[p].Address;
                        szDevice = szDevice.Append(plcAddress + "\n");
                    }
                    szDevice.Remove(szDevice.Length - 1, 1);
                    int[] Ldata;
                    bool isTrue = MXUtil.ReadDeviceRandom(Convert.ToString(szDevice), n - 100 * i, out Ldata);
                    szDevice.Clear();
                    if (isTrue)
                    {
                        for (int u = 0; u < n - 100 * i; u++)
                        {
                            if (Ldata[u] == 1) //报警
                            {
                                
                                Alarm errorAlarm = AList[100 * i + u];
                                errorAlarm.sTime = DateTime.Now;
                                AddOrCutDicPr("add", errorAlarm);
                                

                            }
                        }

                    }
                }
                
            }

        }

       

        /// <summary>
        /// 监控地址
        /// </summary>
        private void MonitorAddress()
        {
            try
            {
                StringBuilder sDevice = new StringBuilder();
                int lData = 0;
                bool state = true;
                while (state)
                {
                    Thread.Sleep(500);
                    if (dicPr.Count == 0)
                    {
                        return;
                    }
                    int i = 0;
                    List<string> elist = new List<string>();
                    foreach (KeyValuePair<string, Alarm> keyValue in dicPr)
                    {
                        elist[i] = keyValue.Key;
                        i++;
                        sDevice = sDevice.Append(keyValue.Key + "\n");
                        sDevice.Remove(sDevice.Length - 1, 1);
                        int[] Ldata;
                        bool isTrue = MXUtil.ReadDeviceRandom(Convert.ToString(sDevice), dicPr.Count, out Ldata);
                        sDevice.Clear();
                        if (isTrue)
                        {
                            for (int u = 0; u < Ldata.Length; u++)
                            {
                                if (Ldata[u] == 0) //报警解除
                                {
                                    string errAdr = elist[u];
                                    //存入数据库
                                    SetData(dicPr[errAdr]);
                                    AddOrCutDicPr("cut", dicPr[errAdr]); //删除账户中的信息
                                    
                                }
                            }

                        }

                    }

                    if (dicPr.Count == 0)
                    {
                        state = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void SetData(Alarm alarm)
        {
            DateTime endTime = DateTime.Now;
            System.TimeSpan t3 = endTime - alarm.sTime;
            string downtime = t3.TotalSeconds.ToString("0.0");
            string time = endTime.ToString("yyyy/MM/dd");
            DateTime date = DateTime.ParseExact(time, "yyyy/MM/dd", null);
            string sql = "insert into DTlogfile(MachineID,[Date],ErrorCode,Downtime,[StartTime],[EndTime],Description) values " +
              "(@MachineID,@Date,@ErrorCode,@Downtime,@StartTime,@EndTime,@Description)";
            OleDbParameter[] pas = new OleDbParameter[] {
                new OleDbParameter("@MachineID","jiyuanA02"),
                new OleDbParameter("@Date", OleDbType.Date),
                new OleDbParameter("@ErrorCode",alarm.Code),
                new OleDbParameter("@Downtime",downtime),
                new OleDbParameter("@StartTime", OleDbType.Date),
                new OleDbParameter("@EndTime", OleDbType.Date),
                new OleDbParameter("@Description",alarm.Explain)
               
            };
            pas[1].Value = date;
            pas[4].Value = alarm.sTime;
            pas[5].Value = endTime;
            int nc = acHelper.ExecuteNonQuery(sql, pas);
            if (nc>0)
            {
                Console.WriteLine("报警信息存入数据库成功");
            }
        }

        private void AddOrCutDicPr(string v, Alarm errorAlarm)
        {
            lock (locker)
            {
                string errorAddress = errorAlarm.Plc + errorAlarm.Address;
                if (v == "add")
                {

                    if (!dicPr.ContainsKey(errorAddress))
                    {
                        WriteLogHelper.WriteOrCreateLog(null, errorAlarm.Explain);
                        dicPr.Add(errorAddress, errorAlarm);
                    }
                }
                if (v == "cut")
                {
                    if (dicPr.ContainsKey(errorAddress))
                    {
                        dicPr.Remove(errorAddress);
                    }
                }
                if (v == "clear")
                {
                    readstate = false;
                    if(dicPr.Count>0)
                    {
                        foreach (KeyValuePair<string, Alarm> keyValue in dicPr)
                            SetData(dicPr[keyValue.Key]); //存入数据库
                    }
                    dicPr.Clear();
                }

            }
        }

    }


}
