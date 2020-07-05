using System;
using static System.Math;


namespace SubLab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input argument:");
            double x;
            if (Double.TryParse(Console.ReadLine(), out x))
            {
                if (x < -7 || x > 11)
                {
                    Console.WriteLine("The function is not specified for a given argument");
                }
                else
                {
                    double y = 0;
                    if (x <= -3)
                    {
                        y = 3;
                    }
                    else if (x <= 3)
                    {
                        y = - Math.Sqrt(Pow(3, 2) - Pow(x, 2)) + 3;
                    }
                    else if (x <= 6)
                    {
                        y = -2 * x + 9;
                    }
                    else if (x <= 11)
                    {
                        y = x - 9;
                    }
                    Console.WriteLine("f(x) = " + y.ToString());
                }


            }
            else
            {
                Console.WriteLine("The argument value is invalid");
            }
            Console.ReadLine();
        }
    }
}
