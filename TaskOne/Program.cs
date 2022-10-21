// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(number / 10 % 10);