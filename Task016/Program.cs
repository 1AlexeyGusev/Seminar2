// //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.WriteLine("Введите число а: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a == b*b)
// {
//     Console.WriteLine($"Число {a} является квадратом числа {b}");
// }
// else
// {
//     Console.WriteLine($"Число {a} не является квадратом числа {b}");
// }

//---------------------------------------

Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a == b*b || b == a*a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}