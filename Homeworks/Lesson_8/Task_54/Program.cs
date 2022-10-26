
// Задача 54:
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// ======= Method sorts every row in a 2D array in descending order =======

int[,] SortDescentRowsOfArray(int[,] array)
{
    int m = array.GetLength(0); // rows
    int n = array.GetLength(1); // columns

    for (int i = 0; i < m; i++) // rows of array
    {
        for (int j = 0; j < n - 1; j++) // iterating by every element in an array's row up to the penultimate element
        {
            for (int k = j + 1; k < n; k++) // iterating every next element in an array's row to compare to the previous one
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

// ======= Method prints a 2D array =======

void PrintArray(int[,] array)
{
    int m = array.GetLength(0); // rows
    int n = array.GetLength(1); // columns

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//  ========================================

Console.Clear();

int[,] array = { { 0, 5, 9, -1, 88, 100 }, { 22, 6, 1, 57, -10, -100 } };

array = SortDescentRowsOfArray(array);
PrintArray(array);
