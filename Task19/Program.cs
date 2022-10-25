// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palendrome(int number)
{
    int fnum = number / 1000;
    int snum = number / 1000 % 10;
    int lnum = number % 10;
    int pnum = number % 100 / 10;

    return fnum == lnum || snum == pnum;
}

Console.WriteLine("Введите пятизначное число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num > 9999 && num < 100000) Console.WriteLine(Palendrome(num) ? "Да" : "Нет");
else Console.WriteLine("Некоректное число!");