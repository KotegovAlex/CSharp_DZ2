/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */

System.Console.WriteLine("Введите трехзначное число => ");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{
    System.Console.WriteLine("Задано число не удовлетворяющее условиям задачи!!!");
}
else
{
    System.Console.WriteLine($"Вторая цифра числа => {(number % 100) / 10}");
}