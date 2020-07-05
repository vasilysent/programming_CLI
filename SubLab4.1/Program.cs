using System;

namespace SubLab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an array: ");
            string[] numbers = Console.ReadLine().Split();
            var array = new int[numbers.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (!int.TryParse(numbers[i], out array[i]))
                {
                    Console.WriteLine("Entered numbers are invalid");
                    break;
                }
            }
            Console.WriteLine("Maximum element idx = {0}\nProduct = {1}\n[{2}]", ComputeMaxIdx(array), ComputeProduct(array), string.Join(" ", TransformArray(array)));
            Console.ReadLine();
        }
        static int ComputeMaxIdx(int[] array)
        {
            double max = double.NegativeInfinity;
            int maxIdx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    maxIdx = i;
                    max = array[i];
                }
            }
            return maxIdx;
        }
        static int ComputeProduct(int[] array)
        {
            int elementProduct = array[0];
            byte zerosCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) zerosCount++;
                else elementProduct *= array[i];
                if (zerosCount == 2) break;
            }
            if (zerosCount == 2) return elementProduct;
            else Console.WriteLine("Unsuitable conditions to calculate product"); return 0;
        }
        static int[] TransformArray(int[] array) // considering first element with idx [0] as elemrnt with even idx
        {
            int[] transformedArray = new int[array.Length];
            transformedArray[array.Length - 1] = array[array.Length - 1];
            for (int i = 0; i < array.Length / 2 ; i++) 
            {
                transformedArray[i] = array[2 * i + 1];
                transformedArray[i + (array.Length / 2)] = array[2 * i];
            }
            return transformedArray;
        }
    }
}
