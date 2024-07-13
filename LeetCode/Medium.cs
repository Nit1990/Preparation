namespace MediumLeetcode
{

    public class Medium
    {
        List<List<int>> result = new();
        // Group the Anagrams together
        public List<List<string>> GroupAnagrams()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            Dictionary<string, List<string>> dict = new();

            foreach (string str in strs)
            {
                char[] charArr = str.ToCharArray();
                Array.Sort(charArr);
                string newStr = new string(charArr);

                if (!dict.ContainsKey(newStr))
                {
                    dict[newStr] = new List<string>();
                }

                dict[newStr].Add(str);
            }
            return new List<List<string>>(dict.Values);
        }

        // Top K Frequent Elements
        public int[] TopKFrequentElements()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;  // [1,2]

            var dict = new Dictionary<int, int>();


            foreach (int n in nums)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n]++;

                }
                else
                {
                    dict[n] = 1;
                }
            }
            // 1 3
            // 2 2
            // 3 1

            // Linq 
            var topElement = dict.OrderByDescending(x => x.Value)
                                 .Select(y => y.Key)
                                 .Take(k)
                                 .ToArray();

            var result = new List<int>();
            foreach (var d in dict.OrderByDescending(d => d.Value))
            {
                if (result.Count < k)
                {
                    result.Add(d.Key);
                    continue;
                }
                break;
            }
            return result.ToArray();
        }

        // Product Except Self
        public void ProductExceptSelf()
        {
            int[] nums = { 1, 2, 3, 4 };

            int prefix = 1, postfix = 1;

            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix = prefix * nums[i];
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = result[i] * postfix;
                postfix = postfix * nums[i];
            }
        }

        // Two Sum - Input Array is Sorted - Two Pointer
        public void TwoSumArrayIsSorted()
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum > target)
                    right--;
                else if (sum < target)
                    left++;
                else
                {
                    var result = new int[] { left + 1, right + 1 };
                }
            }


        }

        //Three Sum
        public void ThreeSum()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                // b+c = 0-a as target
                // duplicate check for a
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    TwoSumForThreeSum(i + 1, nums.Length - 1, nums, 0 - nums[i]);
                }
            }
        }

        public void TwoSumForThreeSum(int left, int right, int[] nums, int target)
        {
            int firstNum = nums[left - 1];
            while (left < right)
            {
                if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else if (nums[left] + nums[right] < target)
                {
                    left++;
                }
                else
                {
                    List<int> sol = new List<int>() { firstNum, nums[left], nums[right] };
                    result.Add(sol);

                    // duplicate left
                    while (left < right && nums[left] == nums[left + 1])
                        left++;
                    // duplicate right
                    while (left < right && nums[right] == nums[right - 1])
                        right--;

                    left++;
                    right--;

                }
            }

        }

        //Kadane's Algorithm - Sliding Window
        public void MaxSubArraySum()
        {
            int[] arr = { 2, 3, -1, 2, 4, 3 };
            int Length = arr.Length;

            int localMax = 0;
            int globalMax = int.MinValue;

            for (int i = 0; i < Length; i++)
            {
                localMax = Math.Max(arr[i], localMax + arr[i]);

                if (localMax > globalMax)
                {
                    globalMax = localMax;
                }

                if (localMax < 0)
                {
                    localMax = 0;
                }
            }
            Console.WriteLine(globalMax);
        }

        // Large File input test for Kadane
        public void KadaneAlgorithm()
        {

            string file = @"C:\Users\002C27744\Downloads\fileInput.txt";
            long count = 0;
            string str = File.ReadAllText(file);
            string[] value = str.Split(' ');

            int[] ints = new int[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                ints[i] = int.Parse(value[i]);
                count += int.Parse(value[i]);

            }
            Console.WriteLine(count);
            //  MaxSubArraySum(ints);
        }

        /// <summary>
        /// Dutch National Flag Algorithm
        /// </summary>
        public void Sort012()
        {
            string file = @"C:\Users\002C27744\Downloads\fileInput-Dutch.txt";
            string str = File.ReadAllText(file);
            string[] value = str.Split(' ');

            //int[] arr = new int[value.Length];
            //for (int i = 0; i < value.Length; i++)
            //{
            //    arr[i] = int.Parse(value[i]);
            //   // count += int.Parse(value[i]);

            //}
            int[] arr = { 0, 0, 1, 0, 2 };

            int low = 0; // used to track 0
            int mid = 0; // used to track 1
            int high = arr.Length - 1; // used to track 2

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    // Swap arr[low] and arr[mid]
                    case 0:
                        (arr[low], arr[mid]) = (arr[mid], arr[low]);
                        low++;
                        mid++;
                        break;

                    // increase mid by 1
                    case 1:
                        mid++;
                        break;

                    // swap arr[mid] and arr[high]
                    case 2:
                        (arr[mid], arr[high]) = (arr[high], arr[mid]);
                        high--;
                        break;
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i);
            }

        }

        public void CanJump()
        {
            int temp = 1;
            temp = +1;
            Console.WriteLine(temp);

            int[] nums = { 2, 3, 1, 1, 4 };
         
            int jump = 0;
            for (int i = 0; i < nums.Length;i++)
            {
                if (i > jump)
                {
                    Console.WriteLine("False");
                }
                jump = Math.Max(jump, i+nums[i]);

                if (jump >= nums.Length - 1)
                {
                    Console.WriteLine("true");
                }
               
            }
            Console.WriteLine("False");
        }
    }
}