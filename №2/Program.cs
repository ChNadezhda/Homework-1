// Напишите программу, которая принимает на вход три числа
// И выдает максимальное из этих чисел

int a = 0;
int b = 0;
int c = 0;

Console.WriteLine("Введите три числа: ");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b)
 && int.TryParse(Console.ReadLine(), out c)) 
{

    if (a > b && a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }

    else if (b > a && b > c)
    {
        Console.WriteLine("Максимальное число: " + b);
    }

    else if (c > a && c > b)
    {
        Console.WriteLine("Максимальное число: " + c);
    }

 }
 