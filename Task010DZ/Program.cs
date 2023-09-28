﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if(num >= 100 && num < 1000)
{
    int a = (num % 100 - num %10)/10;
    Console.WriteLine($"Вторая цифра числа вот: {a} ");
}
else
{
    Console.WriteLine("Надо 3х-значное");
}

//---------------

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int a;
if(num >= 100 && num < 1000)
{
    a = num / 10 % 10;
    Console.WriteLine($"Вторая цифра числа вот: {a} ");
}
else
{
    Console.WriteLine("Надо 3х-значное");
}   