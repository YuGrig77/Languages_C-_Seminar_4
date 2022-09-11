// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Pls enter number: ");
int num = int.Parse(Console.ReadLine());
int num1 = Math.Abs(num);

int NumDigitsSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        //Console.WriteLine(sum);
        number = number / 10;
        //Console.WriteLine(number);
    }
    return sum;
}
Console.WriteLine($"{num} -> {NumDigitsSum(num1)}");
