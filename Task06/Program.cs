﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    System.Console.WriteLine("Число: " + a + " четное");
}
else
{
    System.Console.WriteLine("Число: " + a + " нечетное");
}