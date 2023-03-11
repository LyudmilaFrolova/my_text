
Console.WriteLine("введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
double x = n1/n2;
if (n1%n2==0)
    Console.WriteLine("кратно");    
else 
    Console.WriteLine($"остаток {n1%n2}");


