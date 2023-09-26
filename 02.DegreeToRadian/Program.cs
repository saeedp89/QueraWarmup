var entry = Console.ReadLine();

if (double.TryParse(entry, out var value) && value is >= 0 and <= 360)
{
    Console.WriteLine(value * (Math.PI / 180.00));
}
