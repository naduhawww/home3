//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
ArrayCreation(array);


void ArrayCreation(int[] numbers)
 {
 for(int index = 0; index < numbers.Length; index++)
     {
 numbers[index] = new Random().Next(0,9); 
 Console.Write(numbers[index] + ", ");

     }
 }