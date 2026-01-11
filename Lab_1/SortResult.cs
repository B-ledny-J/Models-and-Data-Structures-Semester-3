/*
 * @file SortResult.cs
 * @author Дарчук Г.С., 515i
 * @date 05.11.2025
 * @brief Лабораторна робота №1, варіант 5
 *
 * Дослідження простих алгоритмів сортування
 */

namespace Lab_1
{
    struct SortResult
    {
        public long Comparisons;
        public long Swaps;
        public long TotalOps => Comparisons + Swaps;
        public double ElapsedMs;
    }
}