
// Задача 58:
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// ======= Method multiplies two matrices =======
// ======= Method doesn't check if it's possible to multiply given matrices =======
// ======= but it does multiply any allowable matrices =======

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int a = matrix1.GetLength(1); // columns -- matrix 1
    int c = matrix1.GetLength(0); // rows -- matrix 1

    int b = matrix2.GetLength(0); // rows -- matrix 2
    int d = matrix2.GetLength(1); // columns -- matrix 2

    int[,] resMatrix = new int[c, d];

    for (int i = 0; i < c; i++) // i < rows of matrix 1
    {
        for (int j = 0; j < d; j++) // j < columns -- matrix 2
        {
            for (int k = 0; k < a; k++) // k < elements in a row of matrix 1 (which is a number of columns of matrix 1)
            {
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resMatrix;
}

// ======= Method prints matrix =======

void PrintResMatrix(int[,] resMatrix)
{
    int a = resMatrix.GetLength(0);
    int b = resMatrix.GetLength(1);

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write(resMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// ==================================================

int[,] matrix1 = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
int[,] matrix2 = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };

int[,] resMatrix = MultiplyMatrices(matrix1, matrix2);
PrintResMatrix(resMatrix);
