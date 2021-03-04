using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System
{
	internal struct MonoEnumInfo
	{
		internal class IntComparer : IComparer<int>, IComparer
		{
			public int Compare(object x, object y)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public int Compare(int ix, int iy)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		internal class LongComparer : IComparer<long>, IComparer
		{
			public int Compare(object x, object y)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public int Compare(long ix, long iy)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		internal class SByteComparer : IComparer<sbyte>, IComparer
		{
			public int Compare(object x, object y)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public int Compare(sbyte ix, sbyte iy)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		internal class ShortComparer : IComparer<short>, IComparer
		{
			public int Compare(object x, object y)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public int Compare(short ix, short iy)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		internal Type utype;

		internal Array values;

		internal string[] names;

		internal Hashtable name_hash;

		[ThreadStatic]
		private static Hashtable cache;

		private static Hashtable global_cache;

		private static object global_cache_monitor;

		internal static SByteComparer sbyte_comparer;

		internal static ShortComparer short_comparer;

		internal static IntComparer int_comparer;

		internal static LongComparer long_comparer;

		private static Hashtable Cache => (Hashtable)/*Error near IL_0001: Stack underflow*/;

		private MonoEnumInfo(MonoEnumInfo other)
		{
		}

		static MonoEnumInfo()
		{
		}

		[MethodImpl(4096)]
		private static extern void get_enum_info(Type enumType, out MonoEnumInfo info);

		internal static void GetInfo(Type enumType, out MonoEnumInfo info)
		{
		}
	}
}
