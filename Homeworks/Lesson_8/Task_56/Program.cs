
// Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// ======= Method evaluates sums of rows of the 2D array and creates another array to store results =======

int[] EvaluateSumOfEachRow(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int sum = 0;
    int[] arrayOfSums = new int[m];

    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        arrayOfSums[i] = sum;
    }
    return arrayOfSums;
}

// ======= Method finds min value in an 1D array =======

int FindMin(int[] array)
{
    int m = array.Length;
    int min = array[0];
    int indexOfMin = 0;

    for (int i = 0; i < m; i++)
    {
        if (array[i] < min)
        {
            indexOfMin = i;
            min = array[i];
        }
    }
    return indexOfMin;
}

// ======= Method prints result =======

void PrintResult(int indexOfMin)
{
    Console.Write($"The minimum sum of elements is at the {indexOfMin + 1} row of array.");
}

// =====================================

Console.Clear();

int[,] array = { { 1, 4, 7, 2 }, { 1, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

int[] sumByRow = EvaluateSumOfEachRow(array);
int indexOfMin = FindMin(sumByRow);
PrintResult(indexOfMin);