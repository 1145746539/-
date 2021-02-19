using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具类与测试的集合.Factory
{
    class SumAreaFcatory1
    {
        #region 简单工厂模式
        #region   设计模式第一种  传参数

        /// <summary>
        /// 根据传入的参数创建对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IShape produce(string type)
        {
            IShape s = null;
            if (type == "圆")
            {
                s = new Circle();
            }
            else if (type == "矩形")
            {
                s = new Rectangle();
            }
            else
            {

            }
            return s;
        }
        #endregion


        #region 设计模式第二种  提供不同的方法
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IShape produceCricle()
        {
            IShape s = new Circle();
            return s;
        }

        public IShape produceRectangle()
        {
            IShape s = new Rectangle();
            return s;
        }

        #endregion


        #region 设计模式第三种 静态方法创建

        public static IShape produceCricle1()
        {
            IShape s = new Circle();
            return s;
        }

        public static IShape produceRectangle1()
        {
            IShape s = new Rectangle();
            return s;
        }

        #endregion
        #endregion



    }

    #region 抽象工厂模式

    /// <summary>
    /// 接口
    /// </summary>
    public interface IProvider
    {
        
        
    }
    

    #endregion
}
