

List<string> students = new();

students = "Jaisrith,Yuktha".Split(',').ToList();

foreach (string student in students)
{
    Console.WriteLine($"Hi {student}");
}

Console.ReadLine();