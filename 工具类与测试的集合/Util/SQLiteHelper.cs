using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace 工具类与测试的集合.Util
{
    /// <summary>
    /// SQLite 操作类
    /// </summary>
    class SQLiteHelper
    {
        /// <summary>
        /// 数据库连接定义
        /// </summary>
        public SQLiteConnection connection;

        /// <summary>
        /// SQL命令定义
        /// </summary>
        public SQLiteCommand command;

        /// <summary>
        /// 数据读取定义
        /// </summary>
        public SQLiteDataReader dataReader;


        /// <summary>
        /// 数据库连接字符串定义
        /// </summary>
        public SQLiteConnectionStringBuilder connectionStringBuilder;


        public SQLiteHelper()
        {

        }



        //创建数据库文件
        //        SQLiteConnection.CreateFile(dbName);
        //             //建立数据库连接并打开数据库
        //            SQLiteConnection conn = new SQLiteConnection();
        //        SQLiteConnectionStringBuilder connsb = new SQLiteConnectionStringBuilder();
        //        connsb.DataSource = dbName;
        //          connsb.Password = "acen";
        //          conn.ConnectionString = connsb.ToString();
        //          conn.Open();

        //            //添加表
        //            SQLiteCommand cmd = new SQLiteCommand(conn);
        //        string cmdText = "CREATE TABLE TEST(ID int,name varchar(20))";
        //        cmd.CommandText = cmdText;
        //          cmd.ExecuteNonQuery();

        //            //插入测试数据
        //            cmd.CommandText = "INSERT INTO [TEST] (ID,name) VALUES (1,'acen')";
        //          cmd.ExecuteNonQuery();
        //          cmd.CommandText = "INSERT INTO [TEST] (ID,name) VALUES (2,'unique')";
        //          cmd.ExecuteNonQuery();

        //          //查询结果
        //           cmd.CommandText = "SELECT * FROM [TEST]";
        //         SQLiteDataReader dr = cmd.ExecuteReader();
        //        StringBuilder sb = new StringBuilder();
        //         while (dr.Read())
        //         {
        //             sb.Append(dr.GetInt32(0)).Append(""n").Append(dr.GetString(1));
        //         }
        //    Console.WriteLine(sb);
        //         Console.ReadKey();
        //        }

        public static readonly string dbName = @"D:\DataBase\test.db";
        public static bool CreateSQLite(string DBbasePath  )
        {
            bool Is_Success = false;
            SQLiteConnection conn = new SQLiteConnection();  //创建数据库连接
            try
            {
                DBbasePath = DBbasePath == null ? dbName : DBbasePath;
                SQLiteConnection.CreateFile(DBbasePath);  //创建数据库文件
                                                         
                SQLiteConnectionStringBuilder connsb = new SQLiteConnectionStringBuilder();
                connsb.DataSource = DBbasePath;

                conn.ConnectionString = connsb.ToString();
                conn.Open();
                conn.ChangePassword("admin");  //设置密码
                Is_Success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            finally
            {
                conn.Close();
            }
            
            return Is_Success;
        }





    }
}
