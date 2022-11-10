// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberSum(int num)
{
    int sum = 0;
    int last = 0;
    while (num > 0)
    {
        last = num % 10;
        sum += last;
        num /=10;
    }
    return sum;
}
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbersum = NumberSum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {numbersum}");