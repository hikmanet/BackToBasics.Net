namespace BackToBasics.Sorting
{
    public class BubbleSorter
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

        public int [] SortMethod2(int [] a)
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