



using System.Text;

var test = ReverseWords("a good   example");

string ReverseWords(string s)
{
	string[] stringArr = s.Split(' ');
	var sb = new StringBuilder();

	for (int i = stringArr.Length - 1; i >= 0; i--)
	{
		if (stringArr[i] != string.Empty)
		{
            sb.Append(string.Format("{0} ", stringArr[i]));
        }
    }

    return sb.ToString().Trim();
}