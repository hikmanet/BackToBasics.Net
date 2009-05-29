namespace BackToBasics.Sorting.Implementations
{
    /// <summary>
    /// Slowest but easiest to implement
    /// </summary>
    public class BubbleSorter : ISorter
    {
        public int [] Sort(int [] a)
        {
            for (var i = a.Length - 1; i >= 0; i--)
            {
                for (var j = 1; j <= i; j++)
                {
                    if (a[j - 1] <= a[j]) 
                        continue;

                    var temp = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = temp;
                }
            }

            return a;
        }
    }
}