// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int res;

if (a > 99 && a < 1000)
{
    res = a % 10;
    Console.WriteLine($"Третья цифра числа {a} ->>> {res}");
}
else if (a >= 1000)
{   
    while (a >= 1000)
    {
        a /= 10;
    }
res = a % 10;
Console.WriteLine($"Третья цифра числа {a} ->>> {res}");
}

else
{
    Console.WriteLine("Третьего числа нет");
}