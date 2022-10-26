// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return dis;
}

Console.Write("Введите координату X точки А-> ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А-> ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А-> ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки B-> ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B-> ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B-> ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Растояние между точками А и В = {Math.Round(distance, 2, MidpointRounding.ToZero)}");