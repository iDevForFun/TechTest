namespace SampleOne
{
	public abstract class Shape
	{
		public int WidthCm { get; set; }
		public int HeightCm { get; set; }

		public double CalculateArea()
		{
			return WidthCm * HeightCm;
		}
	}
}
