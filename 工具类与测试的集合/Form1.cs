using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using 工具类与测试的集合.Util;
using 工具类与测试的集合._0516;
using 工具类与测试的集合.jiyuan;
using System.Threading;

namespace 工具类与测试的集合
{
    public partial class Form1 : Form
    {
        public bool IsTegether { get; set; }
        AutoSizeFormClass asc = new AutoSizeFormClass();

        public Form1()
        {
            InitializeComponent();
            //this.WindowState = (System.Windows.Forms.FormWindowState)(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string Recipepath = Application.StartupPath + "\\Recipe\\";
            bool bl = this.HasChildren;
            string bv = System.AppDomain.CurrentDomain.BaseDirectory;

            string contect = HttpWeb.HttpPostOrGet("http://www.hko.gov.hk/cgi-bin", "GET", "text/html, application/xhtml+xml", "a=1");

            //var fileName = @"D:\testDB.db";
            //SQLiteConnection.CreateFile(fileName);
            //SQLiteHelper.CreateSQLite(null);
            //string dbPath = @"D:\DataBase\test.db";
            //SQLiteConnection.CreateFile(dbPath);



            Console.WriteLine("Click");
            Books book = new Books();
            book.BookId = 1;
            book.BookName = "书籍1";
            book.BookCount = 999;
            string LK = null;
            int result = 0;
            int NLK = int.TryParse(LK, out result) ? int.Parse(LK) : 0;

            //ReadXML.Read_XML_Text("CbItems.xml");
            // Dictionary<string,string> str = ReadXML.dynamicDic;

            //string showString = HttpWeb.ChangeFormJson(book);
            //Books bk = HttpWeb.ChangeFormObject<Books>(showString);

            string showString = (string)HttpWeb.ChangeType(book, null);
            Books bk = (Books)HttpWeb.ChangeType(new Books(), showString);

            //richTextBox1.Text = showString+"\n"+ bk.BookId + "\t" + bk.BookName;
            richTextBox1.Text = NLK.ToString();

            richTextBox1.Text = bv;

        }

        private void Change(out int v)
        {
            v = 100;
        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseClick");

        }

