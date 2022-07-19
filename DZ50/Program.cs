// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatr(int n, int m)
{
    int[,] matrix = new int[n, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            matrix[0, 1] = 0;                           // искусственно вели значение 0
            Console.Write(matrix[i, j] + "\t");         //  "\t" красивый выод матрицы с табуляцией

            //matrix[i, j] = Convert.ToInt32(Console.ReadLine()); ручной ввод
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatr(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == c)
                {
                    Console.WriteLine("Такой элемент есть  = " + matrix[i, j]);
                }
                else
                Console.WriteLine("Такого элемента нет = " + matrix[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцоы  m = ");
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));


// // 50
// int[, ] CreateMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int x = Convert.ToInt32(Console.ReadLine());
//             matrix[i , j] = x;
//         }
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

//     return matrix;
// }


// void CheckMatrix(int i, int j, int[, ] matrix)
// {
//     if (i < matrix.GetLength(0) && j < matrix.GetLength(1) && i >= 0 && j >= 0)
//         Console.WriteLine(matrix[i, j]);
//     else
//         Console.WriteLine("Ты ошибся");
// }

// int[, ] matrix = new int[4, 4];
// matrix = CreateMatrix(matrix);
// Console.WriteLine("Введите координаты: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int j = Convert.ToInt32(Console.ReadLine());
// CheckMatrix(i, j, matrix);