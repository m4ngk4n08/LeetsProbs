


var test = ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 2);

bool ContainsNearbyDuplicate(int[] nums, int k)
{
	for (int i = 0; i < nums.Length; i++)
	{
		for (int j = i + 1; j < nums.Length && j <= i + k; j++)
		{
            if (nums[i] == nums[j])
            {
                return true;
            }
        }
    }
	return false;
}


//Example 1:

//Input: nums = [1, 2, 3, 1], k = 3
//Output: true
//Example 2:

//Input: nums = [1, 0, 1, 1], k = 1
//Output: true
//Example 3:

//Input: nums = [1, 2, 3, 1, 2, 3], k = 2
//Output: false