// Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int N = new Random().Next(2, 41);
int currentNumber = 1;
int lastNumber = N;

Console.Write(" All even numbers from the given interval [1, " + N + "]: ");

while (currentNumber <= lastNumber)
{
    if (currentNumber % 2 == 0)
    {
        Console.Write(currentNumber + " ");
    }

    currentNumber++;
}