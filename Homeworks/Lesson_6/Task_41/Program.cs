
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// ======= Method creates an array of required size,
// all the numbers entered by the user are stored in it =======

int[] RememberAllNumbers(int quantity)
{
    int[] allNumbers = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Console.Write("Enter next number: ");
        allNumbers[i] = int.Parse(Console.ReadLine());
    }
    return allNumbers;
}


// ======= Method finds and counts only positive elements in an array =======

int CountPositiveItems(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


// ======= Method prints an array =======

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


// ======= Method prints a result =======

void PrintResult(int count)
{
    Console.Write($"Quantity of positive elements greater than 0: {count}");
}


// ==============================================

Console.Clear();

Console.Write("Enter a quantity of numbers to be entered: ");
int quantity = int.Parse(Console.ReadLine());

int[] memo = RememberAllNumbers(quantity);

Console.Write("All the numbers you've entered are: ");
PrintArray(memo);
Console.WriteLine();

PrintResult(CountPositiveItems(memo));
