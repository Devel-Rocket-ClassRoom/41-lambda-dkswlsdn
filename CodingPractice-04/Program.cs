using System;
using System.Collections.Generic;

{
    Console.WriteLine("\n========================");

    Action[] actions = new Action[3];

    for (int i = 0; i < 3; i++)
    {
        actions[i] = () => Console.Write(i);
    }

    foreach (Action action in actions)
    {
        action();
    }

    Console.WriteLine();
}

{
    Console.WriteLine("\n========================");

    Action[] actions = new Action[3];

    for (int i = 0; i < actions.Length; i++)
    {
        int loopVar = i;
        actions[i] = () => Console.Write(loopVar);
    }

    foreach (Action action in actions)
    {
        action();
    }

    Console.WriteLine();
}

{
    Console.WriteLine("\n========================");

    string[] names = { "김철수", "이영희", "박민수", "최지연" };


    Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));

    Console.WriteLine("이름 길이순 정렬:");

    foreach (string name in names)
    {
        Console.WriteLine(name); 
    }

    Console.WriteLine();


    Array.Sort(names, (a, b) => b.CompareTo(a));

    Console.WriteLine("역순 정렬:");

    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

{
    Console.WriteLine("\n========================");

    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine($"첫번째 짝수: {numbers.Find(i => i % 2 == 0)}");
    Console.WriteLine($"모든 짝수: {string.Join(", ", numbers.FindAll(i => i % 2 == 0))}");
    Console.WriteLine($"8보다 큰 수 존재: {numbers.Exists(i => i > 8)}");
    Console.WriteLine($"모두 양수: {numbers.TrueForAll(i => i > 0)}");
    Console.WriteLine($"제거된 짝수 개수: {numbers.RemoveAll(i => i % 2 == 0)}");
    Console.Write($"남은 숫자: {string.Join(", ", numbers)}");
}

Console.WriteLine();