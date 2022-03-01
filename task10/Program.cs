﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
using System;

Console.Write("Введите трехзначное число (от 100 до 999): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>99 && number<1000)
{
    number /= 10;  // Отбрасываем самую правую цифру числа
    number %= 10;  // Отсекаем самую левую цифру числа

    Console.WriteLine($"Вторая цифра введенного числа: {number}");
}
else
{
    Console.WriteLine("Введено неверное число!");
}
