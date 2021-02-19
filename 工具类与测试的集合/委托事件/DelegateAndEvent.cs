using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 工具类与测试的集合.委托事件
{
    public partial class DelegateAndEvent : Form
    {
        public DelegateAndEvent()
        {
            InitializeComponent();
        }

        //定义一个委托 
        public delegate string showTB(string text);
        


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public string showtextBox(string text)
        {
            tb_delegate.Text = text;
            return "OK";
        }
    }
}
