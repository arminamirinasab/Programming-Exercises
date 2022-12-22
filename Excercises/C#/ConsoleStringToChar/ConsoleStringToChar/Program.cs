// Get String
Console.Write("Enter Your String: ");
string userString = Console.ReadLine();
// Loop
for (int i = 0; i < userString.Length; i++)
{
    // Convert To Char & Print
    char c = userString[i];
    Console.WriteLine(c);
}

Console.ReadKey();