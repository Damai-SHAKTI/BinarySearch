// Solution in C#
using System;

namespace ConsoleApp
{
    public class Solution
    {
  
        public static void Main(string[] args)
        {
            int[] arr = { 0, 4, 7, 8, 10, 12 };
            BinarySearch(arr, 8);
        }
        public static void BinarySearch(int[] arr, int target)
        {
            int middle = 0, left = 0, right = arr.Length - 1;
            bool isTargetFound = false;

            while (left <= right) {
                middle = ((left + right) / 2);
                if (arr[middle] == target)
                {
                    Console.WriteLine("{0} is at index {1}", target, middle);
                    isTargetFound = true;
                    break;
                }
                else if (arr[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (!isTargetFound)
            {
                Console.WriteLine("Target does not exist in array");
            }

        }

    }

}
