// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }

}
else
{
    if (b > c)
    {
        Console.WriteLine("Максимальное число: " + b);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }

}
