/* Задача 48:
 Задайте двумерный массив размера m на n, 
 каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
 Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 
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
void Fill2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
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
int rows=InputNum("Введи количество строк: ");
int columns=InputNum("Введи количество столбцов: ");
int[,] myArray=Create2DArray(rows,columns);
Fill2DArray(myArray);
Print2DArray(myArray);