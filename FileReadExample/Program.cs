using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C: \Users\mythr\OneDrive\Desktop\.Net class\Day-1-Note.txt

            Console.WriteLine("Please Enter FilePath");
            string filePath = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                //Read Data from the file to the command prompt.

                StreamReader sr = new StreamReader(filePath);
                string output = sr.ReadToEnd();
                Console.WriteLine(output);
                sr.Close();
            }
            else
            {
                Console.WriteLine("Invalid FilePath");
            }
            Console.Read();
        }
    }
}
