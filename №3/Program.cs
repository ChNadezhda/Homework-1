// Напишите программу, которая на вход принимает число
// и выдает, является ли это число четным
// (делится ли оно на два без остатка)

int a = 0;

Console.WriteLine("Введите число: ");

if (int.TryParse(Console.ReadLine(), out a))
{
    if (a % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }

    else
    {
        Console.WriteLine("Число нечетное");
    }
}