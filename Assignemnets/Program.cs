using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logic to print random number betwen 1-100
            Random random = new Random();
            int Number = random.Next(0,100);
            Console.WriteLine(Number);
            Console.ReadLine();
        }
    }
}
