using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Defines the attributes that can be associated with a property. These attribute values are defined in corhdr.h.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum PropertyAttributes
	{
		/// <summary>Specifies that no attributes are associated with a property.</summary>
		None = 0x0,
		/// <summary>Specifies that the property is special, with the name describing how the property is special.</summary>
		SpecialName = 0x200,
		/// <summary>Specifies a flag reserved for runtime use only.</summary>
		ReservedMask = 0xF400,
		/// <summary>Specifies that the metadata internal APIs check the name encoding.</summary>
		RTSpecialName = 0x400,
		/// <summary>Specifies that the property has a default value.</summary>
		HasDefault = 0x1000,
		/// <summary>Reserved.</summary>
		Reserved2 = 0x2000,
		/// <summary>Reserved.</summary>
		Reserved3 = 0x4000,
		/// <summary>Reserved.</summary>
		Reserved4 = 0x8000
	}
}
