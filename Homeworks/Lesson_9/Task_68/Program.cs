
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(0,n) = n+1
// A(m,0) = A(m-1,1)
// A(m,n) = A(m-1,A(m,n-1))

int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

int m = 2;
int n = 3;
Console.WriteLine(A(m, n));

m = 3;
n = 2;
Console.WriteLine(A(m, n));