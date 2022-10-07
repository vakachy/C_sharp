
// 1. По двум заданным числам проверять является ли первое квадратом второго



void IfPowOf2()
{
    Console.WriteLine("Enter natural numbers \"a\" and \"b\" to check if a = b x b");
    
    Console.Write("Enter a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a == Math.Pow(b, 2)) Console.Write($"Yes: {a} = {b} x {b}");
    else Console.Write($"No: {a} != {b} x {b}");
}

IfPowOf2();
