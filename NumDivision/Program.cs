using System;

namespace NumDivision
{
    class Program
    {
       
        static void Main(string[] args)
            {
            Boolean check = false;
            int number1 = 0;
            int number2 = 0;
            int result = 0;

            do
            {
                try
                {
                    Console.WriteLine("Enter 2 numbers to be divided *A NUMBER CAN NOT BE DIVIDED BY ZERO*");
                    Console.WriteLine("Enter first number: ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    result = number1 / number2;
                    Console.WriteLine("Result: " + result);
                    check = false;
                }
                catch (System.Exception e)
                {
                    check = true;
                    Console.WriteLine(" ");
                    Console.WriteLine("Nuk lejohet nr te pjestohet me zero ose karaktere");
                    Console.WriteLine(" ");
                }
            } while (check == true);
            }
        
    }
}
