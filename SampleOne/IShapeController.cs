using System;
using System.Collections.Generic;

namespace SampleOne
{
	public interface IShapeController
	{
		Dictionary<Type, double> GetShapeAreas();
	}
}