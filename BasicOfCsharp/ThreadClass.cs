using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BasicOfCsharp
{
    class ThreadClass
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            #region BackGroundThread

            //Thread t = new Thread(new ThreadStart(ThreadMethod));
            //t.IsBackground = true;
            //t.Start();

            #endregion

            #region Parameterized Thread

            //Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            //t.Start(5);
            //t.Join();

            #endregion

            #region Stop a thread

            //bool stopped = false;

            //Thread t = new Thread(new ThreadStart(() =>
            //{
            //    while (!stopped)
            //    {
            //        Console.WriteLine("Running...");
            //        Thread.Sleep(1000);
            //    }
            //}));
            //t.Start();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
            //stopped = true;
            //t.Join();

            #endregion

            #region 
            #endregion
        }
    }
}
