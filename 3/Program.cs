﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int c = 1;
while (c<=n)
{
Console.WriteLine(c*c*c);
c++;
}