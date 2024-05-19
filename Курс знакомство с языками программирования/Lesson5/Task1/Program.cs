

int Factorial(int num)
{
    int k=num;
    if (num == 0)
    {
        Console.WriteLine($"Раскрутка рекурсии num = {num}");
        return 1;
    }
    num = Factorial(num - 1) * num;
    Console.WriteLine($"Раскрутка рекурсии Factorial = {num} parameter = {k}");
    return num;
}
int result = Factorial(5);
Console.WriteLine(result);
