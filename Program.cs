//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введи число : ");
int a = Convert.ToInt16(Console.Read());

if (a % 2 == 0) 
{
    Console.WriteLine("Четное");
}
else 
Console.WriteLine("Нечетное");