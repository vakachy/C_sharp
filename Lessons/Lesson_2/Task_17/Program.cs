
// 17. По двум заданным числам проверять является ли одно квадратом другого

void IfBothPowOf2()
{
    Console.WriteLine("Enter natural numbers \"a\" and \"b\" to check if \"a = b x b\" or/and if \"b = a x a\"");
    
    Console.Write("Enter a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a == Math.Pow(b, 2)) Console.Write($"{a} = {b} x {b} or a = b^2");
    else if (b == Math.Pow(a, 2)) Console.Write($"{b} = {a} x {a} or b = a^2");
    else Console.Write($"Neither a = b^2 nor b = a^2");
}

IfBothPowOf2();