
void ZeroEvenElementsOfArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i += 2)
    {
        arr[i] = 0;
    }
}
int[] arr = { 23, 12, 34, 56, 7, 45, 34, 121, 5 };
ZeroEvenElementsOfArr(arr);
foreach (int item in arr)
{
    Console.WriteLine(item);
}