

// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ======= Method generates 2D array of random size and fills it with a random numbers =======

int[,] GenerateAndFillArray()
{
    int m = new Random().Next(2, 6);
    int n = new Random().Next(2, 6);
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 16);
        }
    }
    return array;
}

// ======= Method prints an array =======

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// ======= Method evaluates mean value of each column in an array =======

double[] EvaluateMean(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    double sum = 0;
    double[] meanValue = new double[n];
    double count = 0;

    for (int i = 0; i < n; i++)
    {
        sum = 0;
        count = 0;
        for (int j = 0; j < m; j++)
        {
            sum += array[j, i];
            count++;
        }
        meanValue[i] = Math.Round(sum / count, 2);
    }
    return meanValue;
}

// ======= Method prints a result =======

void PrintResult(double[] meanValue)
{
    int m = meanValue.Length;
    for (int i = 0; i < m; i++) Console.Write(meanValue[i] + " ");
}

// ==============================================

Console.Clear();

int[,] array = GenerateAndFillArray();

double[] meanValue = EvaluateMean(array);

PrintArray(array);
Console.WriteLine();
PrintResult(meanValue);
