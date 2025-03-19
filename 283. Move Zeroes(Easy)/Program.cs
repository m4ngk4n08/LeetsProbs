

//[0 1 0 3 12]
//1 0 0 3 12

MoveZeroes([1, 0, 0, 3, 12]);
void MoveZeroes(int[] nums)
{
	int zeroIdx = 0;
	bool hasZeroIdx = false;
	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] == 0 && !hasZeroIdx)
		{
			zeroIdx = i;
			hasZeroIdx = true;
		}
		else if (nums[i] != 0 && hasZeroIdx)
		{
            nums[zeroIdx] = nums[i];
            nums[i] = 0;
            zeroIdx++;
        }

		// Tuple swapping
        //if (nums[i] != 0)
        //{
        //    (nums[i], nums[zeroIdx]) = (nums[zeroIdx], nums[i]);
        //    zeroIdx++;
        //}
    }
}
