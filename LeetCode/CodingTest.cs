using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;

namespace Coding
{
    class GMS
    {
        // String - No of Character
        public void NoOfCharacter()
        {

            string str = "aabbbc";

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            foreach (KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }


        }

        public void FirstNonRepetingCharbyArray()
        {

            string str = "paddff";

            int[] chars = new int[256];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                chars[str[i]]++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (chars[str[i]] == 1)
                {
                    Console.WriteLine(str[i]);
                    break;
                }
            }

        }

        public void FirstNonRepetingCharbyDict()
        {

            string str = "aabbbbcddd";

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }


        }

        public void OccuranceInStringArray()
        {
            string[] str = new string[] { "a", "aa", "bbb", "aaabb" };

            for (int i = 0; i < str.Length; i++)
            {


            }


        }

        public void PowerOf10()
        {

            int num = 1000;

            while (num % 10 == 0 && num != 0)
            {
                num = num / 10;

            }
            if (num == 1)
            {
                Console.WriteLine("Power of 10");
            }
            else
            {
                Console.WriteLine("Not a Power of 10");
            }

        }

        // String - Longest common Sub String
        // Take three variable, count,index and Max
        public void LongestCommonSubString()
        {
            string str = "aabbcccccccc";
            int count = 1;
            int index = -1;
            int max = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > max)
                {
                    max = count;
                    index = i - max + 1;
                }

            }
            Console.WriteLine($"{index},{index + max - 1}");
        }

        public void SplitDictionary()
        {
            string str = "A=1&B=1&C=1&A=2";

            string[] arr = str.Split('&');

            Dictionary<string, object> dict = new Dictionary<string, object>();

            foreach (string c in arr)
            {
                var item = c.Split('=');
                string chars = item[0];
                string count = item[1];

                if (dict.ContainsKey(chars))
                {
                    dict[chars] = count;
                }
                else
                {
                    dict.Add(chars, count);
                }

            }

        }

        public void MaxArea()
        {

            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int Area = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    Area = Math.Max(Area, Math.Min(height[i], height[j]) *
                                    (j - i));
                }
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(Area);
        }

        public void MaxAreaUsingWhile()
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int Area = 0;
            int start = 0;
            int end = height.Length - 1;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            while (start < end)
            {
                if (height[start] < height[end])
                {
                    Area = Math.Max(Area, height[start] * (end - start));
                    start++;
                }
                else
                {
                    Area = Math.Max(Area, height[end] * (end - start));
                    end--;
                }

            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(Area);
        }

        public void LengthOfLongestSubstring()
        {
            //  string str = "abcabcbb"; //abc
            HashSet<char> set = new HashSet<char>();




        }

        // Remove Duplicate from Sorted Array - 1,1,2
        public int RemoveDuplicates()
        {
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 4 };
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j++] = nums[i];
                }

            }
            // for last element
            nums[j++] = nums[nums.Length - 1];
            return j;
        }

        // String - Longest Common Prefix
        public void LongestCommonPrefix()
        { 
            string[] str = { "geek","geeksforgeeks", "geeks","geezer"};

            if (str.Length == 0) Console.WriteLine(" ");

            string prefix = str[0];

            for (int i = 1; i < str.Length; i++)
            {
                // IndexOf will fing the prefix in str[i]
                while (str[i].IndexOf(prefix) != 0)
                {
                    // Decrease prefix by 1
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            Console.WriteLine(prefix);
        }

        // Palindrome Number
        public bool IsPalindrome(int x)
        {
            int number = x;
            int reverse = 0;
            if (x < 0)
            {
                return false;
            }

            else
            {
                int reminder;

                while (x > 0)
                {
                    reminder = x % 10;
                    reverse = (reverse * 10) + reminder;
                    x = x / 10;
                }
            }
            if (number == reverse)
                return true;


            return false;
        }

        // String - Palindrome String
        public bool ValidPalindrome()
        {

            string str = "A man, a plan, a canal: Panama";

            //  str = Regex.Replace(str.ToLower(),"[^a-zA-Z0-9]","");

            int left = 0; // left pointer
            int right = str.Length - 1; // right pointer

            while (left < right)
            {
                if (!char.IsLetterOrDigit(str[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(str[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(str[left]) != char.ToLower(str[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }

            return true;
        }

        // String - Index of First Occurrence in string
        public int FirstOccurence()
        {
            //   string haystack = "mississippi";
            //  string needle = "issip";
            return default;
        }

        // String - Valid Anagram - matching number of character in 2 string
        public void IsAnagram()
        {
            string s = "anagram";
            string t = "nagaram";

            Dictionary<char, int> dict = new Dictionary<char, int>();

            var timer = new Stopwatch();
            timer.Start();

            foreach (char c1 in s)
            {
                if (dict.ContainsKey(c1))
                    dict[c1]++;

                else
                    dict[c1] = 1;
            }
            foreach (char c2 in t)
            {
                if (dict.ContainsKey(c2))
                    dict[c2]--;
                else
                    Console.WriteLine("False");
            }
            foreach (int value in dict.Values)
            {
                if (value != 0)
                    Console.WriteLine("False");
            }
            Console.WriteLine("True");

            timer.Stop();
            long timetaken = timer.ElapsedMilliseconds;

            Console.WriteLine(timetaken);
        }

        // Contains Duplicate
        public bool ContainsDuplicate()
        {
            int[] nums = { 1, 2, 3, 4, 1, 4 };

            HashSet<int> set = new HashSet<int>();

            foreach (int n in nums)
            {
                if (set.Contains(n))
                {
                    return true;
                }
                else
                    set.Add(n);

            }
            return false;


        }

        // Two Sum
        public void TwoSum()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;

            Dictionary<int, int> dict = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                {
                    Console.WriteLine("{0} {1}", dict[diff], i);
                }
                // Saving Index
                dict[nums[i]] = i; 
            }



        }

        // Sliding Window - Best Time to Buy and Sell Stock
        public int BestTimeToBuy()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int buy = 0;
            int sell = 1;
            int maxP = 0;

            while (sell < prices.Length)
            {
                if (prices[sell] > prices[buy])
                {
                    int profit = prices[sell] - prices[buy];
                    if (maxP < profit)
                    {
                        maxP = profit;
                    }

                }
                else
                {
                    buy = sell;

                }
                sell++;
            }
            return maxP;


        }

        // Array - Replace Elements with greatest element on Right Side
        public void ReplaceElements()
        {
            int[] arr = { 17, 18, 5, 4, 6, 1 };
            int max = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int newMax = Math.Max(arr[i], max);
                arr[i] = max;
                max = newMax;
            }

            // Brute Force
            // for(int i=0 ;i<arr.Length;i++){

            //     for(int j=i+1;j<arr.Length;j++){
            //         if(arr[j] > max){
            //             max = arr[j];
            //         }

            //     }
            //         arr[i] = max;
            //         max = -1;
            // }
        }

        // String - Is Subsequence, relative order should be maintained
        public bool IsSubsequence()
        {
            string s = "abc";
            string t = "ahbgdc"; // Yes
            string u = "ahcgdb"; // No
            Stack<char> stk = new();

            for (int j = 0; j < s.Length; j++)
            {
                stk.Push(s[j]);
            }

            for (int i = t.Length - 1; i >= 0; i--)
            {
                if (stk.Count == 0)
                {
                    return true;
                }
                else if (t[i] == stk.Peek() && stk.Count > 0)
                    stk.Pop();

            }

            return false;
        }

        // Two Pointer -Move Zero    
        public void MoveZero()
        {
            int[] nums = { 0, 1, 0, 3, 12 };

            // left will take care of non zero numbers and right will take care of 0's
            int left = 0;


            int val;
            for (int right = 0; right < nums.Length; right++)
            {
                val = nums[right];
                if (val != 0)
                {
                    nums[right] = 0;
                    nums[left] = val;
                    left++;
                }
            }
        }

        // Array - Number of Unique Emails
        public void NumUniqueEmails()
        {
            HashSet<string> uniqueEmail = new();

            string[] emails = {
                                "test.email+alex@leetcode.com",
                                "test.e.mail+bob.cathy@leetcode.com",
                                "testemail+david@lee.tcode.com"
                                };

            foreach (string email in emails)
            {
                string[] emailNames = email.Split('@');
                string localName = emailNames[0];
                string domainName = emailNames[1];

                if (localName.Contains('+'))
                {
                    localName = localName.Split('+')[0];
                }
                localName = localName.Replace(".", String.Empty);
                string forwardEmail = localName + "@" + domainName;
                uniqueEmail.Add(forwardEmail);
            }
            Console.WriteLine(uniqueEmail.Count());
        }

        // Array - FLowerbed
        public bool CanPlaceFlowers()
        {
            int[] arr = { 1, 0, 0, 0, 1, 0, 1 };
            int N = arr.Length;
            int n = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((i == 0 || arr[i - 1] == 0) && arr[i] == 0 && (i == arr.Length - 1 || arr[i + 1] == 0))
                {
                    arr[i] = 1;
                    n--;
                }
            }
            return n <= 0;

        }

        //Array - Largest Element

        public void LargestElementArray()
        {
            int[] arr = { 2, 5, 1, 3, 0, 3, 13, 43, 2, 54, 33, 200 };

            int end = arr.Length - 1;
            int start = 0;
            int max = 0;

            while (start <= end)
            {
                if (arr[start] < arr[end] && max < arr[end])
                {
                    max = arr[end];
                }
                else if (arr[start] > arr[end] && max < arr[start])
                {
                    max = arr[start];
                }
                start++;
                end--;

            }
            Console.WriteLine(max);
        }

        public void LargestElementArrayForLoop()
        {
            int[] arr = { 2, 5, 1, 3, 0, 3, 13, 43, 2, 54, 33, 200 };

            
            int max = 0;

          for(int i = 0; i< arr.Length;i++)
          {
               if(arr[i] > max){
                max = arr[i];
               }
          }
           Console.WriteLine(max);
            }
           
        

        // Array - Second Smallest and Second Largest
        public void SecondSmallestAndSecondLargestArray()
        {
            int[] arr = { 1, 2, 4, 7, 7, 5 };

            Array.Sort(arr);
            // THis wont work for sorted array
            Console.WriteLine($"{arr[1]},{arr[arr.Length - 2]}");


        }
        
        // Array
        public void IsArraySorted()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            bool result = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    result = false;
                    break;

                }
            }
            Console.WriteLine(result == false ? "False" : "True");

        }

        public void UnionOfArray()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 3, 4, 4, 5, 11, 12 };

            SortedSet<int> set = new SortedSet<int>();

            foreach (int i in arr1)
            {
                set.Add(i);
            }
            foreach (int i in arr2)
            {
                set.Add(i);
            }

            int[] arrResult = new int[set.Count];

            int index = 0;

            foreach (var item in set)
            {
                arrResult[index] = item;
                index++;
            }
        }

        public void AppearOnceInArray()
        {
            int[] arr = { 4, 1, 2, 1, 2 ,3};

            HashSet<int> set = new HashSet<int>();
           
            foreach (int i in arr)
            {
                if (set.Contains(i))
                {
                    set.Remove(i);
                }
                else
                {
                    set.Add(i);
                }
            }
            int value = set.Single();
            Console.WriteLine(value);

        }

        public void MaximumOneInArray()
        {
            int[] arr = { 1, 1, 0, 1, 1, 1 };

            int count = 0;

            foreach (int i in arr)
            {
                if (i == 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(count);
        }

        public void LongestSubArray()
        {
            int[] arr = { 2, 3, -5, 1, 9 };

            int localMax = 0;
            int globalMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                localMax = Math.Max(localMax + arr[i], arr[i]);

                if(localMax > globalMax)
                {
                    globalMax = localMax;
                }
                if(localMax < 0)
                {
                    localMax = 0;
                }

            }
            Console.WriteLine(globalMax);
        }
    
        public void ReverseVowels()
        {
            StringBuilder s = new("hello");

            int start = 0;
            int end = s.Length - 1;

            while(start < end)
            {
                if (!IsVowel(s[start]))
                {
                    start++;
                    continue;
                }
                if (!IsVowel(s[end]))
                {
                    end--;
                    continue;
                }

                // Swap
                (s[end], s[start]) = (s[start], s[end]);

                start++;
                end--;
            }



        }

        private static bool IsVowel(char c)
        {
            return c == 'a' || c == 'A' || c == 'e'
                || c == 'E' || c == 'i' || c == 'I'
                || c == 'o' || c == 'O' || c == 'u'
                || c == 'U';
        }

        // Array - Alternate positive and negative number.
        public void RearrangebySign()
        {
            int[] arr = { 1,2,-3,-1,-2,3 };
            int n = arr.Length;

            int[] positive = new int[n / 2];
            int[] negative = new int[n / 2];

            int positiveIndex = 0;
            int negativeIndex = 0;

            // Separate positive and negative elements into separate arrays
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    positive[positiveIndex++] = num;
                   
                }
                else
                {
                    negative[negativeIndex++] = num;
                }
            }

            // Merge positive and negative arrays alternatively
            int arrIndex = 0;
            for (int i = 0; i < positiveIndex; i++)
            {
                arr[arrIndex++] = positive[i];
                arr[arrIndex++] = negative[i];
            }




        }
    
        // String - Reverse Words in a String
        public void ReverseWords()
        {
            string s = "a good   example";
            string b = s.Trim();

            string[] str = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int start = 0;
            int end = str.Length-1;

            while (start < end)
            {
                (str[start], str[end]) = (str[end], str[start]);
                start++;
                end--;
            }
            string a = string.Join(' ', str);

            Console.WriteLine(a);
        }
    
        // String - find the frequency of each character
        // and return string with combination of char and its fequency
        public void FrequencyOfLetter()
        {
            string s = "aaaabbbccc";
            Dictionary<char, int> dict = new();

            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            StringBuilder str = new StringBuilder();

            foreach (KeyValuePair<char, int> item in dict)
            {
                str.Append(Convert.ToString(item.Key)+item.Value);
            }
           
        }
   
        public int PalindromicArray()
        {
            int[] arr = { 111, 222, 333, 444 };
            foreach (int i in arr)
            {
                if (!isPalindrome(i))
                {
                    return 0;
                }
            }
            return 1;
        }
        private bool isPalindrome(int i)
        {
            int num = i;
            int reverse = 0;
            while (num > 0)
            {
                int reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num = num / 10;
            }

            if (num == reverse)
            {
                return true;
            }
            return false;

        }

        public string isSubset()
        {
            int[] a1 = { 11, 7, 1, 13, 21, 3, 7, 3 };
            int[] a2 = { 11, 3, 7, 1, 7 };
            //Your code here
            Dictionary<int, int> dict = new Dictionary<int, int>();
            // Count occurrences of elements in a1
            foreach (int i in a2)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            // Check if elements in a2 are present in a1 and decrement their count
            foreach (int j in a1)
            {
                if (dict.ContainsKey(j))
                {
                    dict[j]--;
                }
               
            }

            // Check if all elements in a2 have been accounted for in a1
            foreach (var kvp in dict)
            {
                if (kvp.Value > 0)
                {
                    return "No";
                }
            }

            return "Yes";
        }
    
        // Need to check
        public void MinimumJump()
        {
            int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };

            int count = 0;

            for (int i = 0; i < arr.Length;)
            {
                i = arr[i];
                count++;
            }
            Console.WriteLine(count);
        }
    
        public void IsStringRotation()
        {
            string s1 = "mightandmagic";
            string s2 = "andmagicmigth";
          
            if (s1.Length != s2.Length || s1.Length == 0)
            {
                Console.Write("Not");
            }

            string b = s1 + s1;
            bool isPresent = b.Contains(s2);

        }

        // DP
        public void LongestCommonSubsequence()
        {
        }

    }
}
