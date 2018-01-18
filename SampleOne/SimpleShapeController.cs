using System;
using System.Collections.Generic;
using SampleOne.Shapes;

namespace SampleOne
{
	public class SimpleShapeController : IShapeController
	{
		private readonly IShapeGenerator generator;

		public SimpleShapeController(IShapeGenerator generator)
		{
			this.generator = generator;
		}

		public Dictionary<Type, double> GetShapeAreas()
		{
			return new Dictionary<Type, double>
			{
				{typeof(Circle), generator.GetShape(typeof(Circle)).CalculateArea()},
				{typeof(Square), generator.GetShape(typeof(Square)).CalculateArea()},
				{typeof(Rectangle), generator.GetShape(typeof(Rectangle)).CalculateArea()}
			};
		}
	}
}
