using System.Runtime.InteropServices;
/*
string[] weekDays = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];
for(int i = 0; i<weekDays.Length;i++)
{
    int a = i + 1;
    Console.WriteLine(a + ". " +weekDays[i]);
}
foreach(string day in weekDays)
{
    Console.WriteLine(day);
}

int[] num = {1, 2, 3, 4, 5};
foreach (int number in num)
{
    Console.WriteLine(number);
}

int[] num = {1, 2, 3, 4, 5};
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}

int[,] num2 = {{1, 2}, {3, 4}, {5, 6}};
Console.Write(num2 [0, 1] + " ");
Console.Write(num2 [1, 1] + " ");
Console.Write(num2 [2, 0] + " ");

foreach (int number in num2)
{
    Console.Write($"{number} ");
}*/

int[,,] tre = new int [,,] {{{1, 2, 3}, {4, 5, 6}}, {{7, 8, 9}, {10, 11, 12}}};
for (int i = 0; i < tre.GetLength(0); i++)
{
    for (int j = 0; j < tre.GetLength(1); j++)
    {
        for (int k = 0; k < tre.GetLength(2); k++)
        {
            Console.Write($"{tre[i, j, k]} ");
        }
        Console.WriteLine();
    }    
}
