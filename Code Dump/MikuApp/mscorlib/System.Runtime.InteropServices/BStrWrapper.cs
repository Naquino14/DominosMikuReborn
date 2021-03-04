namespace System.Runtime.InteropServices
{
	/// <summary>Marshals data of type VT_BSTR from managed to unmanaged code. This class cannot be inherited.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class BStrWrapper
	{
		private string _value;

		/// <summary>Gets the wrapped <see cref="T:System.String" /> object to marshal as type VT_BSTR.</summary>
		/// <returns>The <see cref="T:System.String" /> object wrapped by <see cref="T:System.Runtime.InteropServices.BStrWrapper" />.</returns>
		public string WrappedObject => (string)/*Error near IL_0001: Stack underflow*/;
	}
}
