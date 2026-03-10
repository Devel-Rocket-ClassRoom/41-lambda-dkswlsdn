using System;


int[] numbers = { 10, 25, 7, 42, 18, 33 };

Console.Write($"배열: ");

for (int i = 0; i < numbers.Length; i++) 
{
    if (i != 0)
    {
        Console.Write(", ");
    }

    Console.Write(numbers[i]);
}

Console.WriteLine();

Console.WriteLine($"합계: {ProcessArray(numbers, num => { int sum = 0; for (int i = 0; i < num.Length; i++) sum += num[i]; return sum; })}");
Console.WriteLine($"최댓값: {ProcessArray(numbers, num => { int max = int.MinValue; foreach (var n in num) if (n > max) max = n; return max; })}");
Console.WriteLine($"최솟값: {ProcessArray(numbers, num => { int min = int.MaxValue; foreach (var n in num) if (n < min) min = n; return min; })}");
Console.WriteLine($"짝수 개수: {ProcessArray(numbers, num => { int count = 0; foreach (int n in num) if (n % 2 == 0) count++; return count; })}");


int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}