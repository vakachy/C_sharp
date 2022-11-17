// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRecursion(int m, int n)
{
    if (m == n) return n;
    else return m + SumRecursion(m + 1, n);
}

int m = 1;
int n = 15;
int sum = SumRecursion(m, n);
Console.WriteLine(sum);

m = 4;
n = 8;
sum = SumRecursion(m, n);
Console.WriteLine(sum);
