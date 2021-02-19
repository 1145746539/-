using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具类与测试的集合.jiyuan
{
    /// <summary>
    /// 产量表
    /// </summary>
    class Yield
    {
        /// <summary>
        /// yyyy/MM/dd
        /// </summary>
        public DateTime Shorttime { get; set; }

        /// <summary>
        /// 开始时段
        /// </summary>
        public DateTime Start { get; set; }


        /// <summary>
        /// 结束时段
        /// </summary>
        public DateTime Eed { get; set; }

        /// <summary>
        /// 时段字符串
        /// </summary>
        public string Optime { get; set; }

        /// <summary>
        /// 产量值
        /// </summary>
        public int Output { get; set; }

        /// <summary>
        /// 班别
        /// </summary>
        public string Classes { get; set; }


    }
}
