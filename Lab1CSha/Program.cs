using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CSha
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("-----Part 1-----");

            Console.WriteLine("Enter the number of elements in the array: ");

            // Enter the number of elements from the keyboard
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                Console.WriteLine("Enter the number of elements in the array: ");
            }

            FirstPart firstPart = new FirstPart();

            // Создаем массив размера n и присваиваем каждому элементу случайное значение от -20 до 20
            double[] arr = firstPart.RandomArray(n, -20, 20);

            Console.WriteLine($"An array with {n} elements has been created.");

            // Display array
            firstPart.DisplayArray(arr);

            // максимальный по модулю элемент массива
            int maxAbsIndex = firstPart.FindMaxAbsIndex(arr);
            Console.WriteLine($"maximum modulus element of an array (Position of number) {maxAbsIndex + 1}");
            double maxAbsValue = Math.Abs(arr[maxAbsIndex]);
            Console.WriteLine($"maximum modulus element of an array (Value of number) {maxAbsValue}");

            // Cумму модулей элементов массива, расположенных после первого элемента, равного нулю.
            double sumAfterFirstPositive = firstPart.SumAfterFirstPositive(arr);
            Console.WriteLine($"The sum of the modules of the array elements located after the first element, which is equal to zero. {sumAfterFirstPositive}");

            // Преобразуем массив так, чтобы элементы с целыми частями в диапазоне [a, b] располагались первыми, а затем остальные элементы
            Console.WriteLine("Enter a value:");

            double a, b;

            do
            {
                Console.WriteLine("Enter value a:");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("Enter the value a:");
                }

                Console.WriteLine("Enter value b (greater than or equal to a):");
                while (!double.TryParse(Console.ReadLine(), out b) || b < a)
                {
                    Console.WriteLine("Please enter a valid number, greater than or equal to a.");
                    Console.WriteLine("Enter the value b (greater than or equal to a):");
                }

                if (a >= b)
                {
                    Console.WriteLine("Value b must be greater than a. Please try again.");
                }
            } while (a >= b);

            // Преобразование массива
            firstPart.TransformArray(arr, a, b);

            // Отображение преобразованного массива
            Console.WriteLine("Converted array:");
            firstPart.DisplayArray(arr);


            Console.WriteLine("-----Part 2-----");



            Console.Write("Enter the number of rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns of the matrix: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            // Enter values for the matrix from the keyboard
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter a value for the element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            SecondPart secondPart = new SecondPart();

            Console.WriteLine("Initial matrix:");
            secondPart.PrintMatrix(matrix);

            matrix = secondPart.CompactMatrix(matrix);

            Console.WriteLine("\nMatrix after upload:");
            secondPart.PrintMatrix(matrix);

            int positiveRow = secondPart.FindFirstPositiveRow(matrix);
            Console.WriteLine($"\nThe first line contains at least one positive number: {positiveRow}");
        }
    }
}
