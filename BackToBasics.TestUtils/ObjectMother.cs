using System;

namespace BackToBasics.TestUtils
{
    public class ObjectMother
    {
        private readonly Random random;

        public ObjectMother()
        {
            random = new Random();
        }

        public int [] CreateRandomArray(int number_of_numbers)
        {
            var needs_sorting = new int[number_of_numbers];

            for (var i = 0; i < number_of_numbers; i++)
            {
                needs_sorting[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            return needs_sorting;
        }        
    }
}