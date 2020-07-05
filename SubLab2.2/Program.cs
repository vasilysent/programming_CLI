using System;
using static System.Math;


namespace SubLab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var R = 1; // Radius of the circle (R > 0)
            Console.WriteLine("Input coordinates: x then y): ");
            double x;
            double y;
            if (Double.TryParse(Console.ReadLine(), out x) && Double.TryParse(Console.ReadLine(), out y))
            {
                if (Math.Sqrt(Pow(x, 2) + Pow(y, 2)) <= R && !(x > 0 && y < 0) && y <= (x + R))
                {
                    Console.WriteLine("The point is inside of the area");
                }
                else Console.WriteLine("The point is outside of the area");               
            }
            else Console.WriteLine("The argument value is invalid");

            Console.ReadLine();
        }
    }
}
