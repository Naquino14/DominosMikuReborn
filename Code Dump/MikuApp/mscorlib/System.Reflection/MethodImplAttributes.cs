using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Specifies flags for the attributes of a method implementation.</summary>
	[Serializable]
	[ComVisible(true)]
	public enum MethodImplAttributes
	{
		/// <summary>Specifies flags about code type.</summary>
		CodeTypeMask = 3,
		/// <summary>Specifies that the method implementation is in Microsoft intermediate language (MSIL).</summary>
		IL = 0,
		/// <summary>Specifies that the method implementation is native.</summary>
		Native = 1,
		/// <summary>Specifies that the method implementation is in Optimized Intermediate Language (OPTIL).</summary>
		OPTIL = 2,
		/// <summary>Specifies that the method implementation is provided by the runtime.</summary>
		Runtime = 3,
		/// <summary>Specifies whether the method is implemented in managed or unmanaged code.</summary>
		ManagedMask = 4,
		/// <summary>Specifies that the method is implemented in unmanaged code.</summary>
		Unmanaged = 4,
		/// <summary>Specifies that the method is implemented in managed code. </summary>
		Managed = 0,
		/// <summary>Specifies that the method is not defined.</summary>
		ForwardRef = 0x10,
		/// <summary>Specifies that the method signature is exported exactly as declared.</summary>
		PreserveSig = 0x80,
		/// <summary>Specifies an internal call.</summary>
		InternalCall = 0x1000,
		/// <summary>Specifies that the method is single-threaded through the body. Static methods (Shared in Visual Basic) lock on the type, whereas instance methods lock on the instance. You can also use the C# lock statement or the Visual Basic Lock function for this purpose. </summary>
		Synchronized = 0x20,
		/// <summary>Specifies that the method cannot be inlined.</summary>
		NoInlining = 8,
		/// <summary>Specifies a range check value.</summary>
		MaxMethodImplVal = 0xFFFF
	}
}
