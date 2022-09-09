//Задача 26: Напишите программу, которая принимает на 
//вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.WriteLine("Pls enter number: ");
int num1 = int.Parse(Console.ReadLine());
int num = Math.Abs(num1); // Число по модулю, дает возможность работать с отрицательными числами

int GetCount(int coll) // для метода нужно брать свою переменную, чтобы работать с любыми числами
{
    int count = 0;
    while (coll > 10)
    {
        coll = coll / 10;
        count++;
    }
    return count + 1;
}
Console.WriteLine($"{num1} -> {GetCount(num)}");

