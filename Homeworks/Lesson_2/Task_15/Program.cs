
/* Задача 15:

Напишите метод, который принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

Решение:
1. Описать метод для получения случайной цифры, обозначающей день недели
2. Описать метод проверки, является ли этот день выходным
*/

// 1. ============ "Generating a random number denoting a day of a week" method is described below: ============

int GetDayNumber()
{
    int randomDay = new Random().Next(1, 8);
    return randomDay;
}

// 2. ============ "Checking whether the number refers a weekend or not" method is described below: ============

void IsAWeekend(int weekDaysNum)
{
    if (weekDaysNum >= 6) Console.WriteLine($"{weekDaysNum} --> Yes");

    if (weekDaysNum < 6) Console.WriteLine($"{weekDaysNum} --> No");
}

//    ======================================================================

IsAWeekend(GetDayNumber());

