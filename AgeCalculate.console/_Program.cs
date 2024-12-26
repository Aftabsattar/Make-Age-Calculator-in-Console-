
    Console.WriteLine("+------------------+");
    Console.WriteLine("| Total Days: 7894 |");
    Console.WriteLine("| Total month: 94 |");
    Console.WriteLine("| Total hour: 9846541 |");
    Console.WriteLine("| Total year: 12 |");
    Console.WriteLine("| Year(round figure): 27 |");
    Console.WriteLine("+------------------+");
ConsoleKeyInfo userChoice;
List<string> list = new List<string>();
do
{
    AgeCalculater();
    Console.Write("Do you want calculate again(Y/N):");
    userChoice = Console.ReadKey();
    Console.WriteLine();
} while (userChoice.Key == ConsoleKey.Y);
void AgeCalculater()
{
    DateTime Currnt = DateTime.Now;
    Console.WriteLine("Please Enter Your Date of Birth");
    var dob = Console.ReadLine();
    list.Add(dob);
    DateTime dob1 = Convert.ToDateTime(dob);
    Console.WriteLine("+---------------------------+");
    Console.WriteLine($"|your total hour is:{(Currnt - dob1).TotalHours:F0} |");
    Console.WriteLine($"|your total days is:{(Currnt - dob1).TotalDays:F0}   |");
    Console.WriteLine($"|your total month is:{(Currnt - dob1).TotalDays / 30:F0}   |");
    Console.WriteLine($"|your total year is:   {(Currnt - dob1).TotalDays / 365:F0}|");
    Console.WriteLine("+---------------------------+");
}
Console.WriteLine("+--------------+");
foreach (var item in list)
{
    Console.WriteLine($"List of Age: { item}");
}








