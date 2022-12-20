// Higher Order Loop
for (int z = 1; z <= 10; z++)
{
    // Loop Per Row
    for (int i = 1; i <= 10; i++)
    {
        // Print Numbers
        Console.Write("\t{0}", i * z);
    }
    // Horzintal Line
    Console.WriteLine("\n -----------------------------------------------------------------------------------------");
}

Console.ReadKey();