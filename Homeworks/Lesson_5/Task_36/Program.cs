
// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19  
// [-4, -6, 89, 6] -> 0


// ======= Method creates an array which items are random numbers =======

int[] CreateArray(int size)
{
    int[] array = new int[size];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}


// ======= Method defines only items with odd indexes =======

int[] GetItemsWithOddIndexes(int[] array)
{
    int k = 0;
    int count = 0;
    int length = array.Length;
    for (int j = 0; j < length; j++)
    {
        if (j % 2 != 0) count++;
    }

    int[] odds = new int[count];

    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            odds[k] += array[i];
            k++;
        }
    }
    return odds;
}


// ======= Method of summation items of an array that has odd indexes =======

int SumOddItems(int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int j = 0; j < length; j++)
    {
        if (j % 2 != 0)
        {
            sum += array[j];
        }
    }
    return sum;
}


// ======= Method prints an array =======

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


// ==============================================

Console.Clear();

Console.Write("Set a size of an array: ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);
Console.Write("The array's been generated as follows: array = ");
PrintArray(array);
Console.WriteLine();

int[] odds = GetItemsWithOddIndexes(array);
Console.Write("Items with odd indexes are: ");
PrintArray(odds);
Console.WriteLine();

int sum = SumOddItems(array);
Console.WriteLine("Sum: " + sum);
