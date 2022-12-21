// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if ((numberM != 0) && (numberN == 0))
    {
        return AckermanFunction(numberM - 1, 1);
    }
    else
    {
        return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
    }
}

int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = DataEntry("введи число m: ");
int n = DataEntry("введи число n: ");
int result = AckermanFunction(m, n);
Console.WriteLine($"Функция Аккермана для чисел ({m},{n}) = {result}");






