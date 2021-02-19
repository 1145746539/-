using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using 工具类与测试的集合.jiyuan;

namespace 工具类与测试的集合.Util
{
    class ExcelUtil
    {
        private ExcelUtil() { }
        private static ExcelUtil excelUtil = null;
        public static ExcelUtil Instance()
        {
            if (excelUtil == null)
            {
                excelUtil = new ExcelUtil();
            }
            return excelUtil;
        }
        /// <summary>
        /// DataTable导出成Excel(去除数据库ID列)
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="file"></param>
        public void TableToExcel(DataTable dt, string file)
        {
            IWorkbook workbook;
            if (!File.Exists(file))
            {
                File.Create(file).Dispose();
            }
            
            string fileExt = Path.GetExtension(file).ToLower();
            if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(); } else { workbook = null; }
            if (workbook == null) { return; }
            ICellStyle style2 = workbook.CreateCellStyle();
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//【Center】居中  
            ISheet sheet = string.IsNullOrEmpty(dt.TableName) ? workbook.CreateSheet("Sheet1") : workbook.CreateSheet(dt.TableName);
            //表头  
            IRow row = sheet.CreateRow(0);
            
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = row.CreateCell(i);
                cell.CellStyle = style2;
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }

            //数据  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow row1 = sheet.CreateRow(i+1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = row1.CreateCell(j);
                    cell.CellStyle = style2;
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }

            //转为字节数组  
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件  
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }

        }

        public void updateExcel(DataTable dt )
        {
            FileStream fs = File.Open(@"C:\para\JY-A02.xlsx", FileMode.Open, FileAccess.ReadWrite);
            IWorkbook workbook = new XSSFWorkbook(fs);
            ICellStyle style2 = workbook.CreateCellStyle();
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//【Center】居中  
            XSSFSheet sheet = workbook.GetSheetAt(3) as XSSFSheet;


            //数据  
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow row1 = sheet.CreateRow(i + 1); //第二行开始
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = row1.CreateCell(j);
                    //cell.CellStyle = style2;
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }
            fs.Close();
            using (var wook = new FileStream(@"C:\para\JY-A02.xlsx", FileMode.Create, FileAccess.Write))
            {
                workbook.Write(wook);
            }

        }


        public void ListToExcel(List<DTlogfile> list, string file)
        {



            //object obj = Activator.CreateInstance(type);

            //ICell cell0 = row.CreateCell(0);
            //cell0.CellStyle = style2;
            //cell0.SetCellValue("MachineID");

            //ICell cell1 = row.CreateCell(1);
            //style2.DataFormat = dataformat.GetFormat("yyyy/MM/dd");
            //cell1.CellStyle = style2;
            //cell1.SetCellValue("Date");

            //ICell cell2 = row.CreateCell(2);
            //cell2.CellStyle = style3;
            //cell2.SetCellValue("ErrorCode");


            //ICell cell3 = row.CreateCell(3);
            //cell3.CellStyle = style3;
            //cell3.SetCellValue("Downtime");

            //ICell cell4 = row.CreateCell(4);
            //style2.DataFormat = dataformat.GetFormat("yyyy/MM/dd hh:mm:ss");
            //cell4.CellStyle = style2;
            //cell4.SetCellValue("StartTime");

            //ICell cell5 = row.CreateCell(5);
            //style2.DataFormat = dataformat.GetFormat("yyyy/MM/dd hh:mm:ss");
            //cell5.CellStyle = style2;
            //cell5.SetCellValue("EndTime");

            //ICell cell6 = row.CreateCell(6);

            //cell6.CellStyle = style3;
            //cell6.SetCellValue("Description");

            //ICell cell7 = row.CreateCell(7);
            //cell7.CellStyle = style3;
            //cell7.SetCellValue("Remark");

            FileStream fs = File.Open(@"C:\para\JY-A02.xlsx", FileMode.Open, FileAccess.ReadWrite);
            IWorkbook workbook = new XSSFWorkbook(fs);
            XSSFSheet sheet = workbook.GetSheetAt(3) as XSSFSheet;

            IDataFormat dFormat = workbook.CreateDataFormat();

            ICellStyle styleOne = workbook.CreateCellStyle();
            styleOne.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//居中  
            ICellStyle styleTwo = workbook.CreateCellStyle();
            styleTwo.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//居中  

            //数据  
            
            for (int i = 0; i < list.Count; i++)
            {
                IRow row1 = sheet.CreateRow(i + 1); //第二行开始

                ICell cellmID = row1.CreateCell(0);
                cellmID.CellStyle = styleOne;
                cellmID.SetCellValue(list[i].MachineID);

                ICell cellDate = row1.CreateCell(1);
                styleTwo.DataFormat = dFormat.GetFormat("yyyy/MM/dd");
                cellDate.CellStyle = styleTwo;
                cellDate.SetCellValue(DateTime.ParseExact(list[i].Date.ToString("yyyy/MM/dd"), "yyyy/MM/dd", null));

                ICell cellECode = row1.CreateCell(2);
                cellECode.CellStyle = styleOne;
                cellECode.SetCellValue(list[i].ErrorCode);

                ICell cellDtime = row1.CreateCell(3);
                styleTwo.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.0");
                cellDtime.CellStyle = styleTwo;
                cellDtime.SetCellValue(list[i].Downtime);

                ICell cellsTime = row1.CreateCell(4);
                styleTwo.DataFormat = dFormat.GetFormat("hh:mm:ss");
                cellsTime.CellStyle = styleTwo;
                cellsTime.SetCellValue(list[i].StartTime);

                ICell celleTime = row1.CreateCell(5);
                styleTwo.DataFormat = dFormat.GetFormat("hh:mm:ss");
                celleTime.CellStyle = styleTwo;
                celleTime.SetCellValue(list[i].EndTime);

                ICell cellDption = row1.CreateCell(6);
                cellDption.CellStyle = styleOne;
                cellDption.SetCellValue(list[i].Description);

                ICell cellRemark = row1.CreateCell(7);
                cellRemark.CellStyle = styleOne;
                cellRemark.SetCellValue(list[i].Remark);

            }

            fs.Close();
            using (var wook = new FileStream(@"C:\para\JY-A02.xlsx", FileMode.Create, FileAccess.Write))
            {
                workbook.Write(wook);
            }

        }

        Excel.Application xApp;
        /*  Microsoft.Office.Interop.*/
        Excel.Workbook xBook;
        /*   Microsoft.Office.Interop.*/
        Excel.Worksheet xSheet;
        Excel.Worksheet ySheet;

        //手动导出OEE
        public void writeExcel_Manual(string filepath)
        {

            try
            {
                //创建Applicaton对象
                xApp = new /*Microsoft.Office.Interop.*/Excel.Application();
                //不弹出Excel文件
                xApp.Visible = false;

                //得到workbook对象，可以用两种方式之一：下面是打开已有的文件
                /*Microsoft.Office.Interop.*/
                xBook = xApp.Workbooks.Open(filepath);

                //3.指定要操作的Sheet
                /*Microsoft.Office.Interop.*/
                xSheet = (/*Microsoft.Office.Interop.*/Excel.Worksheet)xBook.Sheets[2];
                ySheet = (/*Microsoft.Office.Interop.*/Excel.Worksheet)xBook.Sheets[4];
                //zSheet = (/*Microsoft.Office.Interop.*/Excel.Worksheet)xBook.Sheets[3];




                #region OEE相关值写入

                //4.写入数据
                Excel.Range MachineName = xSheet.get_Range("C3", Missing.Value);//机台名称
                MachineName.Value2 = "BG To Band"; //ini
                Excel.Range MachineId = xSheet.get_Range("D3", Missing.Value);//机台编号
                MachineId.Value2 = "02"; //ini

                Excel.Range Forct = xSheet.get_Range("D6", Missing.Value);//机台CT(周)
                Forct.Value2 = "20";   //ini

                string date = DateTime.Now.AddDays(-1).Date.ToString();
                if (DateTime.Now.Hour >= 8)
                    date = DateTime.Now.Date.ToString();
                Excel.Range dat = xSheet.get_Range("E5", Missing.Value);//对应列的日期
                dat.Value2 = date;

                Excel.Range plate = xSheet.get_Range("E6", Missing.Value);//机台CT(天)
                plate.Value2 = "20";  //ini

                Excel.Range PlanH = xSheet.get_Range("E10", Missing.Value);//机台计划生产时间（小时）
                if (Convert.ToDouble(20) >= 0)
                    PlanH.Value2 = 20;
                else
                    PlanH.Value2 = 0;

                Excel.Range Eq_Pneu = xSheet.get_Range("E13", Missing.Value);//气动故障时间(分钟)
                if (18 > 0)
                    Eq_Pneu.Value2 = 18;
                else
                    Eq_Pneu.Value2 = 0;


                Excel.Range Eq_Mec = xSheet.get_Range("E14", Missing.Value);//机械故障时间(分钟)
                if (19 > 0)
                    Eq_Mec.Value2 = 19;
                else
                    Eq_Mec.Value2 = 0;


                Excel.Range Eq_Ele = xSheet.get_Range("E15", Missing.Value);//电故障时间(分钟)
                if (20 > 0)
                    Eq_Ele.Value2 = 20;
                else
                    Eq_Ele.Value2 = 0;

                Excel.Range Eq_Fix = xSheet.get_Range("E16", Missing.Value);//修理故障时间(分钟)
                Eq_Fix.Value2 = 0;

                Excel.Range Eq_Oth = xSheet.get_Range("E17", Missing.Value);//其他故障时间(分钟)
                Eq_Oth.Value2 = 0;

                Excel.Range Por_Ad = xSheet.get_Range("E18", Missing.Value);//制程调整时间(分钟)
                if (30 > 0)
                    Por_Ad.Value2 = 30;
                else
                    Por_Ad.Value2 = 0;

                Excel.Range Pro_Co = xSheet.get_Range("E19", Missing.Value);//制程消耗时间(分钟)
                if (19 > 0)
                    Pro_Co.Value2 = 19;
                else
                    Pro_Co.Value2 = 0;

                Excel.Range Pro_fai = xSheet.get_Range("E20", Missing.Value);//FAI时间(分钟)

                Pro_fai.Value2 = 0;

                Excel.Range Pro_O = xSheet.get_Range("E21", Missing.Value);//制程其他时间(分钟)
                Pro_O.Value2 = 0;


                Excel.Range Wait = xSheet.get_Range("E22", Missing.Value);//待料时间(分钟)
                if (30 < Convert.ToDouble(1) * 60)
                    Wait.Value2 = 30;
                else
                    Wait.Value2 = Convert.ToDouble(1) * 60;
                Excel.Range Break = xSheet.get_Range("E23", Missing.Value);//休息时间(分钟)

                if (120 > 0)
                    Break.Value2 = 120;
                else
                    Break.Value2 = 0;

                Excel.Range Other_change = xSheet.get_Range("E24", Missing.Value);//其他换料休息
                Other_change.Value2 = 0;

                Excel.Range Other_macOff = xSheet.get_Range("E25", Missing.Value);//其他关机
                if (20 > 0)
                    Other_macOff.Value2 = 20;
                else
                    Other_macOff.Value2 = 0;


                Excel.Range Other_other = xSheet.get_Range("E26", Missing.Value);//其他
                Other_other.Value2 = 0;

                Excel.Range Toss_glue = xSheet.get_Range("E27", Missing.Value);//抛料胶水
                Toss_glue.Value2 = 0;
                Excel.Range Toss_ccd = xSheet.get_Range("E28", Missing.Value);//抛料CCD
                Toss_ccd.Value2 = 0;

                Excel.Range CCDToss = xSheet.get_Range("E29", Missing.Value);//抛料
                if (30 > 0)
                    CCDToss.Value2 = 30;
                else
                    CCDToss.Value2 = 0;

                Excel.Range Toss_glup = xSheet.get_Range("E30", Missing.Value);//抛料胶水路径

                Toss_glup.Value2 = 0;

                Excel.Range Toss_other = xSheet.get_Range("E31", Missing.Value);//抛料其他
                Toss_other.Value2 = 0;


                /*Microsoft.Office.Interop.*/
                Excel.Range wrong_amount = xSheet.get_Range("E34", Missing.Value);//实际产量
                if (1200 > 0)
                    wrong_amount.Value2 = 120;//从数据库获取的故实际产量(因为没有不良品)
                else
                    wrong_amount.Value2 = 0;

                #endregion

                #region DT log相关值写入
                string dateTimeStart4;
                string dateTimeEnd4;



                //dateTimeStart4 = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 08:00:00");
                //if (DateTime.Now.Hour >= 8)
                //    dateTimeStart4 = DateTime.Now.ToString("yyyy-MM-dd 08:00:00");
                //dateTimeEnd4 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                //dateTimeStart4 = Convert.ToDateTime(dateTimeStart4).ToString("s");
                //dateTimeEnd4 = Convert.ToDateTime(dateTimeEnd4).ToString("s");


                //string cmd8 = "select Machine_ID,substr(Date,1,10),Error_Code,DownTime,substr(StartTime,-8),substr(EndTime,-8),Description,Remark from DT_Log" + " where StartTime >='" + dateTimeStart4 + "' AND StartTime <'" + dateTimeEnd4 + "'";
                //SQLiteDataAdapter da = new SQLiteDataAdapter(cmd8, mainForm.sqlite.dbConnection);
                AccessHelper acHelper = AccessHelper.Instance();
                DataTable ddt = acHelper.ExecuteDatable("select MachineID,Date,ErrorCode,Downtime,StartTime,EndTime,Description,Remark from DTlogfile");

                //DataTable ddt = new DataTable();
                //da.Fill(ddt);


                //获取数据库里面数据的行数以及列数
                int rows = ddt.Rows.Count;
                int columns = ddt.Columns.Count;
                //从Excel中的第2行，第1列开始插入
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        ySheet.Cells[2 + i, 1 + j] = ddt.Rows[i][j].ToString();
                    }
                }
                #endregion




                //关闭EXCEL的提示框
                xApp.DisplayAlerts = false;

                //5.保存保存WorkBook
                //xBook.Save();
                //OEEMetrics_設備名稱_設備編號_廠區_樓層_日期(YYDDMM)
                string fileDir = @"C:\para\OEEData";
                if (!Directory.Exists(fileDir))
                {
                    Directory.CreateDirectory(fileDir);
                }

                string filePath = @"C:\para\OEEData" + @"\" + "手动1" + ".xlsx";
                //string filePath = @"D:\luster\OEEData" + @"\" +"/"+ ".xls";
                xBook.SaveAs(filePath);
                xSheet = null;
                ySheet = null;
                //zSheet = null;
                xBook.Close();
                xBook = null;
                xApp.Quit();
                xApp = null;
                MessageBox.Show("OEE数据导出成功");

            }
            catch (Exception ex)
            {
                xSheet = null;
                xBook.Close();
                xBook = null;
                ySheet = null;
                //zSheet = null;
                xApp.Quit();
                xApp = null;
                MessageBox.Show(ex.ToString());

            }
        }

    }

}
