// Arrays
string[] students = new string[50];
double[] scores = new double[50];
// Get Student Loop
for (int i = 0;i < students.Length; i++)
{
    // Get Value
    Console.Write("Please Enter Studnet Name: ");
    string student = Console.ReadLine();
    Console.Write("Please Enter Studnet Score: ");
    int score = int.Parse(Console.ReadLine());
    Console.WriteLine();
    // Check 0 & Break
    if(score == 0 || student == "0")
    {
        break;
    }
    // Assign Values
    students[i] = student;
    scores[i] = score;
}

// Show Students & Filter
for (int i = 0; i < students.Length; i++)
{
    // Condition
    if (scores[i] <= 10 && scores[i] != 0)
    {
        Console.Write("Student: {0} ; Score: {1} \n", students[i], scores[i]);
    }
}

Console.ReadKey();