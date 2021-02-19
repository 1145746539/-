using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托练习
{
    delegate void EventHandler(object sender, EventArgs e);
    class Program
    {
        public static event Action<object, EventArgs> action;
        public static event EventHandler SimpleEvent;

        
        static void Main(string[] args)
        {


           

            Subscriber sub = new Subscriber();

            action += sub.MethodA;

            //SimpleEvent += sub.MethodA;
            //SimpleEvent += sub.MethodB;
            run();
            
            //Calculator calculator = new Calculator();
            //Action action = new Action(calculator.Report);
            //action.Invoke();
            //action();

            //Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            //Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

            //int x = 100;
            //int y = 60;
            //int z = 0;
            //z = func1.Invoke(x, y);
            //z = func2(x, y);

            

            Console.ReadKey();

        }

        private static void run()
        {
            action(null,null);
            //SimpleEvent(null,null);
        }

        class Calculator
        {
            public void Report()
            {
                Console.WriteLine(" 我有三种方法 ");
            }

            public int Add(int x ,int y)
            {
                Console.WriteLine("X+y={0}", x + y);
                return x + y;
            }

            public int Sub(int x, int y)
            {
                Console.WriteLine("X-y={0}",x-y);
                return x - y;
            }

        }
    }

    class Subscriber
    {
        public void MethodA(object sender, EventArgs e) { Console.WriteLine("AAA"); }
        public void MethodB(object sender, EventArgs e) { Console.WriteLine("BBB"); }
    }
}
