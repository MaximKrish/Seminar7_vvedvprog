// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите колличество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцоы  m = ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[n, m];
Random random = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", matrix[i, j] + "\t");        //  "\t" красивый выод матрицы с табуляцией
    }
    Console.WriteLine();
}



//Console.Write(matrix[i, j] + "\t"); 



// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// double[,] a = new double[n, m];
// Random random = new Random();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         a[i, j] = random.NextDouble() * 100;
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }


