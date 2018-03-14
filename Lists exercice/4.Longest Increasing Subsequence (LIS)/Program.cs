using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sequence = new List<int>();
            int [] len = new int[nums.Count];
            int [] prev = new int[nums.Count];
            int lenMax = 0;
            int lastIndex = -1;
            
            for (int p = 0; p<nums.Count; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int left = 0; left<p; left++)
                {
                    if (nums[left] < nums[p] && len[left] + 1 > len[p])
                    {
                        len[p] = len[left] + 1;
                        prev[p] = left;
                    }
                }

                if (len[p] > lenMax)
                {
                    lenMax = len[p];
                    lastIndex = p;
                }
            }
            
            while (lastIndex != -1)
            {
                sequence.Add(nums[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            sequence.Reverse();
            foreach (var num in sequence)
            {
                Console.Write(num + " ");
            }
        }
    }
}