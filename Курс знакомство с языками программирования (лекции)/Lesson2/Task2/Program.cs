int N;
Console.WriteLine("Please write the length of array");
int.TryParse(Console.ReadLine(),out N);
int[] arr = new int[N];
int i = 0;
foreach (int item in arr)
{
    i++;
    arr[i - 1] = i;
    Console.Write($"{arr[i - 1]} ");
}

Console.WriteLine($"\n{arr.Length}");
