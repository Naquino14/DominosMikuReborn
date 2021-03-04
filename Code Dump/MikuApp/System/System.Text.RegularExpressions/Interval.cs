namespace System.Text.RegularExpressions
{
	internal struct Interval : IComparable
	{
		public int low;

		public int high;

		public bool contiguous;

		public static Interval Empty => (Interval)/*Error near IL_0001: Stack underflow*/;

		public bool IsDiscontiguous => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsSingleton => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsEmpty => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public int Size => (int)/*Error near IL_0001: Stack underflow*/;

		public Interval(int low, int high)
		{
		}

		public bool IsDisjoint(Interval i)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool IsAdjacent(Interval i)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Contains(Interval i)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Contains(int i)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool Intersects(Interval i)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void Merge(Interval i)
		{
		}

		public int CompareTo(object o)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
