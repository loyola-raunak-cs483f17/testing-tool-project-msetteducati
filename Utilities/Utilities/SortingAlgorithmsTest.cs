using System;
using Xunit;

namespace Utilities
{
    public class SortingAlgorithmsTest : IDisposable
    {
        // Instance variable for unsorted array that will be sorted each time
        int[] unsorted_array;

        // Constructor (runs before each test)
        public SortingAlgorithmsTest()
        {
            unsorted_array = new int[] { 20, 40, 30, 60, 100, 10, 70, 50, 80, 90, -10 };
        }

        // Dispose function (runs after each test)
        public void Dispose()
        {
            unsorted_array = null;
        }

        // Tests RunSelectionSort() function
        [Fact]
        public void TestRunSelectionSort()
        {
            int[] sorted_array = SortingAlgorithms.RunSelectionSort(unsorted_array);
            Assert.Equal(sorted_array[0], -10);
            Assert.Equal(sorted_array[1], 10);
            Assert.Equal(sorted_array[10], 100);
        }

        // Tests RunInsertionSort() function
        [Fact]
        public void TestRunInsertionSort()
        {
            int[] sorted_array = SortingAlgorithms.RunSelectionSort(unsorted_array);
            Assert.Equal(sorted_array[0], -10);
            Assert.Equal(sorted_array[1], 10);
            Assert.Equal(sorted_array[10], 100);
        }

        // Tests RunMergeSort() function
        [Fact]
        public void TestRunMergeSort()
        {
            int[] sorted_array = SortingAlgorithms.RunMergeSort(unsorted_array);
            Assert.Equal(sorted_array[0], -10);
            Assert.Equal(sorted_array[1], 10);
            Assert.Equal(sorted_array[10], 100);
        }
    }
}
