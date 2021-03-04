namespace System.Collections.Generic
{
	[Serializable]
	internal sealed class GenericEqualityComparer<T> : EqualityComparer<T> where T : IEquatable<T>
	{
		public override int GetHashCode(T obj)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(T x, T y)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
