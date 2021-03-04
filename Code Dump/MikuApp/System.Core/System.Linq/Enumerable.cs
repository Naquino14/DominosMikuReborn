using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Linq
{
	public static class Enumerable
	{
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			return (IEnumerable<TResult>)/*Error near IL_0001: Stack underflow*/;
		}

		[DebuggerHidden]
		private static IEnumerable<TResult> CreateCastIterator<TResult>(IEnumerable source)
		{
			return (IEnumerable<TResult>)/*Error near IL_0001: Stack underflow*/;
		}

		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
		{
			return (TSource[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
