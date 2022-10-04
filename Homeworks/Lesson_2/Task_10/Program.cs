/*
Задача 10:
Напишите метод, который принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

Решение:
1. Описать метод для получения трёхзначного числа
2. Описать метод определения второй цифры числа из п.1
3. Описать метод вывода полученной цифры из п.2 в консоль
*/

// 1. ============ "Generating a 3-digit-number" method is described below: ============

int GetNumber()
{
    int threeDigitNumber = new Random().Next(100, 1000);
    return threeDigitNumber;
}

// 2. ============ "Extruction of the second digit out of 3-digit-number" method is described below: ============

int Get2ndDigit(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}

// 3. ============  "Print" method is described below: ============ 

void Print( int number, int secondDigit)
{    
    Console.WriteLine($"Second digit of the number {number} is {secondDigit}");
}

//    ======================================================================

int t = GetNumber();
int u = Get2ndDigit(t);

Print(t, u);
