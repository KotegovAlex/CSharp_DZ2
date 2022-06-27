/* Задача 4: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. 
6 -> да 
7 -> да 
1 -> нет*/

System.Console.WriteLine("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());

switch (daynumber)
{

    case 1:
        Console.WriteLine("Понедельник - это не выходной");
        break;
    case 2:
        Console.WriteLine("Вторник - это не выходной");
        break;
    case 3:
        Console.WriteLine("Среда - это маленькая пятница, но еще не выходной");
        break;
    case 4:
        Console.WriteLine("Четверг - это большая пятница, но еще не выходной");
        break;
    case 5:
        Console.WriteLine("Пятница - это маленькая суббота, но ещё не выходной");
        break;
    case 6:
        Console.WriteLine("Суббота - это выходной!!!");
        break;
    case 7:
        Console.WriteLine("Воскресенье - это выходной!!!");
        break;
    default:
        Console.WriteLine("Дня недели с таким номером не существует");
        break;
}