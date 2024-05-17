// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;

bool flag=true;
Console.Clear();
while(flag)
{
  Console.WriteLine("Please insert 1 or 2 for correct printing\nInsert x for exit\n");
  switch (Console.ReadLine())
  {
    case "1":
    Console.Clear();
    Console.WriteLine("Your input is 1");
    break;
    case "2":
    Console.Clear();
    Console.WriteLine("Your input is 2");
    break;
    case "x":
    flag=false;
    break;
    default:
    Console.Clear();
    Console.WriteLine("Your input isn't 1 or 2");
    break;

  }
}
