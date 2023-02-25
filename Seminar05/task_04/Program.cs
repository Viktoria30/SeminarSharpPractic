﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountElements(int[] array, int leftRange, int rightRange)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= leftRange && array[i] <= rightRange)
        { count++; }
    }
    return count;
}

var myArray = GenArray(20, -100, 100);
PrintArray(myArray); Console.WriteLine(CountElements(myArray, 1, 100));
