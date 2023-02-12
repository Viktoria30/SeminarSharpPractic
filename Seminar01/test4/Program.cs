// Задача №5 Напишите программу, которая на вход принимает одно число (№), а на выходе показывает 
// все целые числа промежутке от -N до N
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1); // number = -number
}
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}
