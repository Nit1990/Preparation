using System.Collections.Concurrent;

namespace Sorting
{
    /// <summary>
    /// In Place sorting but not stable one as relative order is not maintained in basic implementation.
    /// Use Recursion for the sorting
    /// 
    /// </summary>
    public class QuickSort
    {
        public QuickSort()
        {
            int[] array = { 24,18, 38, 43, 14, 40, 1, 54 };
            
            int len = array.Length -1;

            // quick sort function we need to pass array, low = 0, high = array.Length -1
            QuickSortMain(array,0,len);
        }

        private void QuickSortMain(int[] array, int low, int high)
        {
            if(low < high)
            {
                // partition the array into two parts and return the pivot index
                int pivotIndex = Partition(array, low, high);

                // Recursively Sort elements before and after the pivot
                
                //first half               
                QuickSortMain(array, low, pivotIndex - 1);

                // Second half
                QuickSortMain(array, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            // Select rightmost element as Pivot
            int pivot = array[high];
            int i = low -1;

            // Iterate through the array and move element smaller than the pivot to the left

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;

                    // swap array[i] and array[j]
                    (array[j], array[i]) = (array[i], array[j]);
                }
            }

            // Swap array[i+1] and array[high] (pivot)

            (array[high], array[i + 1]) = (array[i + 1], array[high]);

            // Return the pivot index
            return i + 1;
        }
    }
}
