

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}



List<string> students = "Jaisrith,Yuktha".Split(',').ToList();

for (int i = 0; i < students.Count; i++)
{
    Console.WriteLine(students[i]);
}

Console.ReadLine();