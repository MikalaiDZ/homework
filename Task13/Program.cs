//Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int ThirdNumber(int number)
{
    while (number > 1000)
    {
        number = number /10;
    }
    return number % 10 ;
}

Console.WriteLine("Введите число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num < 100) Console.WriteLine("Третьей цифры нет!");
else Console.WriteLine($"Третья цифра числа  = {ThirdNumber(num)}");