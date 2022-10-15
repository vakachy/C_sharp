
// Задача 25: опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без math.pow



// ======= Getting numbers A & B =======
// ======= Метод: ввод чисел =======

int[] GetNumbers()
{
    string? text = Console.ReadLine();
    string[] a = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

    int[] numbers = new int[a.Length];

    for (int i = 0; i < a.Length; i++)
    {
        numbers[i] = int.Parse(a[i]);
    }
    return numbers;
}


// ======= Raising A to the B  =======
// ======= Метод: возведение числа А в степень числа В ======= 

double Exponentiation(int[] numbers)
{
    int basis = numbers[0];
    int power = numbers[1];
    double result = 1;

    for (int n = 1; n <= power; n++)
    {
        result *= basis;
    }
    return result;
}



// ======= Print result  =======

void Print(int[] a, double exp)
{
    Console.WriteLine($"base = {a[0]}, exponent = {a[1]}.\nResult {a[0]}^{a[1]} = {exp}");
}


// ==============================================================

Console.WriteLine("Enter numbers A and B to raise A to the B (numbers must be natural in this case)");
Console.Write("Input format: a,b: ");

int[] a = GetNumbers();

double exp = Exponentiation(a);

Print(a, exp);
