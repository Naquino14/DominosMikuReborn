namespace System.Text.RegularExpressions
{
	internal abstract class BaseMachine : IMachine
	{
		protected bool needs_groups_or_captures;

		public virtual string[] Split(Regex regex, string input, int count, int startat)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		public virtual Match Scan(Regex regex, string text, int start, int end)
		{
			return (Match)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
