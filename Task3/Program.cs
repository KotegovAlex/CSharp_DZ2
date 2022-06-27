/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. 
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

System.Console.WriteLine("Введите целое число => ");
long number = Math.Abs(long.Parse(Console.ReadLine()));

long result = number;

if (number < 100)
{
    System.Console.WriteLine("В заданном числе нет третьей цифры!");
}
else
{
    long count = number;
    while (count > 999)
    {
        count = count / 10;
    }
    result = count % 10;
    System.Console.WriteLine($"Третья цифра заданного числа => {result}");
}