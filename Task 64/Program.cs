// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

// 45 -> 101101
// 3  -> 11
// 2  -> 10

string BinarySystem (int num)
{
    if (num != 0)
    {
        return BinarySystem(num/2) + num % 2;
    }
    else return "";
}

System.Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
string answer = BinarySystem(m);
Console.Write($"Результирующее двоичное число: {answer}");