// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}
int[,] MatrixProduct(int[,] matrOne, int[,] matrTwo)
{
    int[,] matrProd = new int[matrOne.GetLength(0), matrTwo.GetLength(1)];

    for (int i = 0; i < matrOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrTwo.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrOne.GetLength(1); k++)
            {

                sum += matrOne[i, k] * matrTwo[k, j];
            }
            matrProd[i, j] = sum;
        }
    }
    return matrProd;
}


int[,] matrixOne = CreateMatrixRndInt(4, 3, 1, 9);
Console.WriteLine("Первая матрица");
PrintMatrix(matrixOne);
Console.WriteLine("Вторая матрица");
int[,] matrixTwo = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(matrixTwo);
int[,] matrixProduct = MatrixProduct(matrixOne, matrixTwo);
if(matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{   
    Console.WriteLine("Произведение матриц");
    PrintMatrix(matrixProduct);
}
else Console.WriteLine("Матрицы невозможно перемножить.");