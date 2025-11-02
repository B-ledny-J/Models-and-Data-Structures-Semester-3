using System;

namespace Lab_1
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.CursorVisible = true;
            
            Console.Write("\nВведіть розмір масиву (10 за замовчуваннями): ");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size < 1) size = 1;

            Console.WriteLine("\nТипи масивів:");
            Console.WriteLine("1 - Випадковий");
            Console.WriteLine("2 - Впорядкований за зростанням");
            Console.WriteLine("3 - Впорядкований за спаданням");
            Console.Write("Виберіть тип масиву (1 за замовчуванням): ");
            int type;
            if (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 3) type = 1;

            int[] array = ArrayGenerator.GenerateArray(size, 0, 500, type);

            Console.WriteLine("\nАлгоритми сортування:");
            Console.WriteLine("1 - Сортування простими включеннями");
            Console.WriteLine("2 - Сортування бульбашкою");
            Console.Write("Виберіть алгоритм сортування (1 за замовчуванням): ");
            int sort;
            if (!int.TryParse(Console.ReadLine(), out sort) || sort < 1 || sort > 2) sort = 1;
            if (sort < 1 || sort > 2) sort = 1;

            Console.WriteLine("\nПочатковий масив: ");
            PrintArray(array);

            SortResult result = sort switch
            {
                1 => SortAlgorithms.InsertionSort(array, true),
                2 => SortAlgorithms.BubbleSort(array, true),
                _ => throw new ArgumentException("Неправильний вибір")
            };

            Console.WriteLine("\nВідсортований масив:");
            PrintArray(array);

            Console.WriteLine($"\nКількість порівнянь: {result.Comparisons}");
            Console.WriteLine($"Кількість обмінів: {result.Swaps}");
            Console.WriteLine($"Сумарна кількість операцій: {result.TotalOps}");
            Console.WriteLine($"Час виконання: {result.ElapsedMs} мс");
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}