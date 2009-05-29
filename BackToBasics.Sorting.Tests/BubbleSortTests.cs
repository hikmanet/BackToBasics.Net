using BackToBasics.Sorting.Implementations;
using BackToBasics.TestUtils;
using Xunit;

namespace BackToBasics.Sorting.Tests
{

    public class BubbleSortTests
    {
        private readonly ObjectMother objectMother;

        public BubbleSortTests()
        {
            objectMother = new ObjectMother();
        }

        [Fact]
        public void should_sort_in_place()
        {
            const int number_of_numbers = 100;
            ISorter sut = new BubbleSorter();

            var numbers_to_sort = objectMother.CreateRandomArray(number_of_numbers);
            var list_of_sorted_numbers = sut.Sort(numbers_to_sort);

            Assert.Same(numbers_to_sort, list_of_sorted_numbers);            
        }

        [Fact]
        public void should_sort_list()
        {
            const int number_of_numbers = 100;
            ISorter sut = new BubbleSorter();

            var list_of_numbers = sut.Sort(objectMother.CreateRandomArray(number_of_numbers));

            Assert.True(list_of_numbers.IsSorted());
        }

        [Fact]
        public void should_sort_list_with_enhanced_bubble_sorter()
        {
            const int number_of_numbers = 100;
            ISorter sut = new EnhancedBubbleSorter();

            var list_of_numbers = sut.Sort(objectMother.CreateRandomArray(number_of_numbers));

            Assert.True(list_of_numbers.IsSorted());
        }
    }
}