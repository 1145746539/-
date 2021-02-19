using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具类与测试的集合.jiyuan
{
    /// <summary>
    /// 报警地址对象
    /// </summary>
    class Alarm
    {
        
        public int ID { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 代码说明
        /// </summary>
        public string Explain { get; set; }

        /// <summary>
        /// PLC
        /// </summary>
        public string Plc { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 显示颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        public DateTime sTime { get; set; }

    }


}
