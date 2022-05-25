using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string [] args)
        {
            int i, fact = 1;
            Console.WriteLine("enter number");
             int number= Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("FACTORIAL OF " + number + "is:" + fact);

        }
    }
}
