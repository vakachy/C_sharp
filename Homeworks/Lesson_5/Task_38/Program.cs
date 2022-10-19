
// Задача 38:

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.  

// [3 7 22 2 78] -> 76


// ======= Method creates an array which items are random real numbers of type double;
// ======= range [0,5); rounded off to the thousandths =======
// ======= Массив заполняется случайными числами типа double от 0 до 5 с округлением до тысячных =======

double[] CreateArray(int size)
{
    double[] array = new double[size];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() * 5), 3);
    }
    return array;
}

// ======= Method to find max item of an array =======

double FindMaxOfArray(double[] array)
{
    double max = array[0];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

// ======= Method to find min item of an array =======

double FindMinOfArray(double[] array)
{
    double min = array[0];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

// ======= Method to evaluate difference (rounded off to the thousandths) between max & min in an array =======

double CalcDiffOfMaxAndMin(double max, double min)
{
    double diff = max - min;
    return Math.Round(diff, 3);
}

// ======= Method prints an array =======

void PrintArray(double[] array)
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

double[] array = CreateArray(size);
Console.Write("The array's been generated as follows: array = ");
PrintArray(array);
Console.WriteLine();

double max = FindMaxOfArray(array);
Console.WriteLine("Max = " + max);

double min = FindMinOfArray(array);
Console.WriteLine("Min = " + min);

double difference = CalcDiffOfMaxAndMin(max, min);
Console.WriteLine($"Difference:\n{max} - {min} = {difference}");