// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void SetArray(int[] home)
{
    int length = home.Length;
    int index = 0;
    while (index < length - 1)
    {
        home[index] = new Random().Next(1, 8);
        Console.Write($"{home[index]}, ");
        index++;
    }
    Console.Write($"{home[index]} ->");
}

void PrintArray(int[] today)
{
    int length = today.Length;
    int count = 0;
    Console.Write(" [");
    while (count < length - 1)
    {
        Console.Write($"{today[count]}, ");
        count++;
    }
    Console.Write($"{today[count]}]");
}

int[] array = new int[8];

SetArray(array);
PrintArray(array);
