using System;
Console.WriteLine("Hello");

Console.WriteLine("Программа для решение квадратных уравнений ax^2+ bx + c = 0");

Console.Write("Вводите а: ");

double a = double.Parse(Console.ReadLine());

Console.Write("Вводите b: ");

double b = double.Parse(Console.ReadLine());

Console.Write("Вводите c: ");

double c = double.Parse(Console.ReadLine());

double discriminant = b * b - 4 * a * c;

Console.WriteLine($"Дискриминант: {discriminant}");


if (discriminant > 0)
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}

else if (discriminant == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Уравнение имеет один корень: x = {x}");
}
else
{
    Console.WriteLine("Уравнение не имеет действительных корней");
}