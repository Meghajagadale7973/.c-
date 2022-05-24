using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 11, 15, 15, 71, 99, 6, 85, 45 };
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("second highest value in array" + array[1]);

        }
    }
}
