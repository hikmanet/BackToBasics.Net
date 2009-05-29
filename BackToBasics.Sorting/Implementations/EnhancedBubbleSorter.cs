namespace BackToBasics.Sorting.Implementations
{
    /// <summary>
    /// Still O(x^2) but optimized to be fast for nearly sorted lists
    /// </summary>
    public class EnhancedBubbleSorter : ISorter
    {
        public int [] Sort(int [] a)
        {
            bool swapped;

            do
            {
                swapped = false;
                for(var i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] <= a[i + 1]) 
                        continue;

                    var temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                    swapped = true;
                }

            } while (swapped);

            return a;
        }
    }
}