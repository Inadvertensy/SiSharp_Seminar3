// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта 
// точка.
using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!");

            ViewQuarterNumber();
        }
        static void ViewQuarterNumber()
        {
            Console.WriteLine("Please insert X");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert Y");
            int Y = int.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("1st quarter");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("2nd quarter");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("3rd quarter");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("4d quarter");
            }
        }
    }

}
