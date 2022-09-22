// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите значение M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write ($" {i}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
namespace Task2
{
    class Test
    {
        static int Sum(int M, int N)
        {
            if (M == 0) return (N * (N + 1)) / 2;            
            else if (N == 0) return (M * (M + 1)) / 2;       
            else if (M == N) return M;                       
            else if (M < N) return N + Sum(M, N - 1); 
            else return N + Sum(M, N + 1);            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число M: = ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите целое положительное число N: = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма элементов = {Sum(M, N)}");
        }
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkFunc(m,n);


void AkkFunc(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}
