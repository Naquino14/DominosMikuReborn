using System.Collections;

namespace System.Text.RegularExpressions
{
	internal class IntervalCollection : ICollection, IEnumerable
	{
		public delegate double CostDelegate(Interval i);

		private class Enumerator : IEnumerator
		{
			private IList list;

			private int ptr;

			public object Current => (object)/*Error near IL_0001: Stack underflow*/;

			public Enumerator(IList list)
			{
			}

			public bool MoveNext()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public void Reset()
			{
			}
		}

		private ArrayList intervals;

		public Interval this[int i] => (Interval)/*Error near IL_0001: Stack underflow*/;

		public int Count => (int)/*Error near IL_0001: Stack underflow*/;

		public bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		public void Add(Interval i)
		{
		}

		public void Normalize()
		{
		}

		public IntervalCollection GetMetaCollection(CostDelegate cost_del)
		{
			return (IntervalCollection)/*Error near IL_0001: Stack underflow*/;
		}

		private void Optimize(int begin, int end, IntervalCollection meta, CostDelegate cost_del)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
