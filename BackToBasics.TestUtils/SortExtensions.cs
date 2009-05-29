namespace BackToBasics.TestUtils
{
    public static class SortExtensions
    {
        public static bool IsSorted(this int [] array)
        {
            for(var i=1; i<array.Length; i++)
            {
                if (array[i - 1] > array[i])
                    return false;
            }

            return true;
        }
    }
}