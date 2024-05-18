

void PrintSquares(int limit)
{
    Console.WriteLine($"Squares of numbers until {limit}: ");
    for (int i = 1; i <= limit; i++)
    {
        Console.WriteLine($"{i} * {i} = {i * i}");
    }
}

PrintSquares(12);