// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine()!);

NumSorted(number);

void NumSorted(int num, int count = 1)
{
    if (num != count)
    {
        SearchEvenNums(num);
        Console.Write($"{num}, ");
        NumSorted(num - 1, count);
    }
    else
    {
        Console.WriteLine($"{count}.");
    }
}

void SearchEvenNums(int num)
{
    if (num == 0)
    {
        return;
    }
    else if (num % 2 == 0)
    {
        Console.Write($"чётное: ");
    }
}