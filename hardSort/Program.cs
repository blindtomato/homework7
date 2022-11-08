// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

int[,] fillAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();    
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();    
    }
}

void SortMatrix(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 1; i < m * n; i++)
    {
        for (int j = 0; j < m * n - i; j++)
        {
            if (array[j / n, j % n] > array[(j + 1)/ n, (j + 1) % n])
            {
                int temp = array[j / n, j % n];
                array[j / n, j % n] = array[(j + 1)/ n, (j + 1) % n];
                array[(j + 1)/ n, (j + 1) % n] = temp;
            }
        }
    }
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = fillAndPrintMatrix(m, n);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);