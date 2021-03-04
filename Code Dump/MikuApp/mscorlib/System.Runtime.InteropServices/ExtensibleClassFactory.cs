using System.Collections;

namespace System.Runtime.InteropServices
{
	/// <summary>Enables customization of managed objects that extend from unmanaged objects during creation.</summary>
	[ComVisible(true)]
	public sealed class ExtensibleClassFactory
	{
		private static Hashtable hashtable;

		static ExtensibleClassFactory()
		{
		}

		internal static ObjectCreationDelegate GetObjectCreationCallback(Type t)
		{
			return (ObjectCreationDelegate)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
