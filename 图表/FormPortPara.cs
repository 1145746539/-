using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图表
{
    public partial class FormPortPara : Form
    {
        public PortPara para = null;

        public static FormPortPara FormPort = null;

        public static FormPortPara Install()
        {
            if (FormPort == null || FormPort.IsDisposed)
            {
                FormPort = new FormPortPara();
            }
            return FormPort;
        }

        private FormPortPara()
        {
            InitializeComponent();
            para = new PortPara() { Dock = DockStyle.Fill};
            this.Controls.Add(para);
        }
    }
}
