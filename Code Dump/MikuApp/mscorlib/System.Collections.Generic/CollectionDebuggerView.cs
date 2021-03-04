namespace System.Collections.Generic
{
	internal sealed class CollectionDebuggerView<T>
	{
		private readonly ICollection<T> c;
	}
	internal sealed class CollectionDebuggerView<T, U>
	{
		private readonly ICollection<KeyValuePair<T, U>> c;
	}
}
