﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.WriteLine(" введите число А...");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" введите число B...");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;
for (int i = 1; i < b; i++)
{
    degree = degree * a;
}
System.Console.WriteLine("А в степени В равно:" + degree);