using ConsoleApp2.Concurrent;
using ConsoleApp2.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action3 line3 = new Action3();
            line3.DoAction("");
            Console.Read();
            //VolatileTest volatileTest = new VolatileTest();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Thread t = new Thread(new ThreadStart(() => { volatileTest.count = i; }));
            //    t.Start();
            //}

            //Thread.Sleep(5000);
            //Console.WriteLine(volatileTest.count);
            //Console.Read();
        }
    }
}
