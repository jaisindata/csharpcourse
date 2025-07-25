

using System.Globalization;

DateTime todayNow = DateTime.Now;
DateTime todayUtcNow = DateTime.UtcNow;

DateTime birthday = DateTime.Parse("10/20/2018");
DateTime birthdayExact = DateTime.ParseExact("20/10/2018","d/MM/yyyy",CultureInfo.InvariantCulture);

Console.WriteLine(birthday);
Console.WriteLine(birthdayExact);
Console.WriteLine(todayNow.ToString("MMMM dd, yyyy hh:mm zzz"));
Console.WriteLine(todayUtcNow.ToString("MMMM dd, yyyy hh:mm zzz"));

Console.ReadLine();