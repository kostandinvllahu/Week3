using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number to the N");
            int num = 0;
            Console.WriteLine("Vendos nr e N");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i<num; i++)
            {
                bool isPrime = true;
               for(int j=2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
