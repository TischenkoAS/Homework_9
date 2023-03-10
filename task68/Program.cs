// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите первое положительное число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе положительное число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write($"A({number},{number2}) = ");
Console.WriteLine(FuncsAkkerman(number, number2));

int FuncsAkkerman(int num, int num2)
{
    if (num == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return FuncsAkkerman(num - 1, 1);
    }
    else
    {
        return FuncsAkkerman(num - 1, FuncsAkkerman(num, num2 - 1));
    }
}