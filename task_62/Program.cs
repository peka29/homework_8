// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] InputMatrix() // сдесь мы создаём матрицу
{
    Console.Write("введите размер стороны квадратной матрицы: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[a, a];
    int n = 1;
    int i = 0;
    int j = 0;
    while (n <= matrix.GetLength(0) * matrix.GetLength(0))
    {
        matrix[i, j] = n;
        n++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) // заполняем первую строчку до последнего столбца
            j++;
        else if (i + j >= matrix.GetLength(0) - 1 && i < j) // заполняем последний столбец до последней строчки
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) // заполняем последнюю строчку щагом -1
            j--;
        else
            i--; // заполняем первый столбец шагом -1
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)                                // выводим получившуюся матрицу
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] matrix = InputMatrix();                                 // вызываем все функции по очереди
Console.WriteLine();
PrintMatrix(matrix);