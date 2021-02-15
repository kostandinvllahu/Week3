using System;

namespace NumDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pjestim dy nr");
            Console.WriteLine("=====RREGULLAT=====\n" +
                "1. Nje nr nuk mund te pjestohet me zero");
            Console.WriteLine("Vendos dy numra per tu pjestuar: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int total = num1 / num2;
                Console.WriteLine(total);
            }

            catch (System.DivideByZeroException e){
                Console.WriteLine(String.Concat(e.Message, e.StackTrace));
                Console.WriteLine("Nuk lejohet nr te pjestohet me zero");
            }
        }
    }
}
