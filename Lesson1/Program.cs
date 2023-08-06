// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Recursia(int end, int start)
{
    if (end < start)
    {
        Console.Write((start) + ", ");
        start--;
        return Recursia(end, start);
    }
    return start;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите предел N: ");
Console.WriteLine($"{Recursia(1, n)}");
