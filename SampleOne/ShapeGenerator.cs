using System;

namespace SampleOne
{
	public class ShapeGenerator : IShapeGenerator
	{
		public Shape GetShape(Type t)
		{
			if (t  == typeof(Circle))
			{
				return new Circle(5);
			}

			if (t == typeof(Square))
			{
				return new Square(4);
			}

			throw new NotSupportedException();
		}
	}
}
