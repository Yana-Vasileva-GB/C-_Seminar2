/*
Задача 11:
Вывести случайное трехзначное число и удалить вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

/* 
1 ВАРИАНТ:

int number = new Random().Next(100,1000); // (100;999]
Console.WriteLine($"Рандомное число: {number}");
int firstDigit = number / 100;
int threeDigit = number % 10;
Console.WriteLine($"Число без второй цифры - {firstDigit}{threeDigit}");
*/

/* 
2 ВАРИАНТ:*/

string inputNumber = Console.ReadLine(); // 456
Console.WriteLine($"{inputNumber[0]}{inputNumber[2]}");

/* 
3 ВАРИАНТ:

int number = new Random().Next(100,1000); // (100;999]
int result = ((number / 100) * 10) + number % 10; // 456 -> 4, 456 % 10 -> 6
Console.WriteLine($"Исходное число: {number}, результат: {result}");
*/
