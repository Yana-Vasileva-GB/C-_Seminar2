/*
Домашняя задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите любое число");
string Number = Console.ReadLine();
int len;
len = Number.Length;
if (len > 2)
    {
    Console.WriteLine($"Третья цифра в Вашем числе - это {Number[2]}");
    }
else
    Console.WriteLine("Третьей цифры в числе нет");
