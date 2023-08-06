// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkermana(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkermana(n - 1, 1);
    if (n > 0 && m > 0) return Akkermana(n - 1, Akkermana(n, m - 1));
    return Akkermana(n, m);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите начало предела M: ");
int m = GetInput("Введите конец предела N: ");
Akkermana(n, m);
Console.WriteLine($"{Akkermana(n, m)}");
