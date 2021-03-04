namespace System
{
	[Serializable]
	internal sealed class OrdinalComparer : StringComparer
	{
		private readonly bool _ignoreCase;

		public OrdinalComparer(bool ignoreCase)
		{
		}

		public override int Compare(string x, string y)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(string x, string y)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override int GetHashCode(string s)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
