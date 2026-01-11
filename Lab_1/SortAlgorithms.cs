/*
* @file SortAlgorithms.cs
* @author Дарчук Г.С., 515i
* @date 05.11.2025
* @brief Лабораторна робота №1, варіант 5
*
* Дослідження простих алгоритмів сортування
*/

using System.Diagnostics;

namespace Lab_1
{
    static class SortAlgorithms
    {
        public static SortResult InsertionSort(int[] array)
        {
            SortResult r = new();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    r.Comparisons++;
                    array[j + 1] = array[j];
                    r.Swaps++;
                    j--;
                    Console.WriteLine($"Крок: {string.Join(", ", array)}");
                }
                if (j >= 0) r.Comparisons++;

                array[j + 1] = key;
                Console.WriteLine($"Крок після вставки ключа: {string.Join(", ", array)}");
            }

            sw.Stop();
            r.ElapsedMs = sw.Elapsed.TotalMilliseconds;
            return r;
        }

        public static SortResult BubbleSort(int[] array)
        {
            SortResult r = new();
            Stopwatch sw = Stopwatch.StartNew();

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    r.Comparisons++;
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        r.Swaps++;
                        Console.WriteLine($"Крок: {string.Join(", ", array)}");
                    }
                }
            }

            sw.Stop();
            r.ElapsedMs = sw.Elapsed.TotalMilliseconds;
            return r;
        }
    }
}