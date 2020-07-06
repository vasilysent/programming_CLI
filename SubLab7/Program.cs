using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational num1 = new Rational(3, 5);
            Rational num2 = new Rational(7, 8);

			Console.WriteLine(num1.numerator + "/" + num1.determinator + " ~ " + num1.Aprox());
			Rational sum = num1.Add(num2);
			Console.WriteLine(num1.numerator + "/" + num1.determinator + " + " + num2.numerator + "/" + num2.determinator + " = " + sum.numerator + "/" + sum.determinator);
			//Rational diff = num1.Subtract(num2);
			//Console.WriteLine(num1.numerator + "/" + num1.determinator + " - " + num2.numerator + "/" + num2.determinator + " = " + diff.numerator + "/" + diff.determinator);
			Rational product = num1.Muliply(num2);
			Console.WriteLine(num1.numerator + "/" + num1.determinator + " * " + num2.numerator + "/" + num2.determinator + " = " + product.numerator + "/" + product.determinator);
			Rational quotient = num1.Divide(num2);
			Console.WriteLine(num1.numerator + "/" + num1.determinator + " / " + num2.numerator + "/" + num2.determinator + " = " + quotient.numerator + "/" + quotient.determinator);

			Console.ReadLine();
        }
    }
	public class Rational
	{
		public int numerator;
		public int determinator;

		public Rational(int numerator, int determinator)
		{
			if (determinator != 0)
			{
				this.numerator = numerator;
				this.determinator = determinator;
			}
			else throw new Exception("Determinator could not be equal to zero!");
		}
		public Rational Add(Rational num)
		{
			int sumDet, sumNum;
			sumDet = this.determinator * num.determinator;
			sumNum = this.numerator * num.determinator + num.numerator * this.determinator;
			sumNum /= CommonDiv(sumNum, sumDet);
			sumDet /= CommonDiv(sumNum, sumDet);
			Rational sum = new Rational(sumNum, sumDet);
			return sum;
		}
		public Rational Subtract(Rational num)
		{
			Rational minusOne = new Rational(-1, 1);
			return this.Add(num.Muliply(minusOne));
		}
		public Rational Muliply(Rational num)
		{
			int sumDet, sumNum;
			sumDet = this.determinator * num.determinator;
			sumNum = this.numerator * num.numerator;
			sumNum /= CommonDiv(sumNum, sumDet);
			sumDet /= CommonDiv(sumNum, sumDet);
			Rational product = new Rational(sumNum, sumDet);
			return product;
		}
		public Rational Divide(Rational num)
		{
			if (num.numerator != 0 )
				{
				int sumDet, sumNum;
				sumDet = this.determinator * num.numerator;
				sumNum = this.numerator * num.determinator;
				sumNum /= CommonDiv(sumNum, sumDet);
				sumDet /= CommonDiv(sumNum, sumDet);
				Rational product = new Rational(sumNum, sumDet);
				return product;
			}
			else throw new Exception("You could not divide by zero!");
		}
		public double Aprox ()
		{
			return (double)this.numerator / (double)this.determinator;
		}
		static int CommonDiv(int num1, int num2)
		{
			if (num1 != 0 && num2 != 0)
			{
				while (num1 != num2)
				{
					if (num1 < num2) num2 -= num1;
					else num1 -= num2;
				}
				return num1;
			}
			else return 0;
		}
	}
}
