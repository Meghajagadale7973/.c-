using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3: 
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thurday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;

                default:
                    Console.WriteLine("invalid chioce");
                    break;

                       















            }
        }
        }
    }

