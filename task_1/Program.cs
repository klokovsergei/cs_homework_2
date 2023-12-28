// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число, которое желаете проверить на кратность 7 и 23: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 7 == 0) && (number % 23 == 0)) Console.WriteLine($"Супер. {number} делится на 7 и на 23 нацело!");
else Console.WriteLine($"Упс. {number} НЕ делится на 7 и на 23 нацело!");
