using System;
using System.Collections.Generic;
using System.Linq;
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
        public void DoIt()
        {
            var thread = new Thread(ThreadDo.Run);
            thread.Start();
        }
    }
}
