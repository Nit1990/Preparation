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
            int[] arr = { 2, 3, 1, 2, 4, 3 };
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
    }
}