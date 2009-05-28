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
    }
}