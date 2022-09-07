// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

int FunAkkerman(int m, int n)
{
    if (m > 0 && n > 0) return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
    if (m != 0 && n == 0) return FunAkkerman(m - 1, 1);
    if (m == 0) return n + 1;
    return FunAkkerman(m, n);
}
int result = FunAkkerman(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {result}");