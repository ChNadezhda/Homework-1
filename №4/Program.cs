// Напишите программу, которая на вход принимает число
// а на выходе показывает все четные числа от 1 до N
// 5 => 2, 4

int a = 0;
int N = 1;

Console.WriteLine("Введите число: ");

if (int.TryParse(Console.ReadLine(), out a))
{
    while (N <= a)
    {
        if (N % 2 == 0)
        {
            Console.Write(N + " ");
        }

        N = N + 1;

    }

}