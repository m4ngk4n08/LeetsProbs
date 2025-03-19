

var test = TwoSum([3,2,4], 6);

int[] TwoSum(int[] nums, int target)
{
    var numsDict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int kNum = target - nums[i];

        if (numsDict.ContainsKey(kNum))
        {
            return new int[] { numsDict[kNum], i };
        }
        else
        {
            if (!numsDict.ContainsKey(nums[i]))
                numsDict[nums[i]] = i;
        }

    }

    return [];
}