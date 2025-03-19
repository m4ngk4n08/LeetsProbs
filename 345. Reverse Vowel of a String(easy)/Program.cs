



using System.Text;
var test = ReverseVowels("IceCreAm");
string ReverseVowels(string s)
{
	string vows = "aeiouAEIOU";
	var sb = new StringBuilder();
	string filterVowel = string.Join(string.Empty, s.Where(vows.Contains).Reverse());

    var count = 0;
	for (int i = 0; i < s.Length; i++)
	{
		if (vows.Contains(s[i]))
		{
            sb.Append(string.Format("{0}", filterVowel[count++]));
		}
		else
		{
			sb.Append(s[i]);
		}	
	}

	return sb.ToString();
}