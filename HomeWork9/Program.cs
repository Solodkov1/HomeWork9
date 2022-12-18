/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNaturalNambers(int n)
{
    if (n > 0)
    {
        Console.Write(n+" ");
        ShowNaturalNambers(n-1);
    }
}
Console.Write("$input number N = ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturalNambers(n);

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int FindSummNaturalNumbers ( int n, int m)
{   
    if(n > m)
    {
       return FindSummNaturalNumbers(n-1, m) + n;
    }
    if (n < m) 
    {
        Console.Write($"rong numbers {n} < ");
        return m;
    }
    else 
    {
       return n;
    }
}

Console.Write("input number M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number N = ");
int n = Convert.ToInt32(Console.ReadLine());
int num = FindSummNaturalNumbers(n, m);
Console.WriteLine(num);
*/
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int A (int n, int m)
{
    if (n == 0)
    return m + 1;
    else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
Console.Write("input number m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number n = ");
int n = Convert.ToInt32(Console.ReadLine());
int NumberA = A(m, n);
Console.WriteLine(NumberA);