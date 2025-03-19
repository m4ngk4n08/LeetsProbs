




int[] nums = new int[] { 1, 1, 1, 3, 5 };
Console.WriteLine(CountKDifference(nums, 3));
int CountKDifference(int[] nums, int k)
{
	int n = nums.Length;
	int count = 0;

	for (int j = 0; j < nums.Length; j++)
	{
        for (int i = j; i < nums.Length; i++)
        {
            if (i < nums.Length - 1)
            {
                var test = nums[j] + nums[i + 1];
                if (nums.Contains(test))
                {
                    count++;
                }
            }
        }
    }

	return count;
}