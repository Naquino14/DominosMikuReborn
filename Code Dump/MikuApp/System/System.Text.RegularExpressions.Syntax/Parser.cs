using System.Collections;

namespace System.Text.RegularExpressions.Syntax
{
	internal class Parser
	{
		private string pattern;

		private int ptr;

		private ArrayList caps;

		private Hashtable refs;

		private int num_groups;

		private int gap;

		public static int ParseDecimal(string str, ref int ptr)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int ParseOctal(string str, ref int ptr)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int ParseHex(string str, ref int ptr, int digits)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static int ParseNumber(string str, ref int ptr, int b, int min, int max)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static string ParseName(string str, ref int ptr)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public RegularExpression ParseRegularExpression(string pattern, RegexOptions options)
		{
			return (RegularExpression)/*Error near IL_0001: Stack underflow*/;
		}

		public int GetMapping(Hashtable mapping)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void ParseGroup(Group group, RegexOptions options, Assertion assertion)
		{
		}

		private Expression ParseGroupingConstruct(ref RegexOptions options)
		{
			return (Expression)/*Error near IL_0001: Stack underflow*/;
		}

		private bool ParseAssertionType(ExpressionAssertion assertion)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private void ParseOptions(ref RegexOptions options, bool negate)
		{
		}

		private Expression ParseCharacterClass(RegexOptions options)
		{
			return (Expression)/*Error near IL_0001: Stack underflow*/;
		}

		private bool ParseRepetitionBounds(out int min, out int max, RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private Category ParseUnicodeCategory()
		{
			return (Category)/*Error near IL_0001: Stack underflow*/;
		}

		private Expression ParseSpecial(RegexOptions options)
		{
			return (Expression)/*Error near IL_0001: Stack underflow*/;
		}

		private int ParseEscape()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private string ParseName()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool IsNameChar(char c)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private int ParseNumber(int b, int min, int max)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int ParseDigit(char c, int b, int n)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void ConsumeWhitespace(bool ignore)
		{
		}

		private void ResolveReferences()
		{
		}

		private void HandleExplicitNumericGroups(ArrayList explicit_numeric_groups)
		{
		}

		private static bool IsIgnoreCase(RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool IsMultiline(RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool IsExplicitCapture(RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool IsSingleline(RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool IsIgnorePatternWhitespace(RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool IsECMAScript(RegexOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private ArgumentException NewParseException(string msg)
		{
			return (ArgumentException)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
