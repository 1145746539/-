using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace 图表
{
    public partial class ChartPictrue : UserControl
    {
        /// <summary>
        /// 图形键值对
        /// </summary>
        private Dictionary<int, Chart> dicChart = new Dictionary<int, Chart>();
        /// <summary>
        /// 数据键值对
        /// </summary>
        public static Dictionary<int, Queue<PointXY>> dicData = new Dictionary<int, Queue<PointXY>>();
        /// <summary>
        /// 计时器
        /// </summary>
        public static Dictionary<int, Stopwatch> dicWatch = new Dictionary<int, Stopwatch>();
        /// <summary>
        /// 图标总数
        /// </summary>
        public int number
        {
            get { return 3 * int.Parse(num); }
        }
        ChartShow cShow = new ChartShow();
        
        /// <summary>
        /// 构造函数
        /// </summary>
        public ChartPictrue()
        {
            InitializeComponent();
            cb_InitChart.DataBindings.Add("Text", this, "num", false, DataSourceUpdateMode.OnPropertyChanged); //绑定

            num = INIHelper.Read("Parameter", "count", "0", PortPara._iniFilePath);
            InitialzeChart(int.Parse(num));

            cb_InitChart.SelectedIndexChanged += new EventHandler((sender, e) =>
            {
                INIHelper.Write("Parameter", "count", num, PortPara._iniFilePath);
                InitialzeChart(int.Parse(num));

            });


            
            //cShow.ShowChart(chart, queueData);
        }

        /// <summary>
        /// 获取指定行列的图表
        /// </summary>
        /// <param name="row">行</param>
        /// <param name="column">列</param>
        /// <returns></returns>
        public Chart GetChart(int row, int column)
        {
            int rc = row * column;
            if (dicChart.ContainsKey(rc))
            {
                return dicChart[rc];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取指定行列的数据
        /// </summary>
        /// <param name="row">行</param>
        /// <param name="column">列</param>
        /// <returns></returns>
        public Queue<PointXY> GetData(int row, int column)
        {
            int rc = row * column;
            if (dicData.ContainsKey(rc))
            {
                return dicData[rc];
            }
            else
            {
                return null;
            }
        
        }
    }
}
