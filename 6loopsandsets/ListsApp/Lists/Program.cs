
/*
List<string> students = new List<string>();

students.Add("Jaisrith");
students.Add("Yuktha");

Console.WriteLine(students[students.Count - 1]);
*/

List<string> students = "Jaisrith,Yuktha".Split(',').ToList();
Console.WriteLine(students[1]);
Console.ReadLine();