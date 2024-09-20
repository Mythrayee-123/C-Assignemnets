using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFIleSize
{
    internal class Program
    {//check the file size more than 10 MB
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter FilePath");
            string filePath = Console.ReadLine();

            FileInfo fobj = new FileInfo(filePath);
            if (fobj.Exists)
            {
                if (fobj.Length > 10 * 1024 * 1024)
                {
                    Console.WriteLine(fobj.Length);
                }
                else
                {
                    Console.WriteLine("File is less than 10 MB");
                }
            }

            else
            {
                Console.WriteLine("File not exist");
            }

            Console.ReadLine();
        }
    }
}