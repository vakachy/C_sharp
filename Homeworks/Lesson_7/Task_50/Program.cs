
// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


// ======= Method generates 2D array of random size and fills it with a random numbers =======

int[,] GenerateAndFillArray()
{
    int m = new Random().Next(2, 11);
    int n = new Random().Next(2, 11);
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 21);
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

// ======= Method gets a position of an element of an array out of the user's input (as a string[]) =======

string[] ProcessInput(string input)
{
    string[] position = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    return position;
}

// ======= Method checks there is an element in an array (considering given position) =======

bool IsPositionInArray(string[] position, int[,] array)
{
    int mSet = int.Parse(position[0]);
    int nSet = int.Parse(position[1]);
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    bool presence = true;

    if (mSet < m && nSet < n) return presence;
    return !presence;
}

// ======= Method prints a result =======

void PrintResult(bool presence, int[,] array, string[] position)
{
    int mSet = int.Parse(position[0]);
    int nSet = int.Parse(position[1]);
    if (presence)
    {
        Console.WriteLine($"The element at position ({mSet},{nSet}) is {array[mSet, nSet]}");
    }
    else
    {
        Console.WriteLine("There is no such element in the array.");
    }
}


// =============================================

Console.Clear();

int[,] array = GenerateAndFillArray();

Console.Write("Enter position of an element in an array in \"m,n\" format: ");

string input = Console.ReadLine();

string[] position = ProcessInput(input);

bool presence = IsPositionInArray(position, array);

PrintResult(presence, array, position);

Console.WriteLine("The array is: ");

PrintArray(array);