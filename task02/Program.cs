// напишите программу которая берет на ввод три числа и выводит максимальное значение
Console.WriteLine("Введите три числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if (n1>max) max=n1;
if (n2>max) max=n2;
if (n3>max) max=n3;
Console.WriteLine($"максимальное число равно: {max}");
