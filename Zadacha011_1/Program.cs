// Задача 11_1. Напишите программу, которая разбивает число на отдельные цифры
// 456 -> 4 5 6
// 782 -> 7 8 2
// 918 -> 9 1 8

int number = new Random ().Next (100,1000);
Console.WriteLine($"Наше случайное число = {number}");

int digit1=number/100;
Console.WriteLine($"Цифра1 = {digit1}");
int digit2 = number/10%10;
Console.WriteLine($"Цифра2 = {digit2}");
int digit3 = number%10;
Console.WriteLine($"Цифра3 = {digit3}");
