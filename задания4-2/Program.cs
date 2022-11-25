//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.WriteLine(" введите число...");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (number > 0)
{
    int count = number % 10;
    number = number / 10;
    summ = summ + count;
}
System.Console.WriteLine(" сумма чисел равна:" + summ);