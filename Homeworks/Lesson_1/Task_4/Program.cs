// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = new Random().Next(0, 101);
int b = new Random().Next(0, 101);
int c = new Random().Next(0, 101);

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine("Number a: " + a + "\n" + "Number b: " + b + "\n" + "Number c: " + c);
Console.WriteLine("Maximum number is: " + max);