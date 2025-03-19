
var test = CanPlaceFlowers([1,0,0,0,0], 1);
Console.WriteLine(test);

bool CanPlaceFlowers(int[] flowerbed, int n)
{
	bool a = true;
	bool b = false;

    Console.WriteLine(a && b);

	for (int i = 0; i < flowerbed.Length; i++)
	{
		if (flowerbed[i] == 0 &&
			(i == 0 || flowerbed[i - 1] == 0) &&
			(i == flowerbed.Length - 1 || flowerbed[i + 1] == 0) 
			&& n != 0)
        {
			flowerbed[i] = 1;
			n--;
		}
	}
	return n == 0 ? true : false;
}

// 0,0,1,0,0,1,0,0,0,1