//Input Types: Random, Console.Readline
int [] CreateArrayByUser()
{
    
    Console.WriteLine("Please insert the length of array");
    string Input = Console.ReadLine();
    int N = Convert.ToInt32(Input);
    int [] Arr = new int [N];
    return Arr;
}

void RandomArrayFilling(int[] arr, int min_num, int max_num)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min_num, max_num);
    }
}

void PrintArrayElements(int[] arr)
{
    Console.Clear();
    Console.WriteLine("The array's elements list:");
    foreach (int item in arr)
        Console.WriteLine(item);
}




int[] Arr = CreateArrayByUser();
RandomArrayFilling(Arr, 0, 1200);
PrintArrayElements(Arr);


