// Дано число. Проверить кратно ли оно 7 и 23
using System;

const int kratn1 = 7;  //чтобы можно было быстро и просто поменять числа
const int kratn2 = 23;

Console.Write($"Введите число, которое будем проверять на кратность числам {kratn1} и {kratn2}: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % kratn1 ==0) && (number % kratn2 ==0)) // проверяем "кратность"
{
    Console.WriteLine($"Число {number} кратно числам {kratn1} и {kratn2}");
}    
else
    if (number % kratn1 ==0)
    {
        Console.WriteLine($"Число {number} кратно числу {kratn1}");
    }
    else
        if (number % kratn2 ==0)
        {
            Console.WriteLine($"Число {number} кратно числу {kratn2}");
        }
        else
        {
            Console.WriteLine($"Число {number} не кратно числам {kratn1} и {kratn2}");
        }
