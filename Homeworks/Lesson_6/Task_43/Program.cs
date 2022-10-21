
// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// ======= Method to evaluate coordinates of intersection of two lines =======

string[] EvalIntersectionCoords(double[,] array)
{
    double k1 = array[0, 0]; double k2 = array[1, 0];
    double b1 = array[0, 1]; double b2 = array[1, 1];

    double x = Math.Round((b2 - b1) / (k1 - k2), 3);
    string xx = Convert.ToString(x);

    double y = Math.Round(k1 * ((b2 - b1) / (k1 - k2)) + b1, 3);
    string yy = Convert.ToString(y);

    string[] intersection = { xx, yy };

    return intersection;
}

// ======= Method prints a result depending of whether the lines: =======
// a)intersect
// b) parallel or
// c) coincide

void PrintResult(string[] coordinates, double[,] parameters)
{
    double k1 = parameters[0, 0]; double k2 = parameters[1, 0];
    double b1 = parameters[0, 1]; double b2 = parameters[1, 1];
    string equations = $"y = {k1}x + {b1}"
                    + $"\nand"
                    + $"\ny = {k2}x + {b2}";

    if (k1 != k2 && b1 != b2)
    {
        Console.Write($"Intersection coordinates of lines:\n"
                    + equations
                    + $"\nare"
                    + $"\n({coordinates[0]}; {coordinates[1]})");
    }

    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("The lines parallel. No intersection:");
        Console.Write(equations);
    }

    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("The lines coinside:");
        Console.Write(equations);
    }
}

// =======================================

Console.Clear();

double[,] parameters = new double[2, 2];

Console.Write($"k1 = ");
parameters[0, 0] = double.Parse(Console.ReadLine());

Console.Write($"b1 = ");
parameters[0, 1] = double.Parse(Console.ReadLine());

Console.Write($"k2 = ");
parameters[1, 0] = double.Parse(Console.ReadLine());

Console.Write($"b2 = ");
parameters[1, 1] = double.Parse(Console.ReadLine());

string[] intersectCoords = EvalIntersectionCoords(parameters);
PrintResult(intersectCoords, parameters);
