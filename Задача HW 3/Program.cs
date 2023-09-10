/* Внутри класса Answer напишите методы 
CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом 
увеличивающимся на опрделенное число. 
Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает
одномерный массив типа double. Этот метод вычисляет 
среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns 
и выводит этот список на экран в формате
 "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, 
округленные до двух знаков после запятой, разделенные знаком табуляции. */
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] arr = new int[n, m];
    int j = 0;
    arr[0, 0] = 1;
    for (int i = 0; i < n; i++)
    {
        for (j = 1; j < m; j++)
        {
            arr[i, j] = arr[i, j - 1] + k;
        }
        if (i < n - 1) arr[i + 1, 0] = arr[i, j - 1] + k;

    }
    return arr;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:f2}\t");
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    double tempAverage = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            tempAverage += matrix[i, j];

        }
        res[j] = tempAverage / matrix.GetLength(0);
        tempAverage = 0.00;
    }
    return res;
}
int n = 3;
int m = 4;
int k = 2;
int[,] myArray = CreateIncreasingMatrix(n, m, k);
PrintArray(myArray);
double[] myAverageArray = FindAverageInColumns(myArray);
PrintListAvr(myAverageArray);