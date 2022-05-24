using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "";
            Console.WriteLine(" enter string");
            str = Console.ReadLine();
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            String str_reverse = new string(array);
            if (str.Equals(str_reverse))
            {
                Console.WriteLine("its a pelindrome string");
            }
            else
            {
                Console.WriteLine("its not pelindrome");

            }
            Console.ReadLine();

             
       
        }
    }
}
