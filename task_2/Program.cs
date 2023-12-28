// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Программа для определения координатной четверти.");

Console.Write("Введите первую координату отличную от 0: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату отличную от 0: ");
int y = Convert.ToInt32(Console.ReadLine());

switch ((x,y))
{
    case (< 0, > 0):
        Console.WriteLine("Введенные координаты указываю на ПЕРВУЮ четверть.");
        break;
    
    case ():


    case ():


    default:
        Console.WriteLine();
        break;
}