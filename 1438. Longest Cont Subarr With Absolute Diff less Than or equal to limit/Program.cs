LongestSubarray(new int[] { 10, 1, 2, 4, 7, 2 }, 5);

int LongestSubarray(int[] nums, int limit)
{
    var count = 0;
    var maxCount = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i; j < nums.Length; j++)
        {
            if (Math.Abs(nums[i] - nums[j]) <= limit)
            {
                count++;
            }
            else
            {
                maxCount = Math.Max(maxCount, count);
                count = 0;
            }
        }

        maxCount = Math.Max(maxCount, count);
        count = 0;
    }

    return maxCount;
}