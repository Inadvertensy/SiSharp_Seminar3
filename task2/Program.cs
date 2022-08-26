// Задача 18: Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!");

            ViewQuarterNumber();
            ViewXYMaxNumber();
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
        static void ViewXYMaxNumber()
        {
            Console.WriteLine("Please enter quarter number");
            int QN= int.Parse(Console.ReadLine());
            if(QN==1){
                Console.WriteLine("X>0, Y>0");
            }
            else if (QN==2){
                Console.WriteLine("X<0, Y>0");
            }
            else if (QN==3){
                Console.WriteLine("X<0, Y<0");
            }
            else if (QN==4){
                Console.WriteLine("X<0, Y<0");
            }
            else {
                Console.WriteLine("Not correct quarter number");
            }
        }


    }

}
