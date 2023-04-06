// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// c наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] InputMatrix() // создаём матрицу
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
void SumMatrix(int[,] matrix)
{
    int[] summArray = new int[matrix.GetLength(0)]; // превращаем в одномерный массив
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summArray[i] += matrix[i, j]; //находим сумму всех строк
        }
        Console.WriteLine($"{summArray[i]}\t"); // выводим сумму для наглядности (не обязательное действие)
    }
    Console.WriteLine();
    int minSumm = 0; // минимальная сумма = 0
    for (int i = 0; i < summArray.Length; i++) // проходим о всему массиву
    {
        if (summArray[minSumm] > summArray[i]) minSumm = i; // в поисках минимальной суммы в массиве
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {minSumm+1}");
}
Console.Clear();
int[,] matrix = InputMatrix();  // вызываем все функции по очереди
Console.WriteLine();
SumMatrix(matrix);