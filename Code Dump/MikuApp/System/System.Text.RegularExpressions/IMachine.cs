namespace System.Text.RegularExpressions
{
	internal interface IMachine
	{
		Match Scan(Regex regex, string text, int start, int end);

		string[] Split(Regex regex, string input, int count, int startat);
	}
}
