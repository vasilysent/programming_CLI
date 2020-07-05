using System;
using static System.Math;

namespace SubLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input argument alpha:");
            double alpha;
            if (Double.TryParse(Console.ReadLine(), out alpha))
            {
                var z = 1 - (1/4) * Pow(Math.Sin(2*alpha), 2) + Math.Cos(2 * alpha);
                Console.WriteLine("z({0}) = {1}", alpha, z);
            }
            else Console.WriteLine("The argument value is invalid");
            Console.ReadLine();
        }
    }
}
