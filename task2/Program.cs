/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        n += SumNum(m, n - 1);
    }
    return n;
}

int m = InputNum("Enter the number M: ");
int n = InputNum("Enter the number N: ");
Console.Write($"Sum of numbers from {m} to {n} = {SumNum(m, n)}");