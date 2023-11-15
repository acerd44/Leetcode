using System.Threading.Channels;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LeetCode.IsAnagram("aa", "a"));
            //Console.WriteLine(LeetCode.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
            //Console.WriteLine(LeetCode.ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
            //Console.WriteLine(LeetCode.ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
            //Console.WriteLine(LeetCode.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
            //int[] lol = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            //var lolSet = new HashSet<int>(lol);
            //Console.WriteLine(lolSet.Count);
            //Console.WriteLine(lol.Length);
            //Console.WriteLine(LeetCode.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }));
            //int[] lol = { 1, 2, 3, 4 };
            //int[] xd = LeetCode.ProductExceptSelf(lol);
            //foreach (var item in xd)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(LeetCode.IsPalindrome("A man, a plan, a canal: Panama"));
            var twoSum = new int[] { 1, 3, 4, 5, 7, 10, 11 };
            var result = LeetCode.TwoSumPlusOne(twoSum, 9);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}