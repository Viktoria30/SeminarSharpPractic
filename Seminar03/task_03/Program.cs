// Напишите программу, которая на вход принимает координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21
// массив вводим при помощи строки

int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

for(int i = 0; i < arr.Length; i++)
{
    System.Console.WriteLine(arr[i] + " ");
}
