var entry = Console.ReadLine();

const double radian = Math.PI / 180.00;

if (double.TryParse(entry, out var value) && value is >= 0 and <= 360)
{
    Console.WriteLine(value * radian);
}
else
{
    Console.WriteLine(-1);
}