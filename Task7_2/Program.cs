// напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и
// PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает
// на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу,
// удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом
// CreateIncreasingMatrix матрицу. Элементы матрицы должны быть выведены через символ
// табуляции для более читаемого вывода.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y -
// позиции элемента в матрице. Если указанные координаты находятся за пределами границ
// массива, метод должен вернуть массив с нулевым значением. Если координаты находятся
// в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в
// указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция
// прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа
// x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент
// в матрице по указанным координатам (x и y), используя результаты из метода
// FindNumberByPosition. Если такого элемента нет, вывести на экран
// "There is no such index". Если элемент есть, вывести на экран
// "The number in [{x}, {y}] is {значение}"



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

void PrintMatrix(int[,] printmatrix)
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

int[] FindNumberByPosition(int[,] findmatrix, int x2, int y2)
{
    int[] findelement = new int[2];
    if ((x2 > findmatrix.GetLength(0)) || (y2 > findmatrix.GetLength(1)))
    {
        findelement[0] = 0;
        findelement[1] = 0;
    }
    else
    {
        findelement[0] = findmatrix[x2, y2];
        findelement[1] = 0;
    }
    return findelement;
}

void PrintCheckIfError(int[] rezalt, int x1, int y1)
{
    if (rezalt[0] == 0)
    {
        Console.WriteLine("There is no such index");
    }
    else
    {
        Console.WriteLine($"The number in [{x1}, {y1}] is {rezalt[0]}");
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
PrintMatrix(workmatrix);
int x = InputIntNumber("Введите номер строки искомого элемента: ");
Console.WriteLine();
int y = InputIntNumber("Введите номер столбца искомого элемента: ");
Console.WriteLine();
PrintCheckIfError(FindNumberByPosition(workmatrix, x, y), x, y);

