using System;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {
           
            MyMatrix matrix = new MyMatrix(3, 3);
            Console.WriteLine("Оригінальна матриця:");
            matrix.DisplayMatrix();

            MyMatrix transposedMatrix = matrix.GetTransposed();
            Console.WriteLine("Транспонована матриця:");
            transposedMatrix.DisplayMatrix();

            matrix.ResizeMatrix(4, 4);
            Console.WriteLine("Матриця після зміни розміру на 4x4:");
            matrix.DisplayMatrix();
        }

        class MyMatrix
        {
            private int[,] matrix;

            public MyMatrix(int rows, int cols)
            {
                matrix = new int[rows, cols];
                Random random = new Random();
               
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = random.Next(1, 100); 
                    }
                }
            }

            public void DisplayMatrix()
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            public MyMatrix GetTransposed()
            {
                int rows = matrix.GetLength(1);
                int cols = matrix.GetLength(0);
                MyMatrix transposedMatrix = new MyMatrix(rows, cols);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        transposedMatrix.matrix[i, j] = matrix[j, i];
                    }
                }
                return transposedMatrix;
            }

            public void ResizeMatrix(int newRows, int newCols)
            {
                int[,] newMatrix = new int[newRows, newCols];
                int rowsToCopy = Math.Min(newRows, matrix.GetLength(0));
                int colsToCopy = Math.Min(newCols, matrix.GetLength(1));

               
                for (int i = 0; i < rowsToCopy; i++)
                {
                    for (int j = 0; j < colsToCopy; j++)
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                }
                matrix = newMatrix;
            }
        }

    }
}
