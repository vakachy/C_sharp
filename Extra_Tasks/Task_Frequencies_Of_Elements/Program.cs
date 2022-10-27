
// Задача 60:
// Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.


// ======= Method fills an array =======

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    m = array.GetLength(0);
    n = array.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 21);
        }
    }
    return array;
}

// ======= Method prints a 2D array =======

void Print2DArray(int[,] array)
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

// ======= Method Transforms an array from 2D into 1D =======

int[] TransformArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[] array1D = new int[m * n];
    int k = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array1D[k] = array[i, j];
            k++;
        }
    }
    return array1D;
}

// ======= Method prints an 1D array =======

void Print1DArray(int[] array)
{
    int m = array.Length;
    for (int i = 0; i < m; i++) Console.Write(array[i] + " ");
}

// ======= Method performs sort of an array in ascending order =======

int[] SortAscend(int[] a)
{
    int length = a.Length;
    for (int i = 0; i < length - 1; i++)
    {
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[j] < a[i])
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
    return a;
}

// ======= Method to count a quantity of all unique values in an array =======
// ======= Method outputs a 2D array where the 1st row contains all unique values of an array =======
// ======= and the 2nd one -- corresponding quantity of a particular value of an array (frequensies) =======

int[,] EvalFreqs(int[] a)
{
    int length = a.Length;
    int countRepeatVal = 0;
    int[,] memo = new int[2, length];
    int i = 0;
    int k = 0;

    while (i < length)
    {
        countRepeatVal = 0;
        for (int j = length - 1; j >= i; j--)
        {
            if (a[i] == a[j]) countRepeatVal++;
        }
        memo[0, k] = a[i];
        i += countRepeatVal;
        memo[1, k] = countRepeatVal;
        k++;
    }
    return memo;
}

// ======= Method to calculate statistics ======= !!! требуется доработка (чтобы метод НЕ выводил ничего в консоль) !!!

void CalcStat(int[,] arr)
{
    int sum = 0;
    double frequency = 0;
    int m = arr.GetLength(1);
    for (int k = 0; k < m; k++) sum += arr[1, k];

    for (int i = 0; i < m; i++)
    {
        if (arr[1, i] != 0)
        {
            frequency = Math.Round(Convert.ToDouble(arr[1, i]) / Convert.ToDouble(sum) * 100, 3);

            Console.Write($"Value {arr[0, i]} quantity {arr[1, i]} frequency {frequency}%");
            Console.WriteLine();
        }
    }
}

// =================================
Console.Clear();

Console.WriteLine("Enter dimentions m & n of an array");

Console.Write("Enter m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = FillArray(m, n);

Print2DArray(array);
Console.WriteLine();

int[] array1D = TransformArray(array);

int[] array1DSorted = SortAscend(array1D);

int[,] memo = EvalFreqs(array1DSorted);

CalcStat(memo);
