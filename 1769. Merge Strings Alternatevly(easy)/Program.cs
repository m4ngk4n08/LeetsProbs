using System.Linq;
using System.Text;


Console.WriteLine(MergeAlternately("pqrst", "abc"));

string MergeAlternately(string word1, string word2)
{
    var stringMerge = new StringBuilder();

    for (int i = 0; i < word1.Length && i < word2.Length; i++)
    {
        stringMerge.Append(string.Format("{0}{1}", word1[i] + word2[i]));
    }

    if (word1.Length > word2.Length)
    {
        stringMerge.Append(word1.Substring(word2.Length, Math.Abs(word1.Length - word2.Length)));
    }
    else
    {
        stringMerge.Append(word2.Substring(word1.Length, Math.Abs(word1.Length - word2.Length)));
    }

    return stringMerge.ToString();
}