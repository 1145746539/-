﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具类与测试的集合.Util
{
    /// <summary>
    /// 数据操作工具类
    /// </summary>
    class DataOperation
    {
        //Property 属性
        //Field 字段


        /// <summary>
        /// 两个对象间属性赋值 
        /// </summary>
        /// <param name="source">源对象</param>
        /// <param name="target">目标对象</param>
        public static void CopyModel(object source, object target)
        {
            Type type1 = source.GetType();
            Type type2 = target.GetType();
            foreach (var item in type1.GetProperties())
            {
                var des = type2.GetProperty(item.Name);
                if (des != null)
                {
                    try
                    {
                        des.SetValue(target,item.GetValue(source,null),null);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                    }

                }
            }
        }
    }
}
