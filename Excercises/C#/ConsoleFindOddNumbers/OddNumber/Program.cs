// Variables
int count = 5;
int sum = 0;
// Array
int[] numbers = new int[count];
// Get Number From User
for(int i = 0;i < count;i++)
{
    // Get Number
    Console.Write("Enter Number {0}: " , i + 1);
    int userInput = int.Parse(Console.ReadLine());
    // Check ODD Number
    if (userInput % 2 == 0)
    {
        // Push Number To Array
        numbers[i] = userInput;
        // Sum Numbers
        sum += userInput;
    }
}

// Show Sum
Console.WriteLine("\nSum Of Numbers : {0}" , sum);

// Show Result
Console.WriteLine("\nODD Numbers: ");
foreach (int num in numbers)
{
    Console.Write("- {0} " , num);
}

Console.ReadKey();