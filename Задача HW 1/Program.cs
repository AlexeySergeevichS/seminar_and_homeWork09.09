/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

Также, задайте метод PrintArray, который выводил бы массив на экран. */
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// double[,] Create2DArray(int rows, int columns)
// {
//     return new double[rows, columns];
// }
double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m ; i++)
    {
        for (int j = 0; j < n ; j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(minLimitRandom, maxLimitRandom + 1) + rnd.NextDouble(), 1);
        }
    }
    return matrix;
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 3;
int n = 4;
int minLR = -10;
int maxLR = 10;
double[,] array = CreateRandomMatrix(m, n, minLR, maxLR);
PrintArray(array);