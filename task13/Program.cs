// Написать программу, которая позволяет выяснить, кратно ли число заданному, если нет, вывести остаток.
using System;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите число, на которое будем проверять кратность числа {number}: ");
int kratn = Convert.ToInt32(Console.ReadLine());

if (number % kratn == 0)  // Проверяем "кратность" 
{
    Console.WriteLine($"Число {number} кратно числу {kratn}");
}
else
{
    Console.Write($"Число {number} не кратно числу {kratn}. ");
    Console.WriteLine($"Остаток от деления {number} на {kratn} равен {number % kratn}");
}
