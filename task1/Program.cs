/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. 
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumRev(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        Console.Write($"{num}, ");
        num = NumRev(num - 1);
    }
    return num;
}

int n = InputNum("Enter the number N: ");
Console.WriteLine(NumRev(n));