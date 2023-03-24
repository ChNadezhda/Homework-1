// Напишите программу, которая на вход принимает два числа
// и выдает, какое число большее, а какое меньшее

int a = 0;
int b = 0;

Console.WriteLine("Введите два числа: ");


if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
    if (a > b)
    {
        Console.WriteLine("Наибольшее число: " + a);
        Console.WriteLine("Наименьшее число: " + b);
    }

    else
    {
        Console.WriteLine("Наибольшее число: " + b);
        Console.WriteLine("Наименьшее число: " + a);
        
    }
}