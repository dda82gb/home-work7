// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("введите номер строки");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = int.Parse(Console.ReadLine());
int [,] numbers = new int [4,5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[{n},{m}]--> по такому идексу нет элемента.");
}
else
{   
      Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"значение элемента {n} строки и {m} столбца = {numbers[n-1,m-1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
       
        Console.WriteLine(" "); 
    }
}