{
    Console.WriteLine("Task 19");
    Console.WriteLine("введите пятизначное число: ");

    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 999 && number < 100000)
    {
        int digit1 = number / 10000;
        int digit2 = (number / 1000) % 10;
        int digit4 = (number / 10) % 10;
        int digit5 = (number % 10);

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("Это не пятизначное чисо");
    }
}


{
    Console.WriteLine("Task 21");
    Console.WriteLine("введите кардинату первой точки X, Y, Z: ");
    int Xa = Convert.ToInt32(Console.ReadLine());
    int Ya = Convert.ToInt32(Console.ReadLine());
    int Za = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кардинату второй точки X, Y, Z: ");
    int Xb = Convert.ToInt32(Console.ReadLine());
    int Yb = Convert.ToInt32(Console.ReadLine());
    int Zb = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
    Console.WriteLine($"{result:f2}");
}


{
    Console.WriteLine("Task 23");
    Console.WriteLine("введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < N; i++)
    {
        int result = Convert.ToInt32(Math.Pow(i, 3));
        Console.WriteLine(result);
    }
}
