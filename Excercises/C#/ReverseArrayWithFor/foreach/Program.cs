// Array
string[] students = { "Armin", "Sedna", "Mahdi", "Abolfazl", "Fateme", "Mona" };
// New Empty Array To Assign
string[] newStudents = new string[students.Length];
// Reverse Array With For
for (int i = students.Length - 1, sort = 0; i >= 0; i--)
{
    newStudents[sort] = students[i];
    sort++;
}
// Show Students
foreach (var student in newStudents)
{
    Console.WriteLine(student);
}

Console.ReadKey();