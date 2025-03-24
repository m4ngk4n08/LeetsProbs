


string word1 = "uau"; string word2 = "ssx";
CloseStrings(word1, word2);

bool CloseStrings(string word1, string word2)
{
    var freqW1 = new Dictionary<char, int>();
    var freqW2 = new Dictionary<char, int>();

    if (word1.Length != word2.Length) return false;


    for (int i = 0; i < word1.Length; i++)
    {
        if (!word1.Contains(word2[i]) || !word2.Contains(word1[i])) return false;

        if (!freqW1.TryAdd(word1[i], 1))
            freqW1[word1[i]]++;

        if (!freqW2.TryAdd(word2[i], 1))
            freqW2[word2[i]]++;
    }

    return Enumerable.SequenceEqual(
            freqW1.Values.OrderBy(j => j),
            freqW2.Values.OrderBy(j => j)
            );
}