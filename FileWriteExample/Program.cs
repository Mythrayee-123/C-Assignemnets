using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriteExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write the data from the commandprompt to the file 
            Console.WriteLine("Enter te file Name:");
            String fileName = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(fileName);

            if (fileInfo.Exists)
            {
                //write Data from the command prompt to the file.
                Console.WriteLine("Please write a message");
                String message = Console.ReadLine();

                StreamWriter sr = new StreamWriter(fileName);
                sr.WriteLine(message);
                Console.WriteLine("Message has been entered");
                Console.ReadLine();
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
