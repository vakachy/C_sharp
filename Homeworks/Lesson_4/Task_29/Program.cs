
// Задача 29:
// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// ======= Method creates an array of a given size 8 which items are random numbers from 0 to 100 =======
// ======= Метод создает массив размером 8 случайных элементов в диапазоне от 0 до 100 =======

int[] GenArr()
{
    int quantity = 8;
    int[] array = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}


// ======= Method: print the array =======
// ======= Метод: печать массива =======

void PrintArr(int[] a)
{
    string result = String.Empty;

    for (int i = 0; i < a.Length; i++)
    {
        result += $"{a[i]} ";
    }
    Console.Write($"[{result}]");
}


// ==========================================

Console.WriteLine("Generating an array that cosists of a random natural items ranging from 0 to 100");
int[] arr = GenArr();

Console.Write("Here is the array: int[] array = ");
PrintArr(arr);