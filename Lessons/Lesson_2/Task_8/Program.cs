
// Задача:
// 8. Показать четные числа от 1 до N

// Решение:
// 1. Метод для ввода числа
// 2. Метод для вычисления четных чисел от 1 до N
// 3. Метод для печати результата

// ======= 
int InputNumber()
{
    Console.Write("Enter a number N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Number \"{number}\" has being entered");
    return number;
}

// ======= 

void PrintIfEven(int N)
{
    Console.Write($"All even numbers between 1 and {N} are: ");
    int i = 1;
    while (i <= N)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    
        i++;
    }
}

// ======= 

int number = InputNumber();
PrintIfEven(number);
