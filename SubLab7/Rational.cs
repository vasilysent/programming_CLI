using System;

namespace SubLab7
{ 
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
		static int CommonDiv (int num1, int num2)
        {
			while (num1 != num2)
            {
				if (num1 < num2) num2 -= num1;
				else num1 -= num2;
            }
			return num1;
		}
		//static int ReduceFrac(Rational num)
		//{
		//	int remainder = num.numerator, quotient = 0;
		//	while (remainder >= num.determinator)
		//	{
		//		remainder = remainder - num.determinator;
		//		quotient++;
		//	}
		//	return (quotient);
		//}
	}
}