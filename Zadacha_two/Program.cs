// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




int SumElrments(int M, int N)
{
    int sum = 0;
    if (M <= N)
    {
        sum = sum + N + SumElrments(M, N - 1);
    }
    return sum;
}


Console.WriteLine("введи число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введи число N: ");
int n = int.Parse(Console.ReadLine());
int result = SumElrments(m, n);
Console.WriteLine($"сумма натуральных элементов в промежутке от {m} до {n} -> {result}");