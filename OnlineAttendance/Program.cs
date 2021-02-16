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

            if (name == "Jack" || name == "Steven" || name == "Mathew")
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
