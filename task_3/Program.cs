// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = 0;
while (number < 10 || number > 99)
{
    Console.WriteLine("Введите любое положительное двузначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int firstNumber = number / 10;
int secondNumber = number % 10;

if (firstNumber >= secondNumber)
{
    Console.WriteLine($"Наибольшим числом является {firstNumber}.");
}
else
{
    Console.WriteLine($"Наибольшим числом является {secondNumber}.");
}