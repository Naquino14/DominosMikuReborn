using System.Collections;

namespace System.Text.RegularExpressions
{
	internal class FactoryCache
	{
		private class Key
		{
			public string pattern;

			public RegexOptions options;

			public Key(string pattern, RegexOptions options)
			{
			}

			public override int GetHashCode()
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public override bool Equals(object o)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public override string ToString()
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private int capacity;

		private Hashtable factories;

		private MRUList mru_list;

		public FactoryCache(int capacity)
		{
		}

		public void Add(string pattern, RegexOptions options, IMachineFactory factory)
		{
		}

		private void Cleanup()
		{
		}

		public IMachineFactory Lookup(string pattern, RegexOptions options)
		{
			return (IMachineFactory)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
