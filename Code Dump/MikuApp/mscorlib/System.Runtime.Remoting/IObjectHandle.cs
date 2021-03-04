using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Defines the interface for unwrapping marshal-by-value objects from indirection.</summary>
	[Guid("C460E2B4-E199-412a-8456-84DC3E4838C3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IObjectHandle
	{
		/// <summary>Unwraps the object.</summary>
		/// <returns>The unwrapped object.</returns>
		object Unwrap();
	}
}
