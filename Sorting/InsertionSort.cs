namespace Sorting
{
    /// <summary>
    /// In Place sorting and stable in nature( meaning it preserves the order of equal elements)
    /// useful for small dataset with performance near to O(n)
    /// for large dataset its performance is O(n2), not good
    /// </summary>
    public class InsertionSort
    {
        public InsertionSort()
        {
            int[] array = { 5, 2, 4, 1, 1, 3 };

            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                
                int key = array[i];
                
                // need to check left from the ith index to 0
                int j = i-1;

                // Move elements of array[0..i-1], that are greater than key, to one position ahead of their current position

                while(j >= 0 && array[j] > key)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }




    }
}
