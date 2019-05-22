using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 62. Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            double circleRadius, squareSide;

            Console.Write("Введите радиус круга: ");
            circleRadius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            squareSide = Convert.ToDouble(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(circleRadius, 2);
            double squareArea = Math.Pow(squareSide, 2);

            Console.WriteLine("Площадь круга: " + circleArea);
            Console.WriteLine("Площадь квадрата: " + squareArea);

            if (circleArea == squareArea)
                Console.WriteLine("Площади равны!");
            else
                Console.WriteLine("Площадь " + ((circleArea > squareArea) ? "круга" : "квадрата") + " больше!");

            Console.ReadLine();
        }
    }
}
