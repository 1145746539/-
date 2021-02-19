using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 工具类与测试的集合.Factory;

namespace 工具类与测试的集合.FormList
{
    public partial class FactoryForm : Form
    {
        public FactoryForm()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem.ToString();
            SumAreaFcatory1 sum = new SumAreaFcatory1();
            if (type == "圆")
            {
               richTextBox1.Text = sum.produce(type).Area();
                sum.produceCricle().Area();
            }
            
            
        }
    }
}
