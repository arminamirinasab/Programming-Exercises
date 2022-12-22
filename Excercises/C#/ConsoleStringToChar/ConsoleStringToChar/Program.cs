// Get String
Console.Write("Enter Your String: ");
string userString = Console.ReadLine();

// Loop
foreach (var c in userString)
{
    // Convert To Char & Print
    char charachter = c;
    Console.WriteLine(charachter);
}

Console.ReadKey();