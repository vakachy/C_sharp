
// Задача:
// 21. Программа проверяет пятизначное число на палиндром.

// 12321 -- палиндром
// 12345 -- не палиндром


int GetNum()
{
    Console.Write("Enter a number to check whether it is a palyndrome: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void IsPalyndrome(int initNum)
{
    int a = initNum;
    int newNum = 0;

    while (a != 0)
    {
        newNum = newNum * 10 + a % 10;
        a /= 10;
    }

    if (initNum == newNum) Console.WriteLine($"{initNum} -- is a palyndrome");
    else Console.WriteLine($"{initNum} -- is not a palyndrome");
}

int number = GetNum();

IsPalyndrome(number);
