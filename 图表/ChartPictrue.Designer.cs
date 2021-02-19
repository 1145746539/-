using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace 图表
{
    partial class ChartPictrue
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_InitChart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_InitChart
            // 
            this.cb_InitChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_InitChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_InitChart.FormattingEnabled = true;
            this.cb_InitChart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_InitChart.Location = new System.Drawing.Point(371, 3);
            this.cb_InitChart.Name = "cb_InitChart";
            this.cb_InitChart.Size = new System.Drawing.Size(121, 20);
            this.cb_InitChart.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(5, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 150);
            this.button1.TabIndex = 9;
            this.button1.Text = "一\r\n\r\n\r\n\r\n号\r\n\r\n\r\n\r\n穴\r\n";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(5, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 150);
            this.button2.TabIndex = 10;
            this.button2.Text = "二\r\n\r\n\r\n\r\n号\r\n\r\n\r\n\r\n穴";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(5, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 150);
            this.button3.TabIndex = 11;
            this.button3.Text = "三\r\n\r\n\r\n\r\n号\r\n\r\n\r\n\r\n穴";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ChartPictrue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_InitChart);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ChartPictrue";
            this.Size = new System.Drawing.Size(940, 497);
            this.ResumeLayout(false);

        }



        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num">一行中的个数</param>
        private void InitialzeChart(int num)
        {
            foreach (int item in dicChart.Keys)
            {
                this.Controls.Remove(dicChart[item]);
            }
            dicChart.Clear();
           
            dicWatch.Clear();

            int width = this.Size.Width;

            for (int i = 0; i < 3; i++)
            {
                for (int n = 0; n < num; n++)
                {


                    int average = (width - 30) / num;

                    int sum = i*num + (n + 1); //1-3*num
                    chart = new Chart();
                    ChartArea chartArea = new ChartArea();
                    Legend legend = new Legend();
                    Series series = new Series();

                    ((System.ComponentModel.ISupportInitialize)(chart)).BeginInit();
                    chart.Name = "chart"+sum;
                    chart.BackColor = System.Drawing.Color.LightGray;

                    chartArea.Name = "ChartArea" + sum;
                    chart.ChartAreas.Add(chartArea);

                    legend.Alignment = System.Drawing.StringAlignment.Center;
                    legend.BackColor = System.Drawing.Color.IndianRed;
                    legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
                    legend.MaximumAutoSize = 10F;
                    legend.Name = "Legend"+sum;
                    chart.Legends.Add(legend);

                    
                    series.ChartArea = "ChartArea"+sum;
                    series.Color = Color.Red;
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    series.Legend = "Legend"+sum;
                    series.LegendText = sum.ToString();
                    chart.Series.Add(series);

                    //设置显示区域与大小
                    
                    chart.Location = new System.Drawing.Point(30 + n * average , 30+ i * 155);//坐标
                    chart.Size = new System.Drawing.Size(average - 5, 150);//大小

                    chart.Text = "chart"+sum;
                    dicChart.Add(sum, chart);
                    
                    dicWatch.Add(sum, new Stopwatch());
                    this.Controls.Add(chart);

                }


            }
            
        }

        private System.Windows.Forms.ComboBox cb_InitChart;
        public Chart chart;
        public string num { get; set; }
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
