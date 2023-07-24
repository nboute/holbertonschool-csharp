using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("{0}\n{1}", percent.ToString("P"), currency.ToString("C", new CultureInfo("en-US")));
	}
}
