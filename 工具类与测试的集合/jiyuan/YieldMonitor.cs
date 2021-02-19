using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using 工具类与测试的集合.Util;

namespace 工具类与测试的集合.jiyuan
{
    class YieldMonitor
    {
        private AccessHelper acHelper = AccessHelper.Instance();



        public int YeildAtHour()
        {
            DateTime dt = DateTime.Now;
            int nowHour = dt.Hour; //现在的小时
            int frontHour = dt.AddHours(1).Hour;  //前面的小时
            string nhstring = nowHour.ToString();
            string fhstring = frontHour.ToString();
            if (nowHour < 10)
                nhstring = nowHour.ToString().PadLeft(2, '0');

            if (frontHour < 10)
                fhstring = frontHour.ToString().PadLeft(2, '0');

            string time = nhstring + fhstring;

            string sql1 = "select * from Capacity where Time = '" + time + "'";
            DataTable dt1 = acHelper.ExecuteDatable(sql1);
            List<Capacity> list1 = acHelper.GetEntityFromDataTable<Capacity>(dt1);
            if (list1.Count == 0)
            {
                return 0;
            }
            string opAdr = list1[0].OpAdr;  //某时间段的地址
            string classes = list1[0].Classes; //班别

            MxCommuniUtil mxUtil = MxCommuniUtil.Instance();
            int aData;  //某时间段内产量
            //bool isSuccess = mxUtil.GetDevice(opAdr, out aData);
            bool isSuccess = true;
            aData = 1088;
            if (isSuccess)
            {
                string shorttime = dt.ToString("yyyy/MM/dd");
                string start = dt.ToString("yyyy/MM/dd hh:00;00");
                string end = dt.AddHours(1).ToString("yyyy/MM/dd hh:00;00");

                DateTime date = DateTime.ParseExact(shorttime, "yyyy/MM/dd", null);
                DateTime startTime = DateTime.ParseExact(start, "yyyy/MM/dd hh:00;00", null);
                DateTime endime = DateTime.ParseExact(end, "yyyy/MM/dd hh:00;00", null);

                //查询数据表有没有这个时间段的产量信息
                string sql2 = "select * from Yield where Shorttime = #" + shorttime + "# and  Optime = '" + time + "'";
                DataTable dt2 = acHelper.ExecuteDatable(sql2);
                List<Yield> list2 = acHelper.GetEntityFromDataTable<Yield>(dt2);
                if (list2.Count == 0)
                {
                    
                    //插入
                    string sql3 = "insert into Yield([Shorttime],[Start],[Eed],[Optime],[Output],[Classes]) values " +
                        "(@Shorttime,@Start,@Eed,@Optime,@Output,@Classes)";

                    OleDbParameter[] pa = new OleDbParameter[] {
                        new OleDbParameter("@Shorttime",OleDbType.Date),
                        new OleDbParameter("@Start",OleDbType.Date),
                        new OleDbParameter("@Eed",OleDbType.Date),
                        new OleDbParameter("@Optime",time),
                        new OleDbParameter("@OpAdr",OleDbType.Integer),
                        new OleDbParameter("@Classes",classes)
                        };
                    
                    pa[0].Value = date;
                    pa[1].Value = startTime;
                    pa[2].Value = endime;
                    pa[4].Value = aData;
                    int count = acHelper.ExecuteNonQuery(sql3, pa);
                }
                else
                {
                    //修改
                    string sql4 = "update Yield set [Output] = " + aData + " where [Shorttime] = #" + shorttime + "# and [Optime] = '" + time + "'";
                    int count = acHelper.ExecuteNonQuery(sql4);
                }
            }


            return 1;
        }

    }
}
