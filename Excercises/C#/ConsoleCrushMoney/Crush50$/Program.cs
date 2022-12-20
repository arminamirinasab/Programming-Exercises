// Help
Console.WriteLine("This program is an ATM that calculates your requested amount using $5 and $2 bills and tells you the different modes of receiving money. \n");
// Get Number
Console.Write("Enter Your Requested Amount: ");
int requestedAmount = int.Parse(Console.ReadLine());

// 5$ Loop
for (int f = 0; f <= (requestedAmount / 5) ; f++)
{
	// 2$ Loop
	for (int t = 0; t <= (requestedAmount / 2); t++)
	{
		// Check Amount
		if(f * 5 + t * 2 == requestedAmount)
		{
			Console.WriteLine("$5: {0}\n$2: {1} \n", f, t);
		}
	}
}

Console.ReadKey();