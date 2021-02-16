using System;
using System.IO;
using System.Linq;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        { 
            string filesize = @"C:\Users\User\Desktop\lendet.txt";
            Console.WriteLine("Calculating size of file");
            FileInfo info = new FileInfo(filesize);
            long length = info.Length;
            Console.WriteLine("Length in Bytes {0} ", length);
            //End of the program
        }
    }
}
