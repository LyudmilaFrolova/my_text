
int count=0;
Console.Write("введите начальное расстояние между друзьями: ");
int distance=Convert.ToInt32(Console.ReadLine());
Console.Write("введите скорость первого друга: ");
int FirstFriendSpeed=Convert.ToInt32(Console.ReadLine());
Console.Write("введите скорость второго друга: ");
int SecondFriendSpeed=Convert.ToInt32(Console.ReadLine());
Console.Write("введите скорость собаки: ");
int DogSpeed=Convert.ToInt32(Console.ReadLine());
int Friend=2;
int time=0;
while (distance>10)
    {
        if (Friend==1) 
        {
            time=distance/(SecondFriendSpeed+DogSpeed);
            Friend=2;
        }
        else
        {
            time=distance/(FirstFriendSpeed+DogSpeed);
            Friend=1;
        }
        distance=distance-(FirstFriendSpeed+SecondFriendSpeed)*time;
        count++;
    }
    Console.WriteLine($"собака пробежала {count} раз");