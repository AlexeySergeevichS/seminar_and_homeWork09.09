/* Задача 51:
 Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
int SumMainDiag(int[,] arr)
{
    int sum = 0;
    //  int minLength = arr.GetLength(0);
    //  if (arr.GetLength(1) < minLength) minLength = arr.GetLength(1);
    int minLength = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
    for (int i = 0; i < minLength; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}
int rows = InputNum("Введи количество строк: ");
int columns = InputNum("Введи количество столбцов: ");
int minValue = InputNum("Введи минимальный элемент: ");
int maxValue = InputNum("Введи максимальный элемент: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
System.Console.WriteLine($"Сумма элементов главной диагонали: {SumMainDiag(myArray)}");
