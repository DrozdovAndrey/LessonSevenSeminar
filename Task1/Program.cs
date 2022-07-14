// 2. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12



namespace Seminar7
{
    class Task1
    {
        static void Main(string[] args)
        {
            int m = new Random().Next(1, 11);
            int n = new Random().Next(1, 11);
            Console.WriteLine($"m = {m}, n = {n}");
            int[,] array = new int[m, n];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("Сумма чисел главной диагонали:");
            Console.WriteLine(SumHeadDiagonal(array));
        }

        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(1,10);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int SumHeadDiagonal(int[,] array)
        {
            int sum = 0;
            // for (int i = 0; i < array.GetLength(0); i++)
            // {
            //     for (int j = 0; j < array.GetLength(1); j++)
            //     {
            //         if(i == j) sum+= array[i,j];
            //     }
            // }
            for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
            {
                
                     sum+= array[i,i];
            }
                
            return sum;
        }
        
    }
}