

using System.Text;

var test = MaxVowels("aeiou", 2);
int MaxVowels(string s, int k)
{
	var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
	var count = 0;
	var maxCount = 0;

	for (int i = 0; i < k; i++)
	{
		if (vowels.Contains(s[i]))
		{
			count++;
		}
    }

    maxCount = Math.Max(maxCount, count);

    for (int j = 0; j + k < s.Length; j++)
	{

        if (vowels.Contains(s[j + k]))
            count++;

        if (vowels.Contains(s[j]))
            count--;

		maxCount = Math.Max(maxCount, count);

    }

	return maxCount;
}

//var test = s.ToString().Substring(j, k);
//var test1 = s.Substring(k, 1);
//var test2 = s.Substring(j, 1);