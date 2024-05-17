//Find max element in array
int Arrlength = 0;

Console.WriteLine("Please insert the array length");
int.TryParse(Console.ReadLine(), out Arrlength);
int[] arr = new int[Arrlength];
Console.WriteLine("Please insert array's elements");
for (int i = 0; i < Arrlength; i++)
{
    int.TryParse(Console.ReadLine(), out arr[i]);
}
int MaxElem = arr[0];
foreach (int item in arr)
{
    if (item > MaxElem)
        MaxElem = item;
}
Console.WriteLine($"The max element is {MaxElem}");
