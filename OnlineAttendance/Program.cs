using System;

namespace OnlineAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Online Attendance Program");
            string name;
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            if (name.ToUpper() == "Jack".ToUpper() || name.ToUpper() == "Steven".ToUpper() || name.ToUpper() == "Mathew".ToUpper())
            {
                Console.WriteLine("User is baned");
                Console.WriteLine("Sending email to administrator");
                Console.WriteLine("Fire alarm started");
                for (; ;) //infinit loop
                {
                    Console.Beep();
                    System.Threading.Thread.Sleep(100);
                }
            }
            else
            {
                Console.WriteLine("WELCOME " + name);
            }

        }
    }
}
