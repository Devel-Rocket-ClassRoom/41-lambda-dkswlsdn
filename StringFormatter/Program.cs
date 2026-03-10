using System;
using System.Runtime.Serialization;


Func<string, string> toUpper = value => value.ToUpper();
Func<string, string> mask = value => $"{value[0]}{value[1]}***";
Func<string, string> greet = value => $"안녕하세요, {value}님!";


Console.Write("[대문자 변환] hello world -> ");
ApplyAndPrint("hello world", toUpper);
Console.Write("[마스킹 처리] SecretCode -> ");
ApplyAndPrint("SecretCode", mask);
Console.Write("[인사말 생성] 민수 -> ");
ApplyAndPrint("민수", greet);


void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}