// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


double a = new Random().NextDouble() * 10;
double b = new Random().NextDouble() * 10;

if (a > b)
{
    Console.WriteLine("a = " + a + " -- большее число" + "\n" + "b = " + b + " -- меньшее число");
}
else
{
    Console.WriteLine("a = " + a + " -- меньшее число" + "\n" + "b = " + b + " -- большее число");
}