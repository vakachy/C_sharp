
// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// =======  Method: number input =======
// ======= Метод: ввод числа =======

long GetNumber()
{
    long number = long.Parse(Console.ReadLine());
    return number;
}

// =======  Method: digits of a number summation =======
// ======= Метод: суммирование цифр числа =======

long SumOfDigits(long number)
{
    long a = number;
    long sum = 0;
    
    if (a < 0) a = -a;

    while (a != 0)
    {
        sum = sum + a % 10;
        a /= 10;
    }
    return sum;
}

// ==============================

Console.Write("Enter any integer number to calculate its digits sum: ");
long number = GetNumber();
long sum = SumOfDigits(number);

Console.WriteLine($"Sum of the digits of <{number}> is <{sum}>");