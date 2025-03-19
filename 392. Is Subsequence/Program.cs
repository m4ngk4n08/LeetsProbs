


int[] letters = new int[26];


var trest = IsSubsequence("sadfasdf", "");
Console.WriteLine(trest);
bool IsSubsequence(string s, string t)
{
	int sPointer = 0;
	if ((s == string.Empty) || s == string.Empty && t == string.Empty) return true;
    for (int i = 0; i < t.Length; i++)
	{
		if (s[sPointer] == t[i])
		{
			sPointer++;
		}

		if (s.Length == sPointer)
		{
			return true;
		}
	}

    return false;
}