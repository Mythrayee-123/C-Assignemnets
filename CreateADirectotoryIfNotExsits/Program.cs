using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CreateADirectotoryIfNotExsits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create A folder If Not Exsits
            //Read FilePath from app settings 
            string filePath = ConfigurationManager.AppSettings["FilePath"];


            DirectoryInfo di = new DirectoryInfo(filePath);

            if (!di.Exists)
            {
                //write Data from the command prompt to the file.
                di.Create();
                Console.WriteLine("Folder created Sucessfully ");
                Console.WriteLine("Please Enter text which you wanted to add into the file");
                String message = Console.ReadLine();

                StreamWriter sr = new StreamWriter(filePath + "/" + "Sample.txt");
                sr.WriteLine(message);
                Console.WriteLine("Message has been entered");

                sr.Close();

            }
            else
            {
                Console.WriteLine("File Exist.Please try again ");



            }
            Console.ReadLine();
        }
    }
}
