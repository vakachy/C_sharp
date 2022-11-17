
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// ======= Method to traverse a 3D-array iteratively =======

void traverse3DMatrixFor(int[,,] array)
{
    int row = array.GetLength(0); // rows
    int col = array.GetLength(1); // columns
    int layer = array.GetLength(2); // layers

    for (int i = 0; i < layer; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
            }
        Console.WriteLine();
        }
    }
}

// ======= Function to traverse a 3D-array recursively =======

int traverse3DMatrixRec(int[,,] array, int row = 0, int col = 0, int layer = 0)
{
    int n = array.GetLength(0); // rows
    int m = array.GetLength(1); // columns
    int l = array.GetLength(2); // layers

    if (col >= m) return 0;
    if (row >= n) return 0;
    if (layer >= l) return 1;

    Console.Write($"{array[row, col, layer]}({row},{col},{layer}) ");

    if (traverse3DMatrixRec(array, row, col + 1, layer) == 1) return 1;
    else col = 0;
    Console.WriteLine();

    if (traverse3DMatrixRec(array, row + 1, col, layer) == 1) return 1;
    else row = 0;

    return traverse3DMatrixRec(array, row, col, layer + 1);
}

// ======= Method fills 3D-array with 2-digit successive numbers starting from initValue =======

int[,,] Fill3DArray(int row, int col, int layer, int initValue)
{
    int[,,] a = new int[row, col, layer];

    for (int i = 0; i < layer; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                a[j, k, i] = initValue++;
            }
        }
    }
    return a;
}


// ======= Method mixes values of a 3D-array =======

int[,,] Mix3DArray(int[,,] a)
{
    int row = a.GetLength(0); // rows
    int col = a.GetLength(1); // columns
    int layer = a.GetLength(2); // layers
    int posL = 0;
    int posR = 0;
    int posC = 0;

    for (int i = 0; i < layer; i++)
    {
        posL = Random.Shared.Next(i, layer);
        for (int j = 0; j < row; j++)
        {
            posR = Random.Shared.Next(j, row);
            for (int k = 0; k < col; k++)
            {
                posC = Random.Shared.Next(k, col);
                (a[j, k, i], a[posR, posC, posL]) = (a[posR, posC, posL], a[j, k, i]);
            }
        }
    }
    return a;
}
// =================================

Console.Clear();

int row = 2; // rows
int col = 2; // columns
int layer = 2; // layers
int initValue = 10; // initial value to start fill array with
int limitValue = 99; // limit value to end fill array with

if (row * col * layer <= (limitValue - initValue) + 1) // check if there are enough 2-digital numbers to fill the array
{
    int[,,] array = Fill3DArray(row, col, layer, initValue);

    array = Mix3DArray(array);

    // traverse3DMatrixFor(array);

    Console.WriteLine(new String('=', 100));

    traverse3DMatrixRec(array);
}
else Console.WriteLine("Insufficient amount of numbers");
