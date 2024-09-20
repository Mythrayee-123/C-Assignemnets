using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSolutions;

namespace ConsumeClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper obj = new Helper();
            int result = obj.GetSimpleInterest(1000, 10, 5);
            Console.WriteLine("Simple interest is " + result);
            Console.Read();

        }
    }
}
