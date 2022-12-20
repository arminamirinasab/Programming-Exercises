// Variable
int count = 5;
// Star Loop
for (int i = 0; i < count; i++)
{
    // Internal Loop
	for (int x = 0; x <= i; x++)
	{
        Console.Write("*");
    }
    // Space
    Console.WriteLine("");
}
// Numbers Loop
for (int i = 0; i < count; i++)
{
    // Internal Loop
    for (int x = 0; x <= i; x++)
    {
        // Add 1 For Loop Parity
        Console.Write(x + 1);
    }
    // Space
    Console.WriteLine("");
}

Console.ReadKey();