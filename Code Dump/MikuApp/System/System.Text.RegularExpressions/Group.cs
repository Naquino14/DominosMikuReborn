namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single capturing group. </summary>
	[Serializable]
	public class Group : Capture
	{
		internal static Group Fail;

		private bool success;

		private CaptureCollection captures;

		/// <summary>Gets a collection of all the captures matched by the capturing group, in innermost-leftmost-first order (or innermost-rightmost-first order if the regular expression is modified with the <see cref="F:System.Text.RegularExpressions.RegexOptions.RightToLeft" /> option). The collection may have zero or more items.</summary>
		/// <returns>The collection of substrings matched by the group.</returns>
		public CaptureCollection Captures => (CaptureCollection)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the match is successful.</summary>
		/// <returns>true if the match is successful; otherwise, false.</returns>
		public bool Success => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal Group(string text, int index, int length, int n_caps)
		{
		}

		internal Group(string text, int index, int length)
		{
		}

		internal Group()
		{
		}
	}
}
