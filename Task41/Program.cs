// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] FillArray(int size)
{
    int[] array = new int[size];
    int count = 1;
    int num = default;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {count++} число: ");
        num = Convert.ToInt32((Console.ReadLine()));
        array[i] = num;
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int PositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
Console.Write("Введите количество чисел -> ");
int m = Convert.ToInt32((Console.ReadLine()));
int[] array = FillArray(m);
Console.Write("из введенных чисел ");
PrintArray(array);
Console.WriteLine($"Вы ввели {PositiveNumbers(array)} числа больше нуля. ");