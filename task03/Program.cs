﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n%2==0)
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");