        /// <summary>
        /// 下拉框改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void offset_CAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectText();
        }
        /// <summary>
        /// 双击显示或者隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetSelectText();
            offset_CAA.Visible = offset_CAA.Visible ? false : true;
            offset_CAAText.Visible = offset_CAAText.Visible ? false : true;
        }

        private void SetSelectText()
        {
            object obj = offset_CAA.SelectedItem;
            if (obj != null)
            {
                string LK = ReadXML(obj.ToString());
                int res = 0;
                int n = LK == null ? 0 : int.TryParse(LK, out res) ? int.Parse(LK) : 0;
                Console.WriteLine(res);
                offset_CAAText.Text = n.ToString();
            }
        }


        /// <summary>
        /// 回车保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void offset_CAA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                object obj = offset_CAA.SelectedItem;
                if (obj != null)
                {
                    string offset_Select = offset_CAA.SelectedItem.ToString();
                    string text = offset_CAAText.Text.Trim();
                    if (!String.IsNullOrWhiteSpace(text))  //非空进入
                    {
                        int value = 0;
                        if (int.TryParse(text, out value)) //是int型
                        {
                            ModifyXML(offset_Select, text);
                            MessageBox.Show("设置的参数为：" + offset_CAAText.Text, "提示");
                        }
                        else
                        {
                            MessageBox.Show("请输入整数或者不输入", "提示");

                        }

                    }
                    else  //为空，赋值 0 
                    {
                        ModifyXML(offset_Select, "0");
                        MessageBox.Show("设置的参数为：0", "提示");
                    }
                    offset_CAAText.Text = ReadXML(offset_Select); //刷新
                }
                else
                {
                    MessageBox.Show("请选择下拉框中的值", "提示");
                }

            }
        }


        public static void CreateXML(string select, string text)
        {
            XmlDocument xml = new XmlDocument();
            XmlDeclaration dec = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement xmlElement = xml.CreateElement("offset_CAA");
            XmlElement xmlNode = xml.CreateElement(select);
            xml.AppendChild(dec);
            xml.AppendChild(xmlElement);
            xmlElement.AppendChild(xmlNode);
            xml.Save("offset_CAAText.xml");

        }

        public static void ModifyXML(string select, string text)
        {
            XmlDocument xml = new XmlDocument();
            if (File.Exists("offset_CAAText.xml"))
            {
                xml.Load("offset_CAAText.xml");
                XmlElement xmlDocument = xml.DocumentElement;
                XmlNodeList xmlNodeList = xmlDocument.SelectNodes(select);
                if (xmlNodeList.Count > 0)  //有节点 修改节点
                {
                    XmlNode node = xmlNodeList.Item(0);
                    node.InnerText = text;
                    xml.Save("offset_CAAText.xml");
                }
                else   //增加节点
                {
                    XmlElement xmlNode = xml.CreateElement(select);
                    xmlDocument.AppendChild(xmlNode);
                    xml.Save("offset_CAAText.xml");
                    ModifyXML(select, text);
                }
            }
            else
            {
                CreateXML(select, text);
                ModifyXML(select, text);
            }
        }

        public static string ReadXML(string node)
        {
            if (!string.IsNullOrWhiteSpace(node))
            {
                XmlDocument xml = new XmlDocument();
                if (File.Exists("offset_CAAText.xml"))
                {
                    xml.Load("offset_CAAText.xml");
                    XmlElement documentElement = xml.DocumentElement;  //获取根节点
                    foreach (XmlNode xmlNode in documentElement)
                    {
                        if (xmlNode.LocalName == node)  //得到指定的节点
                        {
                            return xmlNode.InnerText;
                        }
                    }
                }
            }
            return null;
        }

        public static int n = 0;
        //一秒启动一次
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Datq> lis = new List<Datq>();

            //获取当前时间
            n = n + 1;
            Console.WriteLine(n);
            if (n == 60 * 30)
            {
                if (MessageBox.Show("请更换密封圈", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    n = 0;
                }


            }
        }

        private void btXMLSelect_Click(object sender, EventArgs e)
        {
            Button xmlSelect = sender as Button;
            string ObjectName = xmlSelect.Name.Substring(2);
            
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button btString = sender as Button;
            string name = btString.Name.Substring(2);
            if (name == "Factory")
            {
                FormListFactory.GetCaseFactoryForm().Show();
            }
            else if (name == "Singleton")
            {
                FormListFactory.GetCaseSingleton().Show();
            }
        }

        /// <summary>
        /// 三色灯报警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTricolor_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            Thread.Sleep(3000);
            DateTime endTime = DateTime.Now;
            System.TimeSpan t3 = endTime - startTime;
            string getSeconds = t3.TotalSeconds.ToString("0.0");
            string minu = t3.Minutes.ToString();

            string time = endTime.ToString("yyyy/MM/dd");
            //DateTime date = Convert.ToDateTime(time);
            DateTime date = DateTime.ParseExact(time, "yyyy/MM/dd", null);

            AccessHelper acHelper = AccessHelper.Instance();
            string sql = "insert into DTlogfile(MachineID,[Date],PlcAddress,ErrorCode,Downtime,[StartTime],[EndTime],Description) values " +
                "('" + 12 + "',#" + date + "#,'" + "Mx1x1" + "'," + 12 + "," + 12.1 + ",#" + startTime + "#,#" + endTime + "#,'" + "警报" + "')";

            string sql1 = "insert into DTlogfile(MachineID,[Date],ErrorCode,Downtime,[StartTime],[EndTime],Description) values " +
               "(@MachineID,@Date,@ErrorCode,@Downtime,@StartTime,@EndTime,@Description)";
            acHelper.ExecuteNonQuery(sql);




            Console.WriteLine("");
            //Y0E3 红灯

        }


        private void btJson_Click(object sender, EventArgs e)
        {
            AccessHelper acHelper = AccessHelper.Instance();

            DataTable d = acHelper.ExecuteDatable("select * from Alarm");
            List<Alarm> AList = acHelper.GetEntityFromDataTable<Alarm>(d); //映射实例对象
            ExcelUtil excelUtil = ExcelUtil.Instance();
            //excelUtil.TableToExcel(d, @"C:\para\excelfilename.xls");
            //excelUtil.ListToExcel(AList, @"C:\para\excelfilename.xlsx");

            dataGridView1.DataSource = d;
            //string shortTime = DateTime.Now.ToString("yyyy/MM/dd");
            //string longTime = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");


            //string sql = "insert into DTlogfile(MachineID,[Date],ErrorCode,Downtime,[StartTime],[EndTime],Description) values " +
            //    "('" + 12 + "',#" + shortTime + "#," + 12 + "," + 12.1 + ",#" + longTime + "#,#" + longTime + "#,'" + "警报" + "')";
            //acHelper.ExecuteNonQuery(sql);
            // DataTable da = acHelper.ExecuteDatable("select * from bgtoband");
            //DataTable da = acHelper.ExecuteDatable("select * from DTlogfile");

            //List<Alarm> eList = acHelper.GetEntityFromDataTable<Alarm>(da);
            //List<DTlogfile> eList = acHelper.GetEntityFromDataTable<DTlogfile>(da);






            //DateTime min = DateTime.MinValue;
            //DateTime max = DateTime.MaxValue;
            //Type ty = new SemiFinishedPushPull().GetType();
            //PropertyInfo[] vr = ty.GetProperties();
            ////Object 转 json
            //string showS = HttpWeb.ChangeType(new SemiFinishedPushPull(),null).ToString();
            //SemiFinishedPushPull a = (SemiFinishedPushPull)HttpWeb.ChangeType(new SemiFinishedPushPull(), showS);
            //int n = 0;

        }


        private void button2_Click(object sender, EventArgs e)
        {

            //YieldMonitor ym = new YieldMonitor();
            //ym.YeildAtHour();
            AccessHelper acHelper = AccessHelper.Instance();
            DataTable d = acHelper.ExecuteDatable("select MachineID,Date,ErrorCode,Downtime,StartTime,EndTime,Description,Remark from DTlogfile");
            ExcelUtil excelUtil = ExcelUtil.Instance();
            //excelUtil.writeExcel_Manual(@"C:\para\OEE Metrics Report Template_iPEG_V3.0.xlsx");

            excelUtil.writeExcel_Manual(@"C:\para\JY-A02.xlsx");
            //excelUtil.updateExcel(d);
            //TricolorMonitor tm = new TricolorMonitor(this);
            //tm.ReadRed();
            //tm.ShowText();
            Console.WriteLine(" hao");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

            string q = DateTime.Now.ToString("yyyy/MM/dd").Replace('/', '-');
            if (sender is Label)
            {
                Console.WriteLine("label");
            }
            timer1.Enabled = true;
        }

        private void bt_推拉力_Click(object sender, EventArgs e)
        {
            
            UserInfo userInfo = new UserInfo();
            userInfo.ID = 1;
            userInfo.Name = "jay";
            Object obj = AccessHelper.Instance().GetProperties<UserInfo>(userInfo,"Name");

            Console.Write("");
        }

        class UserInfo
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }

    internal class Datq
    {
        public string u;
    }

    internal class Books
    {

        public string BookName { get; set; }
        public int BookId { get; set; }
        public int BookCount { get; set; }
    }
}
