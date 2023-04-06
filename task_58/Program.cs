// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// (2*3+3*4) (2*4+4*3) 
// (3*3+2*3) (3*4+2*3)
int[,] InputMatrix1() // создаём матрицу 1
{
    Console.Write("введите размер первой матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix1 = new int[size[0], size[1]];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10); ;
            Console.Write($"{matrix1[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matrix1;
}
int[,] InputMatrix2() // создаём матрицу 2
{
    Console.Write("введите размер второй матрицы матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix2 = new int[size[0], size[1]];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(1, 10); ;
            Console.Write($"{matrix2[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matrix2;
}
void MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix2.GetLength(1), matrix1.GetLength(0)]; // матрица которую получи должна быть из столбцов 2 матрицы и строк 1
    if (matrix2.GetLength(1) != matrix1.GetLength(0))                      // столбцы 2 образуют строки, а строки 1 образуют столбцы.
    Console.Write($"матрицу 1 нельзя умножить на матрицу 2!");
    else 
    for (int i = 0; i < result.GetLength(1); i++) // пошли по строкам
    {
        for (int j = 0; j < result.GetLength(1); j++) // пошли по столбцам
        {
            for (int n = 0; n < matrix1.GetLength(0); n++) // количество строк 1 матрицы определяет полученную матрицу
            {
                result[i,j] += matrix1[i, n]*matrix2[n, j];     // формула произведения матрицы           
            }            
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] matrix1 = InputMatrix1();
Console.WriteLine();
int[,] matrix2 = InputMatrix2();                               // вызываем все функции по очереди
Console.WriteLine();
MultiplicationMatrix(matrix1, matrix2);
