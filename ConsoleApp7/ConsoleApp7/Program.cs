using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = 5;
            int star = 1;
            for (int r = 1; r <= line; r++)
            {
                for (int c = 1; c <= star; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                star++;
            }
            }
    }
}
