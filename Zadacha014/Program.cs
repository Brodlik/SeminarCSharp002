﻿// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N%7==0 && N%23==0)
{
    Console.WriteLine($"Да, число {N} кратно и 7 и 23 одновременно ");
}
else
{
    Console.WriteLine($"Нет, число {N} не кратно и 7 и 23 одновременно ");
}