using System.Globalization;

namespace System
{
	[Serializable]
	internal sealed class CultureAwareComparer : StringComparer
	{
		private readonly bool _ignoreCase;

		private readonly CompareInfo _compareInfo;

		public CultureAwareComparer(CultureInfo ci, bool ignore_case)
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
