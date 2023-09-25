//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе чтсло кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
Console.WriteLine("Кратно");
} 
else {
    Console.WriteLine(a % b);
}