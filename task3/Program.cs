/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FunAck(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        n = FunAck(m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = FunAck(m, n - 1);
        n = FunAck(m - 1, n);
    }
    return n;
}

int m = InputNum("Enter the number M: ");
int n = InputNum("Enter the number N: ");
Console.WriteLine($"A ({m}, {n}) = {FunAck(m, n)}");