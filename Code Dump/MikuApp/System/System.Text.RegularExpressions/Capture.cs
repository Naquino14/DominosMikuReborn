namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single subexpression capture. </summary>
	[Serializable]
	public class Capture
	{
		internal int index;

		internal int length;

		internal string text;

		/// <summary>The position in the original string where the first character of the captured substring was found.</summary>
		/// <returns>The zero-based starting position in the original string where the captured substring was found.</returns>
		public int Index => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>The length of the captured substring.</summary>
		/// <returns>The length of the captured substring.</returns>
		public int Length => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the captured substring from the input string.</summary>
		/// <returns>The actual substring that was captured by the match.</returns>
		public string Value => (string)/*Error near IL_0001: Stack underflow*/;

		internal string Text => (string)/*Error near IL_0001: Stack underflow*/;

		internal Capture(string text)
		{
		}

		internal Capture(string text, int index, int length)
		{
		}

		/// <summary>Gets the captured substring from the input string.</summary>
		/// <returns>The actual substring that was captured by the match.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
