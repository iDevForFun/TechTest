using System;

namespace SampleOne
{
	public class Circle : Shape
	{
		public Circle(int radius)
		{
			WidthCm = radius;
		}

		public override double CalculateArea()
		{
			return WidthCm * Math.Pow(Math.PI, 2);
		}
	}
}
