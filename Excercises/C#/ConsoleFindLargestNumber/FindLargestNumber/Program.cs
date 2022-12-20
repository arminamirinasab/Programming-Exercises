// Loop Variable
int i = 0;
// Largest Number
int lastNumber = 0;
// Help
Console.WriteLine("Enter 0 To Show Result :)");
while (true)
{
    i++;
    // Get Value
    Console.Write("Enter Number {0}: ", i);
    int userNumber = int.Parse(Console.ReadLine());
    // Break For 0
    if (userNumber == 0)
    {
        break;
    }
    // Check & Replace Larger Number
    if(userNumber > lastNumber)
    {
        lastNumber = userNumber;
    }
}
// Show Result
Console.WriteLine("\n Largest Number: {0}", lastNumber);

Console.ReadKey();