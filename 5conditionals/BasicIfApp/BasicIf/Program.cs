
/*
bool isComplete = true;

if (isComplete)
{
    Console.WriteLine("It is complete");
}

else
{
    Console.WriteLine("Is not complete");
}
*/

Console.WriteLine("What is your name? ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "jaisrith")
{
    Console.WriteLine("Hello Tella");
}

else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.ReadLine();