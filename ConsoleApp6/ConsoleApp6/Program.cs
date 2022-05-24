using System;

namespace ConsoleApp6
{
    class Demo    {
        static void Main(string[] args)
        {
            int line = 9;
            int star = 9;
            for (int r = 1; r <= line; r++)
            {
                for (int c = 1; c <= star; c++)
                {
                    if (r == 1 || r == line || c == 1 || c == star || r == c || c == line - r + 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }
        }

    }
}

