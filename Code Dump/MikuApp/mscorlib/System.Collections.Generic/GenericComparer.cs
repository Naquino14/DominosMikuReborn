namespace System.Collections.Generic
{
	[Serializable]
	internal sealed class GenericComparer<T> : Comparer<T> where T : IComparable<T>
	{
		public override int Compare(T x, T y)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
