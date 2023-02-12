//  Напишите программу, которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа.
//  456 -> 46
//  782 -> 72
//  918 -> 98

Random rand = new Random();
int RandomN = rand.Next(100, 1000);

System.Console.WriteLine(RandomN);

// int leftN = RandomN / 100;
// int rightN = RandomN % 10;
// System.Console.WriteLine(leftN + "" + rightN);

int leftN = RandomN / 100 * 10;
int rightN = RandomN % 10;
int sum = leftN + rightN;
System.Console.WriteLine(sum);