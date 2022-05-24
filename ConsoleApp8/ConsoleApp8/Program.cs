using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
         
                int line = 5;
                int star = 5;
                for (int r = 1; r <= line; r++)
                {
                    for (int c = 1; c <= star; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    star--;
                }

                int l1 = 5;
                int s1 = 1;
                for (int r = 1; r <= l1; r++)
                {

                    for (int c = 1; c <= s1; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    s1++;
                }
            
        }
    }
}
