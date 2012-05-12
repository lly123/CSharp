using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;

namespace CSharpDemo
{
    class ThreadDo
    {
        public static void Run()
        {
            Console.Out.WriteLine("Thread ID: " + Thread.CurrentThread.ManagedThreadId);
        }
    } 

    class UseThread
    {
        private static AutoResetEvent waitEvent = new AutoResetEvent(false);
        private static object threadLock = new object();

        public void DoIt()
        {
            var thread = new Thread(ThreadDo.Run);
            thread.Start();

            thread = new Thread(new ParameterizedThreadStart(Run));
            thread.Start("Hello World!");

            waitEvent.WaitOne();
            Console.Out.WriteLine("Thread finished.");

            new Thread(LoopNum).Start();
            new Thread(LoopNum).Start();
        }

        private static void Run(object data)
        {
            if (data is string)
            {
                Console.Out.WriteLine("Thread 2 : " + data);
            }
            waitEvent.Set();
        }

        private static void LoopNum()
        {
            lock (threadLock)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Out.WriteLine("TID: " + Thread.CurrentThread.ManagedThreadId + " Num: " + i);
                    Thread.Yield();
                }   
            }
        }
    }
}
