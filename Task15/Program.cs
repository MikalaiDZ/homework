//Задача 15. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли это день выходным.

bool Week(int number)
{
    return number == 6 || number == 7;
}

Console.WriteLine("Введите номер дня недели ");
int num = (Convert.ToInt32(Console.ReadLine()));

if (num < 1 || num > 7) Console.WriteLine("Невернный номер!");
else Console.WriteLine(Week(num) ? "Да" : "Нет");