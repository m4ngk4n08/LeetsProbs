




using System.Text;
 var test = LengthOfLongestSubstring("davdf");
Console.WriteLine(test);
int LengthOfLongestSubstring(string s)
{
	int maxLength = 0;
	var left = 0;
	var letHashset = new HashSet<char>();

	for (int right = 0; right < s.Length; right++)
	{

		while (letHashset.Contains(s[right]))
		{
			letHashset.Remove(s[left]);
			left++;
		}

		letHashset.Add(s[right]);
		maxLength = Math.Max(maxLength, right - left + 1);
	}

	return maxLength;
}


SubArray(new int[] { 1, 2, 3, 4, 5 });

void SubArray(int[] s)
{
	for (int i = 0; i < s.Length; i++)
	{
		for (int j = i; j < s.Length; j++)
		{
            Console.WriteLine(string.Join(" ", s[i..(j + 1)]));
		}
	}
}