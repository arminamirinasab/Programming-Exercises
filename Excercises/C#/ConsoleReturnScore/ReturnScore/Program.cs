// Variables
int count = 20;
double sum = 0;
// Loop
for (int i = 1; i <= count; i++)
{
    // Get Value
    Console.Write("Enter Score {0}: " , i);
    int userScore = int.Parse(Console.ReadLine());
    // Sum Numbers
    sum += userScore;
}
// Calculate Average & Show Result
Console.WriteLine("\n Average Of Scroes: {0}" , sum / count);

Console.ReadKey();