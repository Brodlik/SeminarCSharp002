// Задача 9. Программа выводит случайное число на экран в отрезке от [10; 99] и показывает наибольшую цифру числа.
//78->8
//12->2
//85->8

int number = new Random ().Next (10,100);
Console.WriteLine($"Наше случайное число = {number}");

int digit1 = number/10;
int digit2 = number%10;
if (digit1 > digit2)
{
    Console.WriteLine ($"Цифра {digit1} наибольшая");
}
else
{
    Console.WriteLine ($"Цифра {digit2} наибольшая");
}