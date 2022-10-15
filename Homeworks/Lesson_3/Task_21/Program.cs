
// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// ======= Getting coordinates of a point in 3D =======
// ======= Метод получения координат одной точки =======

int[] GetCoordinates()
{
    string? coordinates = Console.ReadLine();

    string[] a = coordinates.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

    int[] coordsAsNums = new int[a.Length];

    for (int i = 0; i < a.Length; i++)
    {
        coordsAsNums[i] = int.Parse(a[i]);
    }
    return coordsAsNums;
}


// ======= Calculating distance between two points in 3D =======
// ======= Метод вычисления расстояния между двумя точками в трехмерном пространстве =======

double CalcDistance(int[] a, int[] b)
{
    double distanceAlongAxis = 0;
    double distPow2 = 0;
    double dist = 0;

    for (int i = 0; i < a.Length; i++)
    {
        distanceAlongAxis = a[i] - b[i];
        distPow2 += Math.Pow(distanceAlongAxis, 2);
        dist = Math.Sqrt(distPow2);
        dist = Math.Round(dist, 2);
    }
    return dist;
}


// ==============================================================

Console.WriteLine("Enter point A and B coordinates in \"x, y, z\" format (separated by comma!)");

Console.Write("Enter x,y,z for point A: ");
int[] a = GetCoordinates();

Console.Write("Enter x,y,z for point B: ");
int[] b = GetCoordinates();

double distance = CalcDistance(a, b);
Console.WriteLine($"The distance between points A({a[0]},{a[1]},{a[2]}) & B({b[0]},{b[1]},{b[2]}) in 3D = {distance}");
