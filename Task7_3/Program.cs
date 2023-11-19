// напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr
// и FindAverageInColumns.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной
// размерности, с каждым новым элементом увеличивающимся на определенное
// число. Метод принимает на вход три числа (n - количество строк матрицы,
// m - количество столбцов матрицы, k - число, на которое увеличивается
// каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом
// CreateIncreasingMatrix матрицу.
// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,]
// и возвращает одномерный массив типа double. Этот метод вычисляет среднее
// значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.
// Метод PrintListAvr принимает одномерный массив, возвращенный методом
// FindAverageInColumns и выводит этот список на экран в формате
// The averages in columns are:
// x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов,
// округленные до двух знаков после запятой (в дробной части ВСЕГДА должно
// быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

int InputIntNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateIncreasingMatrix(int m, int n, int k)
{
    int[,] matrix = new int[m,n];
    int increment = 0;
    matrix[0,0] = 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = matrix[0,0] + increment;
            increment = increment + k;
        }
    }
    return matrix;
}

void PrintArray(int[,] printmatrix)
{
    for (int i = 0; i < printmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printmatrix.GetLength(1); j++)
        {
            System.Console.Write($"{printmatrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double[] FindAverageInColumns(int[,] matr)
{
    double[] average = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            average[i] = (average[i] + matr[j,i]);
        }
    }
    for (int i = 0; i < average.Length; i++)
    {
        average[i] = average[i] / matr.GetLength(0);
    }
    return average;
}

void PrintListAvr(double[] printarray)
{
    Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < printarray.Length; i++)
    {
        Console.Write($"{string.Format("{0:f}", printarray[i])}\t");
    }

}


int m = InputIntNumber("Введите кол-во строк массива: ");
Console.WriteLine();
int n = InputIntNumber("Введите кол-во столбцов массива: ");
Console.WriteLine();
int k = InputIntNumber("Введите инкремен: ");
Console.WriteLine();
int[,] workmatrix = new int[m, n];
workmatrix = CreateIncreasingMatrix(m, n, k);
PrintArray(workmatrix);
PrintListAvr(FindAverageInColumns(workmatrix));
