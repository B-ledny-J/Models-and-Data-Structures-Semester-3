using System.Diagnostics;

namespace Lab_1
{
    static class SortAlgorithms
    {
        public static SortResult InsertionSort(int[] array, bool showSteps = false)
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
                    if (showSteps && array.Length <= 10)
                        Console.WriteLine($"Крок: {string.Join(", ", array)}");
                }
                if (j >= 0) r.Comparisons++;

                array[j + 1] = key;
                if (showSteps && array.Length <= 10)
                    Console.WriteLine($"\nКрок після вставки ключа: {string.Join(", ", array)}");
            }

            sw.Stop();
            r.ElapsedMs = sw.Elapsed.TotalMilliseconds;
            return r;
        }

        public static SortResult BubbleSort(int[] array, bool showSteps = false)
        {
            SortResult r = new();
            Stopwatch sw = Stopwatch.StartNew();

            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    r.Comparisons++;
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        r.Swaps++;
                        swapped = true;
                        if (showSteps && array.Length <= 10)
                            Console.WriteLine($"Крок: {string.Join(", ", array)}");
                    }
                }
                if (!swapped) break;
            }

            sw.Stop();
            r.ElapsedMs = sw.Elapsed.TotalMilliseconds;
            return r;
        }
    }
}
