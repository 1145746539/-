using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 工具类与测试的集合.Singleton
{
    public partial class Form_2 : Form
    {
        private Form_2()
        {
            InitializeComponent();
        }

        private static Form_2 frm = null;


        public static Form GetCaseForm_2()
        {
            //子窗口已经被销毁，但是对象却不为空。
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form_2();
            }

            return frm;
        }

        private static Form_2 fr = new Form_2();

        public static Form GetCaseForm_2_1()
        {
            //关闭窗口后再调用会报错。fr已经被销毁
            return fr;
        }


        private void Form_2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form_2_Load(object sender, EventArgs e)
        {

        }
    }
}
