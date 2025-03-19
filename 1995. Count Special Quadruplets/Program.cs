

int[] numss = new int[] { 1,1,1,3,5};

CountQuadruplets(numss);

int CountQuadruplets(int[] nums)
{
    var quad = 4;
	for (int j = 0; j < nums.Length; j++)
    {
        for (int i = j; i < quad; i++)
        {
            if (i < nums.Length)
            {
                Console.Write(nums[i]);
            }
        }
        quad++;
        Console.WriteLine();
    }

    throw new NotImplementedException();
}