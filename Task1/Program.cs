// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNumber(num)}");
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNumber(num2)}");

int GetSumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        Console.WriteLine(number);
        number--;
    }
    return sum;
}