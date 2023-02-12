// Задача №7 Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю
// цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 1000 && number > 99)
{
    int x = number % 10;
    Console.Write(x);
}
else
{
    System.Console.WriteLine("Введено не правильное число");
}
