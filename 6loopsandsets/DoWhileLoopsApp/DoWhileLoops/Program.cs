

bool isValidAge = false;
int age = 0;

do
{
    Console.WriteLine("What is your age? ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);
    if (!isValidAge)
    {
        Console.WriteLine("Please input a valid age.");
    }
} while (!isValidAge);

Console.WriteLine($"Your age is {age}");

int myNumber = 0;
while (myNumber < 10)
{
    Console.WriteLine(myNumber);
    myNumber += 3;
}

Console.ReadLine();

