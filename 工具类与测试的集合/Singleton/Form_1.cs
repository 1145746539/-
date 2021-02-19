using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 工具类与测试的集合.Util;

namespace 工具类与测试的集合.Singleton
{
    public partial class Form_1 : Form
    {
        DataTable table = new DataTable();
        public Form_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = GetTable();
            //var query =( from q in dt.AsEnumerable()
            //            where q.Field<int>("ID") == 2
            //            select new {
            //                ID= q.Field<int>("ID"),
            //                Name = q.Field<string>("Name"),
            //                CompanyID = q.Field<int>("CompanyID")
            //            });

            var query = (from q in dt.AsEnumerable()
                         group q by q.Field<int>("ID") into g
                         orderby g.Count() descending
                         select new
                         {
                             ID = g.Key,
                             num = g.Count()
                         });


            dataGridView1.DataSource = query;
        }

        public DataTable GetTable()
        {
           
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CompanyID", typeof(int));
            DataRow row1 = table.NewRow();
            //row1["ID"] = 1;
            //row1["Name"] = "zhangsan";
            //row1["CompanyID"] = 1;
            //table.Rows.Add(row1);

            //DataRow row2 = table.NewRow();
            //row2["ID"] = 2;
            //row2["Name"] = "lisi";
            //row2["CompanyID"] = 1;
            //table.Rows.Add(row2);

            DataRow row;
            for (int i = 0; i < 9; i++)
            {
                row = table.NewRow();
                row["ID"] = i;
                row["Name"] = "lisi" + i;
                row["CompanyID"] = 100 + i;
                table.Rows.Add(row);
            }
            DataRow row2 = table.NewRow();
            row2["ID"] = 2;
            row2["Name"] = "lisi";
            row2["CompanyID"] = 1;
            table.Rows.Add(row2);

            DataRow row3 = table.NewRow();
            row3["ID"] = 2;
            row3["Name"] = "lisi";
            row3["CompanyID"] = 1;
            table.Rows.Add(row3);

            DataRow row4 = table.NewRow();
            row4["ID"] = 3;
            row4["Name"] = "lisi";
            row4["CompanyID"] = 1;
            table.Rows.Add(row4);


            return table;
        }

        private void Form_1_Load(object sender, EventArgs e)
        {
            //DataTable dt = GetTable();
            //dataGridView1.DataSource = dt;
        }
    }
}
