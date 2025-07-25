

Console.Write("What is your age? ");
string? ageText = Console.ReadLine();
//Console.WriteLine(ageText + 15);

//int age = int.Parse(ageText);

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"It is validage: {isValidInt} and the age is {age}");
Console.WriteLine(age + 15);

double ageDouble = age;
decimal ageDecimal = (decimal)ageDouble;

Console.ReadLine();