using Methods;

ConsoleMessages.SayHi();
ConsoleMessages.SayBye();

ConsoleMessages.GreetUser("Jaisrith");

List<double> inputNumbers = new List<double>();
inputNumbers.Add(23);
inputNumbers.Add(24);
inputNumbers.Add(25);
Console.WriteLine(MathShortcuts.AddNumbers(inputNumbers));


(string firstName, string lastName) = ConsoleMessages.GetFullName();
Console.WriteLine($"Hi {firstName} {lastName}");
Console.ReadLine();

