// Months Array
string[] months = {"January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December"};
// Help
Console.WriteLine("This program receives a number between 1 and 12 and prints the month of that number.");
// Get Value
Console.Write("Enter Number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int monthNumber);
// Minus From Month Number For Convert To Array Index
monthNumber--;
// Nested Single Line Bets For Some Variety & Thought
Console.WriteLine(isNumber ? monthNumber < 12 && monthNumber >= 0 ? months[monthNumber] : "I noticed that your number does not exist among the months of the year" : "I think your input is not a number.");

Console.ReadKey();