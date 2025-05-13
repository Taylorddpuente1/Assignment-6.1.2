using System.Globalization;

namespace AssignmentThree
{
    class Program
    {
        static void MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0;
            // moving non zeroes forward
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    if (i != nonZeroIndex)
                    {
                        nums[i] = 0;
                    }
                    nonZeroIndex++;
                }
            }
        }

        static void Main()
        {
            Console.WriteLine(" Please input nums: ");
            string input = Console.ReadLine();

            int[] nums = Array.ConvertAll(input.Split(','), int.Parse);

            MoveZeroes(nums);

            Console.WriteLine("Output: [" + string.Join(", ", nums) + "]");

        }
    }
}
