/* Внутри класса Answer напишите методы 
CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
 с каждым новым элементом увеличивающимся на опрделенное число. 
 Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
 k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
 удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindNumberByPosition принимает на вход сгенрированную матрицу 
и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за
 пределами границ массива, метод должен вернуть массив с нулевым значением. 
 Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями:
  значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, 
  что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода
 FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить,
  был ли найден элемент в матрице по указанным координатам (x и y), используя результаты 
  из метода FindNumberByPosition. Если такого элемента нет, 
  вывести на экран "There is no such index". Если элемент есть, 
  вывести на экран "The number in [{x}, {y}] is {значение}". */
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

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int[] res = { 0, 0 };
    if (
        rowPosition  > 0
        && rowPosition <= matrix.GetLength(0)
        && columnPosition  > 0
        && columnPosition <= matrix.GetLength(1)
        )
    {
        res[0] = matrix[rowPosition - 1, columnPosition - 1];
    }
    return res;
}

void PrintCheckIfError(int[] results, int X, int Y)
{
    if (results[0] == 0)
    {
        Console.WriteLine("There is no such index");
    }
    else
    {
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
}

// int n = 3;
// int m = 4;
// int k = 2;
// int x = 8;
// int y = 3;
// int n = 4;
// int m = 5;
// int k = 3;
// int x = 2;
// int y = 2;
int n = 3;
int m = 7;
int k = 3;
int x = 5;
int y = 1;
int[,] myArray = CreateIncreasingMatrix(n, m, k);
PrintArray(myArray);
int[] results = FindNumberByPosition(myArray, x, y);
PrintCheckIfError(results, x, y);
