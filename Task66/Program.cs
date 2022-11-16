// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;

int RecursiveSumm(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + RecursiveSumm(m, n - 1);
    }
}
WriteLine(RecursiveSumm(6, 10));