using System.Collections.Generic;
using System.Text;
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

		public string GetShapeAreas()
		{
			var shapes = new List<Shape>
			{
				generator.GetShape(typeof(Circle)),
				generator.GetShape(typeof(Square)),
				generator.GetShape(typeof(Rectangle))
			};

			var sb = new StringBuilder();
			foreach (var shape in shapes)
			{
				sb.AppendLine($"area of {shape.GetType().Name} is {shape.CalculateArea()}");
			}

			return sb.ToString();
		}
	}
}
