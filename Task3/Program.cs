// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт произведение 
// чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();

Console.WriteLine("Pls enter number: ");
int num = int.Parse(Console.ReadLine());

int Factorial(int fact) 
{
    int count = fact;
    while (count > 1)
    {
        count--;
        fact *= count;
    }
    return fact;
}
Console.WriteLine($"{num} -> {Factorial(num)}");
