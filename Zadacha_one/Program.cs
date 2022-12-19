// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"





void FillNumbers(int i, int N)
{
    if (N >= i)
    {
        FillNumbers(i + 1, N);
        Console.Write(i + ",");
    }
}


Console.WriteLine("введи число N: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
FillNumbers(i, n);