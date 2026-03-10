using System;

{
    Console.WriteLine("\n========================");

    PrintMessage printMessage = () => Console.WriteLine("안녕하세요.");

    printMessage();
}

{
    Console.WriteLine("\n========================");

    Transformer square = x => x * x;

    Console.WriteLine(square(3));
    Console.WriteLine(square(4));
}

{
    Console.WriteLine("\n========================");

    IsLonger isLong = (string msg, int len) => msg.Length > len;

    Console.WriteLine(isLong("안녕하세요.", 5));
    Console.WriteLine(isLong("반갑습니다.", 10));
}

{
    Console.WriteLine("\n========================");

    Greeting greeting = () =>
    {
        Console.WriteLine("안녕하세요.");
        Console.WriteLine("반갑습니다.");
    };

    greeting();
}

{
    Console.WriteLine("\n========================");

    Calculator calculator = (a, b) =>
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        return a + b;
    };

    int sum = calculator(3, 5);
    Console.WriteLine($"합계: {sum}");
}

delegate void PrintMessage();
delegate int Transformer(int i);
delegate bool IsLonger(string str, int i);
delegate void Greeting();
delegate int Calculator(int a, int b);