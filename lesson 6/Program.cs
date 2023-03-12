// напишите программу, которая принимает на вход число N и выводит квадраты от 1 до N
Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("квадраты от 1 до введенного числа: ");
for (int i = 1; i <= n; i++) 
     Console.Write($"{Math.Pow(i,2)} ");
    

