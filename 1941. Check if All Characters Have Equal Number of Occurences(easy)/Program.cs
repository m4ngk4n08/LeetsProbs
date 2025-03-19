

using System.Linq;

var test = AreOccurrencesEqual("poging lamig");
Console.WriteLine();

static bool AreOccurrencesEqual(string s)
{
	var splitDict = new Dictionary<char, int>();

	for (int i = s.Length - 1; i >= 0; i--)
	{
		Console.Write(s[i]);
	}

	foreach (var letter in s)
	{
		if (!splitDict.ContainsKey(letter))
		{
			splitDict.Add(letter, 1);
		}
		else
		{
			splitDict[letter]++;
		}
	}

	return new HashSet<int>(splitDict.Values).Count == 1;
}
RevStr("poging lamig");
static void RevStr(string s, int count = 1)
{
	if (s.Length < count)
	{
		return;
	}
	Console.Write(s[s.Length - count]);
	RevStr(s, count += 1);
}
