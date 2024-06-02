//Matrices, Tables - Multidimensional arrays
using System;
// table.GetLength(0); количество строк
// table.GetLength(1); количество столбцов
void Filling2DimArrByRndNums(int[,] table, int min_num, int max_num)
{
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++) // run on the column of array
    {
        for (int j = 0; j < table.GetLength(1); j++)// run on the row of array

        {
            table[i, j] = rnd.Next(min_num, max_num);
        }

    }
}

void Print2DimArrElements(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++) // run on the column of array
    {
        for (int j = 0; j < table.GetLength(1); j++) // run on the row of array
        {
            Console.Write($"{table[i, j]}   ");
        }
        Console.WriteLine("\n");

    }
}
int[,] Table = new int[10, 9];
Filling2DimArrByRndNums(Table, 0, 9);
Print2DimArrElements(Table);
Console.WriteLine($"\nElement 5,4 is : {Table[5, 4]}");
int lengthrow = Table.GetLength(0);
Console.WriteLine($"количество строк: {lengthrow}");

int[,] Table1 = { { 23, 12, 34, 45 }, { 23, 77, 26, 12 }, { 23, 77, 26, 12 }, { 23, 77, 26, 12 } };
Print2DimArrElements(Table1);