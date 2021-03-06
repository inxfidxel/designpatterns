﻿namespace design_patterns
{
	public class Triangle : Shape
	{
		public override string type { get; set; }
		public override int sides { get; set; }
		public override string area { get; set; }

		public Triangle()
		{
			this.type = "Triangle";
			this.sides = 3;
			this.area = "(1/2) * b * h";
		}
	}
}