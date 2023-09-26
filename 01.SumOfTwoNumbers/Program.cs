Solution();

void Solution()
{
    var entry = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entry))
        // throw new Exception("no valid input");
    {
        Console.WriteLine(0);
        return;
    }
    var numbers = entry.Trim().Split();

    if (numbers.Length != 2)
    {
        Console.WriteLine(0);
        // throw new Exception("should Input 2 numbers");
        return;
    }
    var validRange = new Range(1, 100);

    if (!IsValid(numbers[0], validRange))
    {
        // throw new Exception($"{numbers[0]} is not number or it is not between [1,100]");
        Console.WriteLine(0);
        return;
    }

    if (!IsValid(numbers[1], validRange))
    {
        // throw new Exception($"{numbers[1]} is not number or it is not between [1,100]");
        Console.WriteLine(0);
        return;
    }


    Console.WriteLine(Convert.ToByte(numbers[0]) + Convert.ToByte(numbers[1]));
}

bool IsValid(string input, Range validRange)
{
    return byte.TryParse(input, out var val) && val >= validRange.Start.Value && val <= validRange.End.Value;
}