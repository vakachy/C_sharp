// Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int a = new Random().Next(0, 100001);

if (a % 2 == 0)
{
    Console.WriteLine("Number " + a + " is even");
}
else
{
    Console.WriteLine("Number " + a + " is odd");
}