// Задача 10. Напишите программу , которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

int SecondNum(int number)
{
    int number1 = number % 100;
    return number1 / 10;
}
Console.WriteLine("Введите ТРЕХзначное число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num < 100 || num > 999) Console.WriteLine("Трехзначное - это ТРИ цифры) ");
else Console.WriteLine(SecondNum(num));