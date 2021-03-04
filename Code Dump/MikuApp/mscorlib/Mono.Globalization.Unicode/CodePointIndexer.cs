using System;

namespace Mono.Globalization.Unicode
{
	internal class CodePointIndexer
	{
		[Serializable]
		internal struct TableRange
		{
			public readonly int Start;

			public readonly int End;

			public readonly int Count;

			public readonly int IndexStart;

			public readonly int IndexEnd;

			public TableRange(int start, int end, int indexStart)
			{
			}
		}

		private readonly TableRange[] ranges;

		public readonly int TotalCount;

		private int defaultIndex;

		private int defaultCP;

		public CodePointIndexer(int[] starts, int[] ends, int defaultIndex, int defaultCP)
		{
		}

		public int ToIndex(int cp)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
