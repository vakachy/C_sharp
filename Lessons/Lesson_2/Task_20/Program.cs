
// Задача:
// 20. Задать номер четверти, показать диапазоны для возможных координат


int GetQuadrant()
{
    Console.Write("Enter a number representing required quadrant (1 or 2 or 3 or 4): ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetCoordinates(int quadrant)
{
    if (quadrant == 1) Console.WriteLine("The range of possible coordinates: x > 0, y > 0");
    if (quadrant == 2) Console.WriteLine("The range of possible coordinates: x > 0, y < 0");
    if (quadrant == 3) Console.WriteLine("The range of possible coordinates: x < 0, y < 0");
    if (quadrant == 4) Console.WriteLine("The range of possible coordinates: x > 0, y < 0");
}

int q = GetQuadrant();
GetCoordinates(q);