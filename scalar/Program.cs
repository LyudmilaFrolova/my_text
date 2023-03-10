// Напишите программу скалярного произведения двух векторов
void FillArray1(int[] Vector1) // метод заполнения первого вектора случайными числами от 1 до 10
{

    int lenght1 = Vector1.Length;
    int i1 = 0;
    while (i1<lenght1)
    {
        Vector1[i1]=new Random().Next(1,10);
        i1++;
    }
}

void FillArray2(int[] Vector2) // метод заполнения второго вектора случайными числами от 1 до 10
{

    int lenght2 = Vector2.Length;
    int i2 = 0;
    while (i2<lenght2)
    {
        Vector2[i2]=new Random().Next(1,10);
        i2++;
    }
}

void PrintArray1(int[] Vect1) // вывод на печать элементов первого вектора
{

    int size1 = Vect1.Length;
    int index1 = 0;
    Console.WriteLine("Вектор 1: ");
    while (index1<size1)
    {
        Console.Write($"{Vect1[index1]} ");
        index1++;
    }
}

void PrintArray2(int[] Vect2) // вывод на печать элементов второго вектора
{

    int size2 = Vect2.Length;
    int index2 = 0;
    Console.WriteLine("Вектор 2: ");
    while (index2<size2)
    {
        Console.Write($"{Vect2[index2]} ");
        index2++;
    }
}


int [] FirstVector = new int[10];
int [] SecondVector = new int[10];

FillArray1(FirstVector);
PrintArray1(FirstVector);
Console.WriteLine("");

FillArray2(SecondVector);
PrintArray2(SecondVector);
Console.WriteLine("");

int scalar = 0;
int index = 0;
while (index<FirstVector.Length)
    {
        scalar=scalar+FirstVector[index]*SecondVector[index];
        index++;
    }
Console.WriteLine($"Скалярное произведение векторов равно: {scalar}");