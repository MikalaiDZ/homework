// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();
int[,,] CreateCubeInt(int rows, int columns, int depth, int num)
{
    int[,,] cube = new int[rows, columns, depth];
    

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = num++;
            }

        }

    }
    return cube;
}
void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k}) ");
                
            }

        }
    }
}
int[,,] cube = CreateCubeInt(4, 2, 3, 26);
PrintCube(cube);