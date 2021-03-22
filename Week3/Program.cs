using System;
using System.IO;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean check = false;
            do
            {
                try
                {
                    string path = @"C:\Users\User\source\repos\FileArray\Text\test.txt";
                    string[] arr;
                    int lines;

                    Console.WriteLine("File u krijuar");
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    Console.WriteLine("Sa rrjeshta string do qe te shkruhen ne file");
                    lines = Convert.ToInt32(Console.ReadLine());
                    arr = new string[lines];
                    Console.WriteLine("Shkruaj {0} strings: ", lines);
                    for (int i = 0; i < lines; i++)
                    {
                        Console.WriteLine("Vendos rrjeshtin e {0} :", i + 1);
                        arr[i] = Console.ReadLine();
                        check = false;
                    }

                    System.IO.File.WriteAllLines(path, arr);
                }
                catch (System.Exception ex)
                {
                    check = true;
                    Console.WriteLine("Wrong Input {0} ", ex.Message);
                }
            }
            while (check == true);
        }
    }
}

