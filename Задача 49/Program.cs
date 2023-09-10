/* Задача 49:
 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Дмитрий Тихонов Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Дмитрий Тихонов Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill2DArray(int[,] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
}
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void ReplaceEl(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        }
    }
}
int rows = InputNum("Введи количество строк: ");
int columns = InputNum("Введи количество столбцов: ");
int minValue = InputNum("Введи минимальное значение: ");
int maxValue = InputNum("Введи максимальное значение: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
ReplaceEl(myArray);
Console.WriteLine();
Print2DArray(myArray);