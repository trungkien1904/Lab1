using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CSha
{
    public class SecondPart
    {
        //Выводим матрицу на экран
        public void PrintMatrix(int[,] matrix)
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


        //удаляем строки и столбцы, содержащие 0
        public int[,] CompactMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            //Отслеживаем, имеет ли каждая строка и столбец значение 0
            bool[] rowContainsZero = new bool[rows];
            bool[] colContainsZero = new bool[cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        rowContainsZero[i] = true;
                        colContainsZero[j] = true;
                    }
                }
            }

            // Проходим по матрице и выделяем строки и столбцы, содержащие ненулевые значения
            int compactRows = 0;
            for (int i = 0; i < rows; i++)
            {
                if (rowContainsZero[i])
                {
                    compactRows++;
                }
            }

            int compactCols = 0;
            for (int j = 0; j < cols; j++)
            {
                if (colContainsZero[j])
                {
                    compactCols++;
                }
            }

            int[,] compactMatrix = new int[compactRows, compactCols];
            int newRow = 0;

            for (int i = 0; i < rows; i++)
            {
                if (rowContainsZero[i])
                {
                    int newCol = 0;

                    for (int j = 0; j < cols; j++)
                    {
                        if (colContainsZero[j])
                        {
                            compactMatrix[newRow, newCol] = matrix[i, j];
                            newCol++;
                        }
                    }

                    newRow++;
                }
            }

            return compactMatrix;
        }

        // Метод поиска первой строки, содержащей хотя бы одно положительное число
        public int FindFirstPositiveRow(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool hasPositiveElement = false;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        hasPositiveElement = true;
                        break;
                    }
                }

                if (hasPositiveElement)
                {
                    return i + 1;
                }
            }

            // Trả về -1 nếu không có dòng nào chứa số dương
            return -1;
        }
    }
}
