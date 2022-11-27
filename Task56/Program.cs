﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void PrintSum(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.WriteLine(arr[i] );
        else Console.WriteLine(arr[i]);
    }
    
}

int[] IndexSumMax(int[,] matrix)
{
    int[] avr = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        avr[i] = sum;
    }
    return avr;
}
int IndexMin(int[] arr)
{
    int index = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
             min = arr[i];
            index = i;
        }
    }
    return ++index;
}

int[,] matrix = CreateMatrixRndInt(5, 4, 1, 9);
PrintMatrix(matrix);
int[] sum = IndexSumMax(matrix);
Console.WriteLine("Сумма чисел в строках ");
PrintSum(sum);
int ind = IndexMin(sum);
Console.WriteLine($"Наименьшая сумма чисел в строке {ind}");