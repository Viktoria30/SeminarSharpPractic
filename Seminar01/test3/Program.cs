﻿// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.Write("Введите номер дня недели ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (a == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (a == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (a == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (a == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (a == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (a == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня недели не существует");
// }
Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day){
    case 1:{
        System.Console.WriteLine("Понедельник");
        break;
    }
    case 2:{
        System.Console.WriteLine("Вторник");
        break;
    }
    case 3:{
        System.Console.WriteLine("Среда");
        break;
    }
    case 4:{
        System.Console.WriteLine("Четверг");
        break;
    }
     case 5:{
        System.Console.WriteLine("Пятница");
        break;
    }
    case 6:{
        System.Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        System.Console.WriteLine("Воскресенье");
        break;
    }
    default:
    {
        System.Console.WriteLine("Такого дня недели не существует");
        break;
    }
}