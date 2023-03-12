// Задача 69: Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadInt(string prompt)
{
    Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int RecursionPower(int a, int b)
{
    if (b == 0) return 1;
    return a * RecursionPower(a, b - 1);
}

Console.WriteLine(RecursionPower(ReadInt("Введите число А:"), ReadInt("Введите число Б:")));
