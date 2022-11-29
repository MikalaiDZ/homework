// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint AckermanFunction(uint numM, uint numN)
{
    if (numM == 0) return numN + 1;
    if ((numM != 0) && (numN == 0)) return AckermanFunction(numM - 1, 1);
    return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
}

Console.Write("Введите число M: ");
uint numberM = Convert.ToUInt32(Console.ReadLine());

Console.Write("Введите число N: ");
uint numberN = Convert.ToUInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Ошибка! Введите натуральные числа.");
}
else
{
    uint ackermanFunction = AckermanFunction(numberM, numberN);
    Console.Write($"Результат = {ackermanFunction}");
}
