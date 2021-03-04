using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Defines the attributes that can be associated with a parameter. These are defined in CorHdr.h.</summary>
	[Serializable]
	[ComVisible(true)]
	[Flags]
	public enum ParameterAttributes
	{
		/// <summary>Specifies that there is no parameter attribute.</summary>
		None = 0x0,
		/// <summary>Specifies that the parameter is an input parameter.</summary>
		In = 0x1,
		/// <summary>Specifies that the parameter is an output parameter.</summary>
		Out = 0x2,
		/// <summary>Specifies that the parameter is a locale identifier (lcid).</summary>
		Lcid = 0x4,
		/// <summary>Specifies that the parameter is a return value.</summary>
		Retval = 0x8,
		/// <summary>Specifies that the parameter is optional.</summary>
		Optional = 0x10,
		/// <summary>Specifies that the parameter is reserved.</summary>
		ReservedMask = 0xF000,
		/// <summary>Specifies that the parameter has a default value.</summary>
		HasDefault = 0x1000,
		/// <summary>Specifies that the parameter has field marshaling information.</summary>
		HasFieldMarshal = 0x2000,
		/// <summary>Reserved.</summary>
		Reserved3 = 0x4000,
		/// <summary>Reserved.</summary>
		Reserved4 = 0x8000
	}
}
