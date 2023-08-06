// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int m, int n)
{
    if (n == m) return m;
    return m + Summ(m + 1, n);

}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите начало предела M: ");
int n = GetInput("Введите конец предела N: ");
Console.WriteLine($"{Summ(m, n)}");