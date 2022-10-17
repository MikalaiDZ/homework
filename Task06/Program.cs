Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if ( num % 2 == 0) Console.WriteLine($"Число {num} - четное");
else Console.WriteLine("Число не является четным");