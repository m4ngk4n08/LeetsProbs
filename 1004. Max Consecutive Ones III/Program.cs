






var test = LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2);
int LongestOnes(int[] nums, int k)
{
    int count = 0;
    int maxCount = 0;
    int left = 0;
    int zeroCount = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        count++;
        //expand right
        if (nums[i] == 0)
            zeroCount++;

        //shrink left
        while (zeroCount > k)
        {
            if (nums[left] == 0)
                zeroCount--;
            count--;
            left++;
        }
        maxCount = Math.Max(maxCount, count);
    }

    return maxCount;
}