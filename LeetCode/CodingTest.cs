using System.Diagnostics;
using System.Text.RegularExpressions;
namespace Coding
{
    class GMS
    {
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

        public void OccuranceInStringArray(){
            string[] str = new string[] { "a", "aa", "bbb", "aaabb" };

            for (int i = 0; i < str.Length; i++)
            {


            }


        }

        public void PowerOf10()
        {

            int num = 500;

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

        // Remove Duplicate from Sorted Array
        public int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j++] = nums[i];
                }

            }
            nums[j++] = nums[nums.Length - 1];
            return j;
        }

        // Longest Common Prefix
        public string Solution(string[] str)
        {

            if (str.Length == 0) return "";

            string prefix = str[0];

            for (int i = 1; i < str.Length; i++)
            {

                while (str[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
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

        // Palindrome String
        public bool ValidPalindrome(){

            string str = "A man, a plan, a canal: Panama";

          //  str = Regex.Replace(str.ToLower(),"[^a-zA-Z0-9]","");

          int left = 0; // left pointer
          int right = str.Length -1; // right pointer

          while(left < right){
            if(!char.IsLetterOrDigit(str[left])){
                    left++;
            }
            else if(!char.IsLetterOrDigit(str[right])){
                right--;
            }
            else{
                if(char.ToLower(str[left]) != char.ToLower(str[right])){
                    return false;
                }
                left++;
                right--;                
            }
          }
            
        return true;  
        }

        // Index of First Occurrence in string
        public int FirstOccurence()
        {
            //   string haystack = "mississippi";
            //  string needle = "issip";
            return default;
        }

        // Valid Anagram - matching number of character in 2 string
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
                dict[nums[i]] = i;
            }



        }

    }


}