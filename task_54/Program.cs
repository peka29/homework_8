// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InputMatrix() // сдесь мы создаём матрицу
{
    Console.Write("введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); ;
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matrix;
}
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = j;                                        // сдесь мы сортируем строку в матрице
            for (int n = j + 1; n < matrix.GetLength(1); n++)   // перебераем все элементы в строке
            {
                if (matrix[i, n] > matrix[i, max])              // если элемент в строке больше принятого нами самого больщого эл.
                    max = n;
            }
            int temprary = matrix[i, j];                        // сдесь меняем местами новый максимум со старым
            matrix[i, j] = matrix[i, max];
            matrix[i, max] = temprary;
        }                                                      // продолжаем пока не кончится строка
    }                                                          // продолжаем пока не кончатся все строки 
}
void PrintMatrix(int[,] matrix)                                // выводим получившуюся матрицу
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
Console.Clear();
int[,] matrix = InputMatrix();                                 // вызываем все функции по очереди
Console.WriteLine();
ReleaseMatrix(matrix);
PrintMatrix(matrix);