//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=1 && n<=7) 
    {
    if (n==6 || n==7)
        Console.WriteLine("это выходной день");
    else
        Console.WriteLine("это рабочий день");
    }
else 
    Console.WriteLine("такого дня недели нет");