/* Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. */

int number = new Random().Next(100, 999);
int resnumber = (number/100)*10 + number%10;

System.Console.WriteLine($"Случайное число: {number}");
System.Console.WriteLine($"Итоговое число: {resnumber}");