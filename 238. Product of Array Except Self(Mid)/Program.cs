


var test = ProductExceptSelf([1, 2, 3, 4]);
Console.WriteLine(test);
//int[] ProductExceptSelf(int[] nums)
//{
//	int[] outInt = new int[nums.Length];
//	for (int i = 0; i < nums.Length; i++)
//	{
//		var count = 0;
//		var totalCount = 1;
//		while (count < nums.Length)
//		{
//			if (count != i)
//			{
//				totalCount *= nums[count];
//			}
//			count++;
//		}

//		outInt[i] = totalCount;
//	}


//	return outInt;
//}

int[] ProductExceptSelf(int[] nums)
{
    int n = nums.Length;
    int[] output = new int[n];

    output[0] = 1;
    for (int i = 1; i < n; i++)
    {
        output[i] = output[i - 1] * nums[i - 1];

    }

    int suffix = 1;
    for (int i = n - 1; i >= 0; i--)
    {
        output[i] *= suffix;
        suffix *= nums[i];
    }

    return output;
}