using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\mythr\OneDrive\Desktop\.Net class\Day-1-Note.txt
            Console.WriteLine("Please Enter FilePath");
            string filePath = Console.ReadLine();

            FileInfo fobj = new FileInfo(filePath);

            if (fobj.Exists)
            {
                //Get the info of the files
                Console.WriteLine(fobj.FullName);
                Console.WriteLine(fobj.Extension);
                Console.WriteLine(fobj.Length);
                Console.WriteLine(fobj.CreationTime);
                Console.WriteLine(fobj.LastWriteTime);
                Console.WriteLine(fobj.DirectoryName);
                Console.WriteLine(fobj.IsReadOnly);
            }
            else
            {
                Console.WriteLine("Invalid FilePath");
            }
            Console.Read();


        }
    }
}
