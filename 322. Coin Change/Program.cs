


int CoinChange(int[] coins, int amount) {

	int sum = 0;
	int count = 0;
	for (int right = 0; right < coins.Length; right++)
	{

		while (sum < amount)
		{
			sum += coins[right];
			count++;
		}

		count--;
	}

    throw new NotImplementedException();
}