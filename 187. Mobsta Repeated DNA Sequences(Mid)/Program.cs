

var test = FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");
Console.WriteLine();

IList<string> FindRepeatedDnaSequences(string s)
{
    var left = 0;
    var storedLet = new List<char>();
    var testDict = new Dictionary<string, int>();

    for (int right = 0; right < s.Length; right++)
    {

        while (storedLet.Count is 10)
        {
            storedLet.Remove(s[left]);
            left++;
        }

        storedLet.Add(s[right]);

        if (storedLet.Count is 10)
        {
            var countOccurence = string.Join(string.Empty, storedLet);
            if (testDict.ContainsKey(countOccurence))
            {
                testDict[countOccurence]++;
            }
            else
            {
                testDict.Add(countOccurence, 1);
            }
        }
    }

    return testDict.Where(j => j.Value >= 2).Select(j => j.Key).ToList();
}