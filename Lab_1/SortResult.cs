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