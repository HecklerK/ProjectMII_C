using System;

namespace ProjectMII_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[5, 7];
            int[,] matrixB = new int[4, 5];

            for (int i = 0; i < matrixA.GetLength(0); i++)
                for(int j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент " + (i + 1) + ", " + (j + 1) + " матрицы А");
                    matrixA[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            Console.WriteLine("Матрица А");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    Console.Write(matrixA[i, j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < matrixB.GetLength(0); i++)
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент " + (i + 1) + ", " + (j + 1) + " матрицы Б");
                    matrixB[i, j] = Convert.ToInt16(Console.ReadLine());
                }

            Console.WriteLine("Матрица Б");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                    Console.Write(matrixB[i, j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < matrixA.GetLength(0); i++)
                if (matrixA[i, 2] == 0)
                {
                    matrixA[i, 2] = 1;
                }

            Console.WriteLine("изменённая матрица А");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    Console.Write(matrixA[i, j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < matrixB.GetLength(0); i++)
                if (matrixB[i, 4] == 1)
                {
                    matrixB[i, 4] = 0;
                }

            Console.WriteLine("Изменённая матрица Б");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                    Console.Write(matrixB[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
