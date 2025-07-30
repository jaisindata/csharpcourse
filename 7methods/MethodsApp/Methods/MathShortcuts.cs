using System;
namespace Methods
{
	public static class MathShortcuts
	{
		public static double AddNumbers(List<double> inputNumbers)
		{
			double total = 0;
			foreach (double number in inputNumbers)
			{
				total += number;
			}

			return total;
		}
	}
}

