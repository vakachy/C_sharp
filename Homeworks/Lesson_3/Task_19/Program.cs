
// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// ======= Checking input to be an integer number =======
// ======= Метод проверяет, что введено значение/число типа int =======

int GetAndCheckInput()
{
    int a;
    bool flag = false;
    
    string? text = Console.ReadLine();
    flag = int.TryParse(text, out a);

    while (!flag)
    {
        Console.WriteLine("Bad input. Try again. Just integer numbers are allowed!");
        Console.Write("Enter number: ");
        string? text1 = Console.ReadLine();
        flag = int.TryParse(text1, out a);
    }
    Console.Write("Good for you.\nThe number to check for palyndrom is: " + a);
    return a;
}


// ======= Checking the number to be a palyndrom =======
// ======= Метод проверяет на палиндром =======

bool IsPalyndrome(int initNum)
{
    bool flag;
    int a = initNum;
    int newNum = 0;

    while (a != 0)
    {
        newNum = newNum * 10 + a % 10;
        a /= 10;
    }

    if (initNum == newNum) flag = true;
    else flag = false;

    return flag;
}


// ======= Printing the result =======
// ======= Вывод результата в консоль =======

void PrintResult(bool flag, int initNum)
{
    if (flag) Console.WriteLine($"\"{initNum}\" is a palyndrome");
    else Console.WriteLine($"\"{initNum}\" is not a palyndrome");

}

// ======= The code =======

Console.Write("Enter integer number to check whether it is a palyndrom: ");

int num = GetAndCheckInput();
Console.WriteLine();

bool flag = IsPalyndrome(num);

PrintResult(flag, num);
