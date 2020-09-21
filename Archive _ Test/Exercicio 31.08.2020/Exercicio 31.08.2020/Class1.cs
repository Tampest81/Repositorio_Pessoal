using System;

namespace Program
{

	public class Class1
	{
		public float A;
		public float B;
		public float C;

		public float Valor()
        {
			float p = (A + B + C) / 2;
			float value = (p * (p - A) * (p - B) * (p - C));
			return value;
		}
	}
}
