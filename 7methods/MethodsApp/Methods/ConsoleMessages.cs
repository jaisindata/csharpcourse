using System;
namespace Methods
{
	public static class ConsoleMessages
	{
		public static void SayHi()
		{
			Console.WriteLine("Hello, how are you?");
		}

		public static void SayBye()
		{
			Console.WriteLine("See you, thanks for using the app.");
		}

		public static void GreetUser(string userName)
		{
			Console.WriteLine($"Hello {userName}");
		}

		public static (string firstName, string lastName) GetFullName()
		{
			Console.WriteLine("What is your first name?");
			string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            return (firstName, lastName);

        }

    }
}

