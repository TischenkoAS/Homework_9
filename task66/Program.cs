// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

NumSorted(number, number2);

int NumSorted(int num, int num2, int sum = 0)
{
    if (num != num2)
    {
        NumSorted(num + 1, num2, sum + num);           
    }
    else
    {
        sum = sum + num2;
        Console.WriteLine();
        Console.WriteLine($"{sum}");
    }
    return sum;
}