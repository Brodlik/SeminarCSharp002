﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите трехзначное число: ");
int N = Convert.ToInt32 (Console.ReadLine());

if (N>=100 && N<=999)
{
    int digit2=N/10%10;
    Console.WriteLine ($"Вторая цифра цисла = {digit2}");
}