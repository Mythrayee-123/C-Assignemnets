using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    internal class Program
    {
        Thread th1, th2;
        public void M1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("i= " + i + " ; ");
                Thread.Sleep(1000);
            }
        }

        public void M2()
        {
            for (int j = 0; j < 50; j++)
            {
                Console.WriteLine("j= " + j);
                Thread.Sleep(1000);
            }
        }
        public void M3()
        {
            th1 = new Thread(M1);
            th2 = new Thread(M2);

            th1.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Lowest;
            th1.Start();
            th2.Start();

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.M3();
            Console.Read();

        }
    }
}
