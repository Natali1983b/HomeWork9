// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4;
int N = 8;

int Count(int M ,int N)
{
     int Summa = 0;
     for (int i = M; i <= N; i++)
     {
        Summa += i;
     }
    return Summa;
}

int Summa = Count(M,N);
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {Count(M,N)}");