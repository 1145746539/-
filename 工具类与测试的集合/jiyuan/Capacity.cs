using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具类与测试的集合.jiyuan
{
    /// <summary>
    /// 每小时产能映射对象
    /// </summary>
    class Capacity
    {
        public int ID { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 产能地址 该时间段内
        /// </summary>
        public string OpAdr { get; set; }

        /// <summary>
        /// 班别
        /// </summary>
        public string Classes { get; set; }


    }

}
