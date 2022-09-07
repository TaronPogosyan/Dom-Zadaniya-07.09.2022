// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

void ShowNumbers(int a, int b, int sum)
{

    if (a > b)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + a++;
    ShowNumbers(a, b, sum);
}
ShowNumbers(m, n, 0);