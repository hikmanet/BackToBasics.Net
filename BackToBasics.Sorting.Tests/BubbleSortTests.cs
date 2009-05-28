using System;
using Xunit;

namespace BackToBasics.Sorting.Tests
{

    public class BubbleSortTests
    {
        [Fact]
        public void should_sort_list()
        {
            const int number_of_numbers = 100;
            var sut = new BubbleSorter();

            var list_of_numbers = sut.Sort(CreateRandomArray(number_of_numbers));

            Assert.True(list_of_numbers.IsSorted());
        }

        private int [] CreateRandomArray(int number_of_numbers)
        {
            var random = new Random();
            var needs_sorting = new int[number_of_numbers];

            for (var i = 0; i < number_of_numbers; i++)
            {
                needs_sorting[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            return needs_sorting;
        }
    }

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