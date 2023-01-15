// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CountNumbers(int x, int y)
{
    if(Math.Max(x,y) != Math.Min(x,y))
        return CountNumbers(Math.Max(x,y),Math.Min(x,y)+1) + Math.Min(x,y);
    else return Math.Max(x,y);
}

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int numb = CountNumbers(n,m);
Console.WriteLine($"Сумма чисел между M и N: {numb}");
