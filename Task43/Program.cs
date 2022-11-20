// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double[] IntersectionCoord(double b1, double k1, double b2, double k2)
{
    double[] coordinates = new double[2];
    coordinates[0] = (b2 - b1) / (k1 - k2);
    coordinates[1] = k1 * (coordinates[0]) + b1;

    return coordinates;
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()!);


double[] result = IntersectionCoord(b1, k1, b2, k2);

if ((k1 == k2) || (b1 == b2))
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    Console.WriteLine($"Координата пересечения двух прямых -> ({Math.Round(result[0], 1)}; {Math.Round(result[1], 1)})");
}

