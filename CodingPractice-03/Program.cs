using System;
using System.Collections.Generic;

{
    Console.WriteLine("\n========================");

    List<int> mult_3 = FindNumbers((i) => i % 3 == 0);
    List<int> sq = FindNumbers((i) => i == (int)Math.Sqrt(i) * (int)Math.Sqrt(i));


    Console.WriteLine("3의 배수:");
    
    foreach (int i in mult_3)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine("\n제곱수: ");

    foreach (int i in sq)
    {
        Console.Write($"{i} ");
    }


    static List<int> FindNumbers(Predicate<int> predicate)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            if (predicate(i))
            {
                list.Add(i);
            }
        }
        
        return list;
    }
}

{
    Console.WriteLine("\n========================");

    Predicate<int> isEven = i => i % 2 == 0;
    Predicate<int> isOdd = i => i % 2 == 1;

    Console.WriteLine(isEven(4));
    Console.WriteLine(isOdd(4));
}

{
    Console.WriteLine("\n========================");

    int factor = 2;

    Func<int, int> multiplier = n => n * factor;

    Console.WriteLine(multiplier(3));

    factor = 10;

    Console.WriteLine(multiplier(3));
}

{
    Console.WriteLine("\n========================");

    int count = 0;

    Action increment = () => count++;

    increment();
    increment();
    increment();

    Console.WriteLine(count);
}

{
    Console.WriteLine("\n========================");

    Func<int> counter = CreateCounter();

    Console.WriteLine(counter());
    Console.WriteLine(counter());
    Console.WriteLine(counter());

    static Func<int> CreateCounter()
    {
        int count = 0;
        return () => count++;
    }
}