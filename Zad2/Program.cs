﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11   82 -> 10  9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int intermediateDigit = number % 10;
    number /= 10;
    sum = sum + intermediateDigit;
}

Console.WriteLine("Сумма всех чисел в числе равна: " + sum);