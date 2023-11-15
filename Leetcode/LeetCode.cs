using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class LeetCode
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary that maps each number to its index
            Dictionary<int, int> dict = new Dictionary<int, int>();
            // Loop through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement
                int complement = target - nums[i];
                // Check if the complement exists in the dictionary
                if (dict.ContainsKey(complement))
                {
                    // Return the indices of the current number and the complement
                    int[] n = new int[] { dict[complement] + 1, i + 1 };
                    return n;
                }
                // Add the current number and its index to the dictionary
                dict[nums[i]] = i;
            }
            // If no solution is found, return an empty array
            return new int[] { };
        }
        public static int[] TwoSumPlusOne(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                if (nums[left] + nums[right] > target) right--;
                else left++;
            }
            return new int[] { };
        }
        public static bool IsAnagram(string s, string t)
        {
            if (s == t) return true;
            if (s.Length != t.Length) return false;

            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            Array.Sort(sChars);
            Array.Sort(tChars);

            string newS = new string(sChars);
            string newT = new string(tChars);
            return newS.Equals(newT);
            //s = String.Concat(s.OrderBy(c => c));
            //t = String.Concat(t.OrderBy(c => c));
            //return s == t ? true : false;
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
            //return new HashSet<int>(nums).Count < nums.Length;
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var map = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string sortedString = new string(chars);
                if (!map.ContainsKey(sortedString))
                {
                    map.Add(sortedString, new List<string>());
                }
                map[sortedString].Add(strs[i]);
            }
            return map.Values.ToList();
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            var products = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var numsExcept = new List<int>(nums).Where(x => x != nums[i]).DefaultIfEmpty().ToList();
                products[i] = numsExcept.Aggregate((x, y) => x * y);
            }
            //int prefix = 1, postfix = 1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    products[i] = prefix;
            //    prefix *= nums[i];
            //}
            //for (int i = nums.Length - 1; i >= 0; i--)
            //{
            //    products[i] *= postfix;
            //    postfix *= nums[i];
            //}
            return products;
        }
        public static bool IsPalindrome(string s)
        {
            s = String.Concat(s.Where(char.IsLetterOrDigit)).ToLower();
            return s.Reverse().SequenceEqual(s);
        }
    }
}
