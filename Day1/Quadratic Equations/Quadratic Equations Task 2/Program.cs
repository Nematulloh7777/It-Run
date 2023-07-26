using System;
Console.WriteLine("Hello");

Console.WriteLine("Программа для решение квадратных уравнений ax^2+ bx + c = 0");

Console.Write("Вводите а: ");

int a = int.Parse(Console.ReadLine());

Console.Write("Вводите b: ");

int b = int.Parse(Console.ReadLine());

Console.Write("Вводите c: ");

int c = int.Parse(Console.ReadLine());


int result = 0;

int x = 0;

result = (int)(a * Math.Pow(x, 2) + b * x + c);

Console.WriteLine(result);