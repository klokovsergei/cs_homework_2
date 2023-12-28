// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.Write("Введите любое положительное число не больше 2^63: ");
//int number = Convert.ToInt32(Console.ReadLine());
long number = Convert.ToInt64(Console.ReadLine());

string stringNumber = "";
string reversNumber = "";

while (number > 10)
{
    reversNumber = reversNumber + number % 10 + ", ";
    stringNumber = ", " + number % 10 + stringNumber;
    number = number / 10;
}
Console.WriteLine(reversNumber + number);
Console.WriteLine(number + stringNumber);