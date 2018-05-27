using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence__LIS_
{
    class LongestIncreasingSubsequenceLIS
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int[] len = new int[sequence.Length];   
            int[] prev = new int[sequence.Length];  
            int maxLen = 1;
            int lastIndex = 0;
            
            for (int currentIndex = 0; currentIndex < sequence.Length; currentIndex++)
            {
                len[currentIndex] = 1;
                prev[currentIndex] = -1;
                for (int prevIndex = 0; prevIndex < currentIndex; prevIndex++)
                {
                    if (sequence[prevIndex] < sequence[currentIndex] &&
                        len[prevIndex] >= len[currentIndex])
                    {
                        len[currentIndex]++;
                        prev[currentIndex] = prevIndex;
                    }
                    if (len[currentIndex] > maxLen)
                    {
                        maxLen = len[currentIndex];
                        lastIndex = currentIndex;
                    }
                }
            }
            List<int> longestIncreasingSeq = GetLongestIncreasingSequence(sequence, prev, lastIndex);
            Console.WriteLine(string.Join(" ", longestIncreasingSeq));
        }

        private static List<int> GetLongestIncreasingSequence(int[] sequence, int[] prev, int lastIndex)
        {
            
            List<int> longestIncreasingSeq = new List<int>();
            while (lastIndex != -1)
            {
                longestIncreasingSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestIncreasingSeq.Reverse();
            return longestIncreasingSeq;
        }
    }
}
