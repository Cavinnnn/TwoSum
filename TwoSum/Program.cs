using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target
        /// </summary>
        /// <param name="nums">Array of numbers</param>
        /// <param name="target">The target where the array must add up to</param>
        /// <returns>target numbers</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();
            var complement = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                var index = 0;

                if (complement > 0 && numsDictionary.TryGetValue(complement, out index))
                {
                    return new int[] { index, i };
                }

                if (numsDictionary.ContainsKey(nums[i]) == false)
                {
                    numsDictionary.Add(nums[i], i);
                }
                
            }

            return null;
        }

        static void Main(string[] args)
        {
            int[] _nums = { 2, 7, 11, 15 };

            var sumOfTarget = TwoSum(_nums, 6);

            Console.WriteLine($"[{sumOfTarget[0]}]" + $"[{sumOfTarget[1]}]");
        }
    }
}
