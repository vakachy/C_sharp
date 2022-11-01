
/* 
76. Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы,
так чтобы в одной группе все числа были взаимно просты.

Например для N = 50, M получается 6 

Одно из решений :

Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48

Ещё одно решение:

Группа 1: 1 
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 16 24 36 40 
Группа 6: 32 48
 */

// ======= Get a number from input =======

int GetNumber()
{
    string number = Console.ReadLine();
    int intNumber = int.Parse(number);
    return intNumber;
}

// ======= Create an array of numbers using entered number as a limit =======

int[] CreateArray(int number)
{
    int[] array = new int[number];
    int k = 1;
    for (int j = 0; j < number; j++)
    {
        array[j] = k;
        k += 1;
    }
    return array;
}

// ======= Метод:
// ======= 1) получает на вход исходный массив чисел от 1 до n (вводит пользователь) и порядковый номер формируемой группы чисел;
// ======= 2) проверяет, делится ли без остатка каждый элемент массива на каждый элемент массива;
// ======= 3) если найден такой элемент (делимое), который делится без остатка на текущий элемент (делитель), то
// ======= такой элемент (делимое) помещается в другой массив, а в исходном массиве обнуляется;
// ======= 4) полученный таким образом новый массив "делимых" становится новым исходным массивом (при этом содержащиеся в массиве
// ======= нули не имеют значения, т. к. в условии выбора делимого и делителя учтено, что они не могут равняться нулю);
// ======= 5) также формирует вывод в консоль первоначальный массив "делителей" (сортировка, пропуск нулевых значений)
// ======= с учетом полученного номера группы

int[] CheckDivision(int[] array, int n, int groupNumber)
{
    // ======= проверка на делимость без остатка, создание массива "делимых", обнуление значений =======

    int length = array.Length;
    int[] newArray = new int[length];
    int k = 0;
    for (int i = 0; i < length - 1; i++)
    {
        for (int j = i + 1; j < length; j++)
        {
            if (array[i] != 0 && array[j] != 0 && array[j] % array[i] == 0)
            {
                newArray[k] = array[j];
                array[j] = 0;
                k++;
            }
        }
    }

    // ======= сортировка массива array[] =======

    int temp = 0;
    length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        for (int j = i + 1; j < length; j++)
        {
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

    // ======= формирование вывода массива array[] в виде строки символов =======

    string output = String.Empty;
    for (int l = 0; l < length; l++)
    {
        if (array[l] != 0) output += $"{array[l]} ";
    }
    Console.Write($"Group {groupNumber}: {output}");
    return newArray;
}

// ====== проверяет, содержатся ли в массиве только нули =======
// ====== далее используется для остановки цикла =======

bool CheckIfOnlyZeros(int[] newArray)
{
    bool flag = false;
    int count = 0;
    int length = newArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (newArray[i] == 0) count++;
    }
    if (count == length) flag = true;
    return flag;
}

// =================================================================

Console.Clear();

Console.WriteLine("Enter a number. It must be a natural number less than 10^20.");
Console.Write("The number is: ");

int n = GetNumber();
int[] array = CreateArray(n);
int groupNumber = 1;
bool flag = CheckIfOnlyZeros(array);

while (!flag)
{
    array = CheckDivision(array, n, groupNumber);
    flag = CheckIfOnlyZeros(array);
    groupNumber++;
    Console.WriteLine();
    Console.WriteLine();
}
