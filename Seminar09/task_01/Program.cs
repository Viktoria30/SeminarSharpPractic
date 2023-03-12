// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int ReadInt(string prompt)
{
    Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
    if (num == 0) return;
    Console.Write(num + " ");
    WriteNumbers(num - 1);
}

WriteNumbers(ReadInt("Введите число: "));
