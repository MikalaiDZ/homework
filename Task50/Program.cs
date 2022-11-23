// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}| ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

void PositionElement(int[,] arr, int row, int column)
{
    int num = default;
    row--;
    column--;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (row == i && column == j)
                num = arr[i, j];
    }
    row++;
    column++;
    if (row > 0 && row <= arr.GetLength(0) && column > 0 && column <= arr.GetLength(1))
        Console.WriteLine(num);
    else Console.WriteLine($"{row},{column} -> такого элемента нет");
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);
Console.Write("Введите номер строки -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца -> ");
int columns = Convert.ToInt32(Console.ReadLine());
PositionElement(matrix, rows, columns);
