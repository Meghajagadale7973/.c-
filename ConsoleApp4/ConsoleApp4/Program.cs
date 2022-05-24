using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("not eligible to vote");

            }
            else if (a <= 60)
            {
                Console.WriteLine("able to vote a");

            }
            else
            {
                Console.WriteLine("Siniour citizen");
            }
        }
    }
}
