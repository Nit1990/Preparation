namespace PracticeProject.Geeks
{

    public class GeeksArrays
    {
        // An element of array is a leader if it is greater than or equal to all the elements to its right side
        public int[] LeadersInArray()
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            int N = 6;

            int j = N - 1;

            List<int> list = new List<int>();


            for (int i = N - 1; i >= 0; i--)
            {
                if (i == N - 1)
                {
                    list.Add(arr[i]);
                    continue;
                }
                if (arr[i] > arr[j])
                {
                    list.Add(arr[i]);
                    j = i;
                }
            }

            var arr1 = list.ToArray();
            // list.Reverse();
            Array.Reverse(arr1);
            return arr1;
        }

        // Anti Clock-wise
        public void RotateArrayOnePlaceLeft()
        {
            int[] arr = { 1, 2, 3, 4, 5 }; // {2,3,4,5,1}

            int temp = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;

        }

        //Clock-wise
        public void RotateArrayOnePlaceRight()
        {
            int[] arr = { 1, 2, 3, 4, 5 }; // {5,1,2,3,4}

            int temp = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[0] = temp;

        }

        public void RotateArrayByKElementsUsingTempArray()
        {

            int d = 3;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] temp = new int[d];

            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[i];
            }

            //shifting

            for (int i = d; i < arr.Length; i++)
            {
                arr[i - d] = arr[i];
            }
            // temp -> original array
            int j = 0;

            for (int i = arr.Length - d; i < arr.Length; i++)
            {
                arr[i] = temp[j];
                j++;
            }
        }

        public void RotateArrayByKElementsLeft()
        {
            int d = 3;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            d = d % arr.Length - 1; // multiple rotation 
            // {3,2,1} {7,6,5,4}
            //{4,5,6,7,1,2,3}
            // reverse(a,a+d), reverse(a+d,n), reverse(a,n)
            Reverse(arr, 0, d - 1);
            Reverse(arr, d, arr.Length - 1);
            Reverse(arr, 0, arr.Length - 1);


        }

        public void ReverseWordInString()
        {
            string S = "i.like.this.program.very.much";

            string[] test = S.Split(new[] { '.' });

            int start = 0;
            int end = test.Length - 1;

            while (start <= end)
            {
                (test[start], test[end]) = (test[end], test[start]);
                start++;
                end--;
            }
            string c = string.Join(".", test);
            Console.WriteLine(c);
        }
        private void Reverse(int[] arr, int start, int end)
        {
            while (start <= end)
            {
                (arr[end], arr[start]) = (arr[start], arr[end]);
                start++;
                end--;
            }
        }

        public void LongestConsecutiveSequenceInArray()
        {
            int[] arr = { 100, 200, 1, 3, 2, 4 };

            // Insertion Sort
            Sort(arr);
            // 1,2,3,4,100,200

            int lstSmall = int.MinValue;
            int count = 0;
            int longest = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - 1 == lstSmall)
                {
                    count++;
                    lstSmall = arr[i];
                }
                else if (arr[i] != lstSmall)
                {
                    count = 1;
                    lstSmall = arr[i];
                }
                longest = Math.Max(longest, count);
            }
        }
        private void Sort(int[] arr)
        {
            // Insertion Sort

            for (int i = 1; i < arr.Length; i++)
            {
                // Current Element
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;


            }
        }

        public void RemoveDuplicateFromSortedArray()
        {
            int j = 0;
            int[] arr = { 1, 2, 2, 4 };
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[j])
                {
                    j++;
                    arr[j] = arr[i];

                }
            }
            Console.WriteLine(j + 1);
        }
    }

}