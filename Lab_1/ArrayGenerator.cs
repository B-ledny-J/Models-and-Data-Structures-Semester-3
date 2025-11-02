namespace Lab_1
{
    static class ArrayGenerator
    {
        public static int[] GenerateArray(int size, int min, int max, int type)
        {
            int[] array = new int[size];
            Random rnd = new Random();

            switch (type)
            {
                case 1: // random
                    for (int i = 0; i < size; i++)
                        array[i] = rnd.Next(min, max + 1);
                    break;

                case 2: // ascending
                    for (int i = 0; i < size; i++)
                        array[i] = min + i * (max - min) / Math.Max(1, size - 1);
                    break;

                case 3: // descending
                    for (int i = 0; i < size; i++)
                        array[i] = max - i * (max - min) / Math.Max(1, size - 1);
                    break;
            }
            return array;
        }
    }
}