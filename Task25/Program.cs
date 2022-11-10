// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int num1, int num2)
{
    int exp = 1;

    for (int i = 1; i <= num2; i++)
    {
        exp *= num1;
    }
    return exp;
}

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

int exponentiation = Math.Abs(Exponentiation(a, b));
if (b > 0)
    if (a < 0) Console.WriteLine($"Число {a} в степени {b} = -{exponentiation}");
    else Console.WriteLine($"Число {a} в степени {b} = {exponentiation}");
else Console.WriteLine("Степень числа должна быть натуральной!");
