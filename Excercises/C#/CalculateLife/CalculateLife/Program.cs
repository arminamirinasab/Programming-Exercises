// Get Dates
Console.Write("Enter Your Birthday Year (For Example 1984): ");
ushort year = 0; ushort.Parse(Console.ReadLine());
Console.Write("Enter Your Birthday Month (For Example 5): ");
byte month = byte.Parse(Console.ReadLine());
Console.Write("Enter Your Birthday Day (For Example 21): ");
byte day = byte.Parse(Console.ReadLine());
// Check Numbers
if (year >= 0 && month > 0 && day > 0)
{
    // Get Now Time
    DateTime date = DateTime.Now;
    // Calculate Days From Christ Birthday
    decimal worldDays = 0;
    worldDays += date.Year * (decimal)365.25;
    worldDays += (date.Month - 1) * 30;
    worldDays += date.Day;
    // Calculate Days From User Birthday
    decimal Days = 0;
    Days += year * (decimal)365.25;
    Days += month * 30;
    Days += day;
    // Get User Life Days
    int age = (int)(worldDays - Days);
    // Devide To Convert To Year/Month/Days & Minus That ... 
    Console.WriteLine("Year: {0}", age / 365);
    age -= (age / 365) * 365;
    Console.WriteLine("Month: {0}", age / 30);
    age -= (age / 30) * 30;
    Console.WriteLine("Day: {0}", age);
}

Console.ReadKey();