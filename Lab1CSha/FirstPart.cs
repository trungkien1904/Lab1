using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CSha
{
    public class FirstPart
    {
        //Создаем случайный массив
        public double[] RandomArray(int size, int minValue, int maxValue)
        {
            double[] arr = new double[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }

        //Отображение элементов массива
        public void DisplayArray(double[] arr)
        {
            Console.WriteLine("Array element values:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element {i + 1}: {arr[i]}");
            }
        }

        // Метод поиска индекса элемента с наибольшим абсолютным значением
        public int FindMaxAbsIndex(double[] arr)
        {
            int maxAbsIndex = 0;
            double maxAbsValue = Math.Abs(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                double absValue = Math.Abs(arr[i]);
                if (absValue > maxAbsValue)
                {
                    maxAbsValue = absValue;
                    maxAbsIndex = i;
                }
            }

            return maxAbsIndex;
        }


        // Метод расчета суммы элементов массива после первого элемента с положительным значением
        public double SumAfterFirstPositive(double[] arr)
        {

            // Находим индекс первого элемента с положительным значением
            int firstIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    firstIndex = i;
                    break;
                }
            }

            // Если положительный элемент не найден, возвращаем 0
            if (firstIndex == -1)
            {
                return 0;
            }

            // Вычисляем сумму элементов от следующего индекса до конца массива
            double sum = 0;
            for (int i = firstIndex + 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        // Метод перемещения элементов с целыми частями в диапазоне [a, b] в начало массива
        public void TransformArray(double[] arr, double a, double b)
        {
            int index = 0;

            // Перемещаем элементы с целыми частями в диапазоне [a, b] в начало массива
            for (int i = 0; i < arr.Length; i++)
            {
                // Проверяем, есть ли у элемента целая часть в диапазоне [a, b].
                if (IsIntegerInRange(arr[i], a, b))
                {
                    // Если элемент находится в диапазоне, переместим его на позицию индекса и увеличим индекс на 1
                    Swap(arr, i, index);
                    index++;
                }
            }
        }

        // Функция для проверки того, есть ли у числа целая часть в диапазоне [a, b].
        private bool IsIntegerInRange(double number, double a, double b)
        {
            double integerPart = Math.Truncate(number);
            return integerPart >= a && integerPart <= b;
        }

        // Функция для замены двух элементов массива
        private void Swap(double[] arr, int index1, int index2)
        {
            double temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

    }
}
