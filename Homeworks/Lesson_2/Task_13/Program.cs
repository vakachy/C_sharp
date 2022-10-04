
/*Задача 13:
Напишите метод, который выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

Решение:

1. Описать метод выделения третьей цифры заданного числа
2. Описать метод проверки наличия третьей цифры числа из п.1
3. Описать метод вывода полученной цифры из п.2 в консоль

*/

// 1. ============ "Extruction of the 3rd digit out of the given number" method is described below: ============

int Get3rdDigit(int number)
{

    int thirdDigit = number / 100 % 10;
    return thirdDigit;
}



// 2. ============ Method that controls "if there is a 3rd digit" is described below: ============

bool IsDigit(int number)
{
    bool control = (number / 100) == 0;
    return control;
}



// 3. ============  "Print" method is described below: ============ 

void Print(int givenNumber, int thirdDigit, bool control)
{
    if (!control)
    {
        Console.WriteLine($"The third digit of the given number {givenNumber} is {thirdDigit}");
    }
    else
    {
        Console.WriteLine($"There is NO third digit in the given number {givenNumber}");
    }
    
}

//   ======================================================================


int t = 7; // The given number

bool contr = IsDigit(t);

int u = Get3rdDigit(t);

Print(t, u, contr);