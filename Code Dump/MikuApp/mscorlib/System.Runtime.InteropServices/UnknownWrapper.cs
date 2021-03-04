namespace System.Runtime.InteropServices
{
	/// <summary>Wraps objects the marshaler should marshal as a VT_UNKNOWN.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class UnknownWrapper
	{
		private object InternalObject;

		/// <summary>Gets the object contained by this wrapper.</summary>
		/// <returns>The wrapped object.</returns>
		public object WrappedObject => (object)/*Error near IL_0001: Stack underflow*/;
	}
}
