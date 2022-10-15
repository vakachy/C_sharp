
// Задача 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// ======= Метод для ввода числа/значения типа int =======

int GetNum()
{
    Console.Write("Enter a natural number N: ");
    int number = int.Parse((Console.ReadLine()));
    return number;
}


// Метод вычисления кубов чисел от 1 до N =======

double[] RaisingTo3(int number)
{
    double[] exp = new double[number];
    double pow3 = 1;
    int k = 0;
    for (int i = 1; i <= number; i++)
    {
        pow3 = i * i * i;
        exp[k] = pow3;
        k++;
    }
    return exp;
}


// ======= Метод вывода результата в консоль =======

void PrintRes(int num, double[] exp)
{
    for (int i = 0; i < exp.Length; i++)
    {        
        Console.Write($"{exp[i]} ");
    }
}



// ==========================================================

int num = GetNum();
double[] pow3 = RaisingTo3(num);
Console.WriteLine($"The result of raising to the 3 power of each number from 1 to {num}: ");
PrintRes(num, pow3);
