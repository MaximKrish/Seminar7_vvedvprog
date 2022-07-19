// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateMatr(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            //matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void AverageSum(int[,] matrix)
{
      Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {    double AverSum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            AverSum = AverSum + matrix[j, i];

        }
        Console.WriteLine(i + 1 + " столбец: " + AverSum/matrix.GetLength(1));  
    }
}
Console.Write("Введите колличество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцоы  m = ");
int m = Convert.ToInt32(Console.ReadLine());
AverageSum(CreateMatr(n, m));