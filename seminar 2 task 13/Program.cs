// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(n);
int numIndex = numStr.Length;
if (numIndex > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
else Console.WriteLine("третьей цифры нет");