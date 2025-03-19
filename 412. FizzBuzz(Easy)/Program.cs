



using System.Text;

var test = FizzBuzz(100);
Console.WriteLine();
IList<string> FizzBuzz(int n)
{
    var fizzBuzzDict = new Dictionary<int, string> { { 3, "fizz" }, { 5, "buzz" } };
	var outString = new List<string>();
	
	for (int i = 1; i <= n; i++)
	{

		var sb = new StringBuilder();

		foreach (var item in fizzBuzzDict)
		{
			if (i % item.Key == 0)
			{
				sb.Append(item.Value);
			}
		}

		outString.Add(sb.Length > 0 ? sb.ToString() : i.ToString());

	}

	return outString;
}