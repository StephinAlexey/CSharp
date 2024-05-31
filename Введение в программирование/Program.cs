
int[] numbers = { 2, 5, 13, 7, 6, 4 };
int size = 6; //numbers.Length;
double sum = 0;
double avg = 0;
for (int index = 0; index < size; index++)
{
    sum += numbers[index];
};
avg = sum / size;
Console.WriteLine($"The array's elements avg= {avg}");