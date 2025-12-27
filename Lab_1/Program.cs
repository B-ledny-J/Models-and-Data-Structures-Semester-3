/*
* @file Program.cs
* @author Дарчук Г.С., 525i
* @date 05.11.2025
* @brief Лабораторна робота №1, варіант 5
*
* Дослідження простих алгоритмів сортування
*/

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
            if (!int.TryParse(Console.ReadLine(), out size) || size < 1) size = 10;

            Console.WriteLine("\nТипи масивів:");
            Console.WriteLine("1 - Випадковий");
            Console.WriteLine("2 - Впорядкований за зростанням");
            Console.WriteLine("3 - Впорядкований за спаданням");
            Console.WriteLine("4 - Введений вручну");
            Console.Write("Виберіть тип масиву (1 за замовчуванням): ");
            int type;
            if (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 4) type = 1;

            int[] arr = ArrayGenerator.GenerateArray(size, 0, 500, type);

            Console.WriteLine("\nАлгоритми сортування:");
            Console.WriteLine("1 - Сортування простими включеннями");
            Console.WriteLine("2 - Сортування бульбашкою");
            Console.Write("Виберіть алгоритм сортування (1 за замовчуванням): ");
            int sort;
            if (!int.TryParse(Console.ReadLine(), out sort) || sort < 1 || sort > 2) sort = 1;
            if (sort < 1 || sort > 2) sort = 1;

            Console.WriteLine("\nПочатковий масив: ");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine();

            SortResult result = sort switch
            {
                1 => SortAlgorithms.InsertionSort(arr),
                2 => SortAlgorithms.BubbleSort(arr),
                _ => throw new ArgumentException("Неправильний вибір")
            };

            Console.WriteLine("\nВідсортований масив:");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine($"\nКількість порівнянь: {result.Comparisons}");
            Console.WriteLine($"Кількість обмінів: {result.Swaps}");
            Console.WriteLine($"Сумарна кількість операцій: {result.TotalOps}");
            Console.WriteLine($"Час виконання: {result.ElapsedMs} мс");
        }
    }
}