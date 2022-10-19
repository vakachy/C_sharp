
// Задача 34:

// Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// **[345, 897, 568, 234] -> 2**




// ======= Method creates an array which items are positive 3-digit integer random numbers =======

int[] CreateArray(int size)
{
    int[] array = new int[size];
    int length = array.Length;
    for (int i = 0; i < length; i++) array[i] = new Random().Next(100, 1000);
    return array;
}

// ======= Method prints an array =======

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++) Console.Write(array[i] + " ");
}

// ======= Method counts only even items of an array =======

int CountEvenItems(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int j = 0; j < length; j++)
    {
        if (array[j] % 2 == 0) count++;
    }
    return count;
}

// ======= Method defines only even items of an array =======

int[] GetEvenItemsOfArray(int[] array, int count)
{
    int k = 0;
    int[] evens = new int[count];
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evens[k] += array[i];
            k++;
        }
    }
    return evens;
}


// ==============================================

Console.Clear();

Console.Write("Set a size of an array: ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);

if (array.Length != 0)
{
    Console.Write("The array's been generated as follows: array = ");
    PrintArray(array);
    Console.WriteLine();
}

int count = CountEvenItems(array);
int[] evens = GetEvenItemsOfArray(array, count);

if (count != 0)
{
    Console.Write("Even items of the array: ");
}
else Console.Write("Array is empty");

PrintArray(evens);
Console.WriteLine();

Console.WriteLine("Quantity of even items in the array: " + count);
