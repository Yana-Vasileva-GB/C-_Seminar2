/*
Задача 11:
Вывести случайное трехзначное число и удалить вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100,999);
Console.WriteLine($"Рандомное число: {number}");
int firstDigit = number / 100;
int threeDigit = number % 10;
Console.WriteLine($"Число без второй цифры - {firstDigit}{threeDigit}");