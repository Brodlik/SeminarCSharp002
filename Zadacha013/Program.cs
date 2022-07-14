// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите число N: ");
int N = Convert.ToInt32 (Console.ReadLine());

if (N>=10&&N<=99)
{
    Console.WriteLine ("Третьей цифры нет");   
}
else if (N>=100&&N<=999)
{
    int digit3 = N%10;
    Console.WriteLine ($"Третья и одновременно последняя цифра числа = {digit3}");
}
else if (N>=1000&&N<=9999)
{
    int digit4 = N%100/10;
    Console.WriteLine ($"Третья, но не последняя = {digit4}");
}
else if (N>=10000&&N<=99999)
{
    int digit5 = N%1000/100;
    Console.WriteLine ($"Третья, но не последняя = {digit5}");
}
else if (N>=100000)
{
    Console.WriteLine ("Число слишком большое");
}