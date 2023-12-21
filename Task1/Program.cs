// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.
//Console.Write"Enter a number 1:")
//string a1 = Console.ReadLine()!;
//Console.Write"Enter a number 2:")
//string a2 = Console.ReadLine()!;
//int b1 = Convert.ToInt32(a1);
//int b2 = Convert.ToInt32(a2);
//if (b2*b2==b1)
//    Console.WriteLine("Yes");
//else 
 //   Console.WriteLine("No");

    Console.Write("Enter a number 1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int b2 = int.Parse(Console.ReadLine()!);

if (b2 * b2 == b1) 
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");