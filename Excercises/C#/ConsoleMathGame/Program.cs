using System;

namespace Math_Game
{
	class Program
	{
		public static void Main(string[] args)
		{
		// Welcome Text
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("\n Welcome to My Math Game :)");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(" To Win You Must Be Able To Reach 20 Points And If Your Score Reaches 0, You Lose.\n");
		// Start Game
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write(" Start ->");Console.ReadKey();Console.Beep(500 , 100);Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.Yellow;
		
		// Game Operations
		int score = 10;
		Random randomNumber = new Random();
		while (true) {
			// Check Win or Loss
			if (score == 0) {
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.DarkRed;
				Console.Beep(500,350);
				Console.Beep(400,250);
				Console.Beep(350,700);
				Console.Write(" I'm Sorry You Lost, You Need More Practice in Math X__X");
				break;
			} else {
			}
			if (score == 20) {
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.White;
				Console.BackgroundColor = ConsoleColor.Magenta;
				Console.Beep(600,350);
				Console.Beep(650,250);
				Console.Beep(800,600);
				Console.Write(" Congratulations , You Won , You Are Really Clever Person (＠＾０＾)");
				break;
			} else {
			// Generate Two Random Number
			int randomNumber1 = randomNumber.Next(0 , 100);
			int randomNumber2 = randomNumber.Next(0 , 100);
			// Get Answer From User
			Console.Write(" " + randomNumber1 + " + " + randomNumber2 + " = ");
			int answer = 0;
			bool isNumber = int.TryParse(Console.ReadLine() , out answer);
			// Data Type Check
			if(!isNumber) {
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine(" Error In Enter Number :(");
				Console.Beep(350 ,400);
				Console.Beep(333 , 300);
				// Subtract from Scores (When the user enters the string and to avoid crashing)
				score--;
				if (score != 0) {
				Console.WriteLine(" Score: {0}\n {0} More Wrong Questions Until The Deadline" , score);
				}
				Console.ForegroundColor = ConsoleColor.Yellow;
			} else {
				// Checking the Correctness of The Answer
				if(answer == randomNumber1 + randomNumber2) {
				// Add To Scores
				score++;
				Console.ForegroundColor = ConsoleColor.Cyan;
				// Show Scores
				Console.WriteLine(" Score: {0}\n {1} More Questions to Victory" , score , 20 - score);
				Console.Beep(700 , 200);
				Console.ForegroundColor = ConsoleColor.Yellow;
			} else {
				// Subtract from Scores
				score--;
				Console.ForegroundColor = ConsoleColor.Red;
				// Show Scores
				if (score != 0) {
					Console.WriteLine(" Score: {0}\n {0} More Wrong Questions Until The Deadline" , score);
					Console.Beep(350 , 400);
				}
				Console.ForegroundColor = ConsoleColor.Yellow;
			}
			}
		}
		}
		Console.ReadKey();
		}
	}
}