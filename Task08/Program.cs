Console.Write("Введите число N ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1) 
    Console.WriteLine("неправильное число. Введите число > 0");
else
{
    int count = 2;

    while (count <= num)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}