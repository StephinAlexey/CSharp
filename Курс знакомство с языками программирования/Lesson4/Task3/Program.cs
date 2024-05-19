

using System;
using System.Text;

string? InputString()
{

    Console.WriteLine("Please insert new string:");
    string? str = Console.ReadLine();
    return str;
}
int[] FromLetteralAndNumbersStringToIntegerArray(string? Array)
{

    string? NumStrig = null;
    foreach (char item in Array)
    {
        if (char.IsAsciiDigit(item))
            NumStrig = NumStrig + item;
    }
    int[] IntArr = new int[NumStrig.Length];
    for (int i = 0; i < NumStrig.Length; i++)
    {
        IntArr[i] = (int)char.GetNumericValue(NumStrig[i]);

    }
    return IntArr;
}
string DelNumbersFromStr(string? str)
{
    if (str == null)
        return "";
    string UpdStr = null;
    foreach (char item in str)
    {
        if (char.IsAsciiLetter(item))
            UpdStr = UpdStr + item;
    }
    return UpdStr;
}
void PrintArrayElements(int[] arr)
{

    Console.WriteLine("The array's elements list:");
    foreach (int item in arr)
        Console.Write($"{item} ");
}

string? str = InputString();
//string? newstr = DelNumbersFromStr(str);
//Console.WriteLine($"The udated string is : {newstr}");
int[] Arr = FromLetteralAndNumbersStringToIntegerArray(str);
PrintArrayElements(Arr);

