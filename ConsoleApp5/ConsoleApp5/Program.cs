using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice");
            Console.WriteLine(" enter 1 for addition");
            Console.WriteLine(" enter 2 for substraction");
            Console.WriteLine("enter 3 for multipication");
            Console.WriteLine("enter 4 for division");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first input");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second input");
            int second = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case 1:
                    {
                        result = first + second;
                        Console.WriteLine("addtion:" + result);
                        break;

                    }
                case 2:
                    {
                        result = first - second;
                        Console.WriteLine("sub:" + result);
                        break;

                    }
                case 3:
                    {
                        result = first * second;
                        Console.WriteLine("multiplication:" + result);
                        break;
                    }
                case 4:
                    {
                    result: result = first / second;
                        Console.WriteLine("division:" + result);
                        break;

                    }









            }
        }
    }
}


    
