using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 工具类与测试的集合.Singleton;

namespace 工具类与测试的集合.FormList
{
    public partial class SingletonForm : Form
    {
        public SingletonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_1 form_1 = new Form_1();
            form_1.Show();
        }

        /// <summary>
        /// 单例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form_2.GetCaseForm_2().Show();
        }
    }
}
