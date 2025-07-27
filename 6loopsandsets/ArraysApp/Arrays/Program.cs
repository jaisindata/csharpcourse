
/*
string[] students = new string[5];
string[] students = new string[] {"Jaisrith" , "Yuktha"};

students[0] = "Jaisrith";
*/


string[] students = "Jaisrith,Yuktha".Split(',');

int x = 0;
while (x < students.Length)
{
    Console.WriteLine(students[x]);
    x++;
}

Console.ReadLine();