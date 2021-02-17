using System;
using System.Linq;

namespace Cartesian
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Cartesian Product of three set");
            char[] letterset = { 'A', 'B', 'C' };
            int[] gradeset = { 100, 90, 70 };
            string[] studentset = { "Beni", "Mira","Denis" };

             var function = from gradeletter in letterset from gradenumber in gradeset from student in studentset select new { gradeletter, gradenumber, student };
             foreach (var list in function)
            {
                Console.WriteLine(list);
            }
            Console.ReadLine();

        }
    }
}
