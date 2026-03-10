using System;

{
    Console.WriteLine("\n========================");

    Func<int> func1 = () => 1234;
    Func<int, int> func2 = (a) => a * a;
    Func<int, int, int> func3 = (a, b) => a + b;

    Console.WriteLine(func1());
    Console.WriteLine(func2(3));
    Console.WriteLine(func3(3, 5));
}

{
    Console.WriteLine("\n========================");

    Action greet = () => Console.WriteLine("안녕하세요!");
    Action<string> printer = (msg) => Console.WriteLine(msg);
    Action<string, int> repeat = (msg, count) => { for (int i = 0; i < count; i++) Console.WriteLine(msg); };

    greet();
    printer("Hello, Lambda!");
    repeat("반복!", 3);
}

{
    Console.WriteLine("\n========================");

    Func<int, int> anonymous = delegate (int x) { return x * x; };
    Func<int, int> lambda = x => x * x;

    Console.WriteLine(anonymous(2));
    Console.WriteLine(lambda(2));
}