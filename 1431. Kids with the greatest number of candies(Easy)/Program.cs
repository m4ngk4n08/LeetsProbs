


var test = KidsWithCandies([12,1,12], 10);
Console.WriteLine();

IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{
	int totalCandy = 0;
	int max = candies.Max();
	var outBool = new List<bool>();
	for (int i = 0; i < candies.Length; i++)
	{
		totalCandy = candies[i] + extraCandies;

		if (totalCandy >= max)
		{
			outBool.Add(true);

		}
		else
		{
			outBool.Add(false);
		}
	}

	return outBool;
}