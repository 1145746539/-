using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具类与测试的集合.jiyuan
{
    /// <summary>
    /// 报警信息对象
    /// </summary>
    class DTlogfile
    {

        public int ID { get; set; }

        public string MachineID { get; set; }

        /// <summary>
        /// 日期 yyyy/MM/dd
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 报警持续时间
        /// </summary>
        public double Downtime { get; set; }

        /// <summary>
        /// 报警开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 报警结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 报警信息说明
        /// </summary>
        public string Description { get; set; }

        public string Remark { get; set; }
    }

}
