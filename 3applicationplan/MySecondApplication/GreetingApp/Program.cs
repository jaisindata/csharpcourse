namespace GreetingApp;
class Program
{
    static void Main(string[] args)
    {
        //Welcome user to app
        Console.WriteLine("Welcome to the greeting app");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        //Ask user for name
        Console.Write("What is your name?");
        string firstName;
        firstName = Console.ReadLine();

        //Greet user by name and end the application with greeting
        Console.WriteLine($"Hello {firstName}");
        Console.WriteLine("Thanks for using the app!");
        Console.ReadLine();
    }
}

