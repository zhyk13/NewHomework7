// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами. Внутри класса Answer напишите метод
// CreateRandomMatrix, который принимал бы числа m и n (размерность массива),
// а также minLimitRandom и maxLimitRandom, которые указывают на минимальную
// и максимальную границы случайных чисел.
// Также, задайте метод PrintArray, который выводил бы массив на экран.
// Для вывода матрица используйте интерполяцию строк для форматирования
// числа matrix[i, j] с двумя знаками после запятой (f2) и добавления
// символа табуляции (\t) после каждого элемента матрицы. Таким образом,
// каждый элемент матрицы будет разделен символом табуляции при выводе.




int InputIntNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


double InputDoubleNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}


double[,] CreateRandomMatrix(int line, int column, double min, double max)
{
    double[,] matr = new double[line, column];
    Random random = new Random();
    if (min == max)
    {
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < column; j++)
            {
             matr[i, j] = min;
            }
        }
    }
    else
    {
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matr[i, j] = (random.NextDouble() * max + random.NextDouble() * min) / 2;
            }
        }
    }    
    return matr;
}

void PrintMatrix(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(mas[i, j], 2)}\t");
        }
        System.Console.WriteLine();
    }
}

int m = InputIntNumber("Введите кол-во строк массива: ");
Console.WriteLine();
int n = InputIntNumber("Введите кол-во столбцов массива: ");
Console.WriteLine();
double minLimitRandom = InputDoubleNumber ("Введите минимальное значение элемента массива: ");
Console.WriteLine();
double maxLimitRandom = InputDoubleNumber("Введите максимальное значение элемента массива: ");
Console.WriteLine();
double[,] matrix = new double[m,n];
matrix = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintMatrix(matrix);
