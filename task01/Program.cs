// See https://aka.ms/new-console-template for more information
Console.Write("введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n1>n2)
    Console.WriteLine($"максимальное число {max=n1}");
else if (n2>n1)
    Console.WriteLine($"максимальное число {max=n2}");
else Console.Write("числа равны");