/*
Домашняя задача 10:
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите любое трёхзначное число");
string Number = Console.ReadLine();
Console.WriteLine($"Вторая цифра введенного Вами числа - {Number[1]}");
