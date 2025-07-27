

DateTime today = DateTime.UtcNow;

Console.WriteLine(today.ToString("hh::mm"));

string greet = today.ToString("HH");

Console.WriteLine(greet);
switch (int.Parse(greet))
{
    case 0 or < 6 :
            Console.WriteLine("Midnight");
        break;
    case 6 or <=12 :
        Console.WriteLine("Morning");
        break;
    case 12 or <= 17:
        Console.WriteLine("Afternoon");
        break;
    case 18 or <= 24:
        Console.WriteLine("Evening");
        break;
}
Console.ReadLine();