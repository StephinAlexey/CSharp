
int[,] CreateArrayByUser()
{

    Console.WriteLine("Please write rows quantity");
    string Input = Console.ReadLine();
    int i = Convert.ToInt32(Input);

    Console.WriteLine("Please write column quantity");
    Input = Console.ReadLine();
    int j = Convert.ToInt32(Input);

    int[,] tbl = new int[i, j];
    return tbl;
}

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
    Console.WriteLine("\nElements of the tabele is : \n");
    for (int i = 0; i < table.GetLength(0); i++) // run on the column of array
    {
        for (int j = 0; j < table.GetLength(1); j++) // run on the row of array
        {
            Console.Write($"{table[i, j]}   ");
        }
        Console.WriteLine("\n");

    }
}
bool IsInterestedNum(int num)
{
    int sum = 0;
    for (; num > 0; num = (num - num % 10) / 10)
    {

        sum = sum + num % 10;

    }
    if (sum % 2 == 0)
        return true;
    return false;
}
void Print2DimArrInterestedElements(int[,] table)
{
    Console.WriteLine("\nInteresed elements of the tabele is : \n");
    for (int i = 0; i < table.GetLength(0); i++) // run on the column of array
    {
        for (int j = 0; j < table.GetLength(1); j++) // run on the row of array
        {
            if (IsInterestedNum(table[i, j]))
                Console.Write($"{table[i, j]}   ");
            else
                Console.Write("**   ");
        }
        Console.WriteLine("\n");

    }
}

int[,] MyTable = CreateArrayByUser();
Filling2DimArrByRndNums(MyTable, 0, 100);
Print2DimArrElements(MyTable);
Print2DimArrInterestedElements(MyTable);

