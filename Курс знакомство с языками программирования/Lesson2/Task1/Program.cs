int[] arr = new int[5];
arr[0] = 5;
arr[1] = 6;
arr[2] = 2;
arr[3] = 3;
arr[4] = 56;

int[] arr2 = new int[5] { 5, 6, 2, 3, 56 };

int[] arr3 = { 5, 6, 2, 3, 56 };

foreach (int item in arr)
    Console.WriteLine(item);

foreach (int item in arr2)
    Console.WriteLine(item);

foreach (int item in arr3)
    Console.WriteLine(item);

