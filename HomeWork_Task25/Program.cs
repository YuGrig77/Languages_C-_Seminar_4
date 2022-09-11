// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Pls enter A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Pls enter B: ");
int b = int.Parse(Console.ReadLine());

int RaiseToPower(int first, int second)
{
    int result = 0;
    result = (int)Math.Pow(first, second);
    return result;
}
Console.WriteLine($"{a}, {b} => {RaiseToPower(a, b)}");
