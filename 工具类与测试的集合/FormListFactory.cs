using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 工具类与测试的集合.FormList;

namespace 工具类与测试的集合
{
    /// <summary>
    /// 简单工厂与单例模式的结合
    /// </summary>
    class FormListFactory
    {
        private FormListFactory(){ }

        private static FactoryForm factoryForm = null;

        private static SingletonForm singletonForm = null;

        public static Form GetCaseFactoryForm()
        {
            if (factoryForm == null || factoryForm.IsDisposed)
            {
                factoryForm = new FactoryForm();
            }
            return factoryForm;
        }

        public static Form GetCaseSingleton()
        {
            if (singletonForm == null || singletonForm.IsDisposed)
            {
                singletonForm = new SingletonForm();
            }
            return singletonForm;
        }
    }
}
