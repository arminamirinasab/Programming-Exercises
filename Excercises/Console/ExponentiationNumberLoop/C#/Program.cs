
using System;

namespace ExponentiationNumberLoop
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Welcome Message
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\n  Enter 2 Numbers & The Program Will Power It :)\n");
			// Error Range
			int errorRange = 10;
			while(true) {
				// Avoid Crash
				if(errorRange <= 0) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("\n  YOU ARE NOT AUTHORIZED TO USE THIS PROGRAM X_X");
					break;
				}
				// Get Value
				Console.ForegroundColor = ConsoleColor.White;
				int numberOne;
				Console.Write("  Enter Original Number: ");
				bool numberOneCheck = int.TryParse(Console.ReadLine() , out numberOne);
				
				int numberTwo;
				Console.Write("  Enter Power Number: ");
				bool numberTwoCheck = int.TryParse(Console.ReadLine() , out numberTwo);
				// Data Validation
				if(numberOneCheck && numberTwoCheck) {
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("  Result: " + Math.Pow(numberOne , numberTwo));
				} else {
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.Beep(350 , 500);
					Console.WriteLine("  Error In Entering Number :/");
					errorRange--;
				}
			}
			Console.ReadKey();
		}
	}
}