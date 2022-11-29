// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRecursion(int numM, int numN)
{
    if (numM == numN) return numM;
    return numM += SumRecursion(numM < numN ? numM + 1 : numM - 1, numN);
}
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Ошибка! Ведите натуральные числа.");
}
else
{
    int sumRecursion = SumRecursion(numberM, numberN);
    Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} = {sumRecursion}");
}
