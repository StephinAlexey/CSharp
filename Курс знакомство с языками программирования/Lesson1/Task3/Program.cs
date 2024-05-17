int a = 23;
int b = 23;
if(a > b)
PrintVar(a);
if(b > a)
PrintVar(b);
else
Console.WriteLine("a=b");
void PrintVar(int i)
{
    Console.WriteLine(i+" is bigest");
}
