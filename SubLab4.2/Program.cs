using System;

namespace SubLab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = InputMatrix();
            RowColumnSymmentyInx(matrix);
            Console.WriteLine("Sum of elements of rows having at least one negative elements: {0}", SumNegRows(matrix));
            Console.ReadLine();
        }
        static int[,] InputMatrix()
        {
            Console.WriteLine("Input n*n matrix: ");

            string[] firstRow = Console.ReadLine().Split(); // taking dimention n from the first row length
            var matrix = new int[firstRow.Length, firstRow.Length];
            for (int i = 0; i < firstRow.Length; i++)
            {
                if (!int.TryParse(firstRow[i], out matrix[0, i]))
                {
                    Console.WriteLine("Entered numbers are invalid");
                    break;
                }
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                string[] newRow = Console.ReadLine().Split();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (!int.TryParse(newRow[i], out matrix[i, j]))
                    {
                        Console.WriteLine("Entered numbers are invalid");
                        break;
                    }
                }
            }
            return matrix;
        }
        static void RowColumnSymmentyInx(int[ , ] matrix)
        {
            bool noSuchRows = true;
            Console.Write("Indecies of rows having the same elements as column with the same index: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool flag = true;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        flag = false; 
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write(i); 
                    noSuchRows = false;
                }
            }
            if (noSuchRows) Console.WriteLine("There are no such rows");
            else Console.WriteLine();
        }

        static int SumNegRows(int[,] matrix)
        {
            int sum = 0, rowSum;
            bool noNegative = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool flag = false;
                rowSum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    rowSum += matrix[i, j];
                    if (matrix[i, j] < 0)
                    {
                        flag = true; 
                        noNegative = false;
                    }
                }
                if (flag) sum += rowSum;
            }
            if (noNegative) Console.WriteLine("There are no negative elements"); 
            return sum;
        }
    }
}
