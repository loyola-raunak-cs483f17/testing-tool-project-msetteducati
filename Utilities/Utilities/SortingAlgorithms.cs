using System;

namespace Utilities
{
    public class SortingAlgorithms
    {
        /**
         * Runs Selection Sort algorithm on unsorted_array of ints and returns 
         * the sorted array. 
         */
        public static int[] RunSelectionSort(int[] unsorted_array)
        {
            int array_size = unsorted_array.Length;
            int[] to_return = new int[array_size];
            Array.Copy(unsorted_array, to_return, array_size);

            int tmp, min_key;

            for (int i = 0; i < array_size - 1; i++)
            {
                min_key = i;

                for (int j = i + 1; j < array_size; j++)
                {
                    if (to_return[j] < to_return[min_key])
                        min_key = j;
                }

                tmp = to_return[min_key];
                to_return[min_key] = to_return[i];
                to_return[i] = tmp;
            }

            return to_return;
        }

        /**
         * Runs Insertion Sort algorithm on unsorted_array of ints and returns
         * the sorted array.
         */
        public static int[] RunInsertionSort(int[] unsorted_array)
        {
            int array_size = unsorted_array.Length;
            int[] to_return = new int[array_size];
            Array.Copy(unsorted_array, to_return, array_size);

            for (int i = 1; i < array_size; i++)
            {
                int item = to_return[i];
                int ins = 0;

                for (int j = i - 1; j >= 0 && ins != 1; )
                {
                    if (item < to_return[j])
                    {
                        to_return[j + 1] = to_return[j];
                        j--;
                        to_return[j + 1] = item;
                    }
                    else
                        ins = 1;
                }
            }

            return to_return;
        }

        /**
         * Runs Merge Sort algoirthm on unsorted_array of ints and returns the
         * sorted array. Uses two private helper functions.]
         */
        public static int[] RunMergeSort(int[] unsorted_array)
        {
            MergeSortMethod(unsorted_array, 0, unsorted_array.Length - 1);
            return unsorted_array;
        }

        /**
         * Recursively runs method on both sides of the list, then calls
         * MergingMethod to merge the two sides together.
         */
        private static void MergeSortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if(right > left)
            {
                mid = (right + left) / 2;
                MergeSortMethod(numbers, left, mid);
                MergeSortMethod(numbers, (mid + 1), right);
                MergingMethod(numbers, left, (mid + 1), right);
            }
        }

        /**
         * Merges two sorted sides of the array together.
         */
        private static void MergingMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25]; // CHANGE?
            int left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (int i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

    }
}