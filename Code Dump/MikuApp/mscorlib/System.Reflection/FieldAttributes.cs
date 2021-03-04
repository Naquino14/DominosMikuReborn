using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Specifies flags that describe the attributes of a field.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum FieldAttributes
	{
		/// <summary>Specifies the access level of a given field.</summary>
		FieldAccessMask = 0x7,
		/// <summary>Specifies that the field cannot be referenced.</summary>
		PrivateScope = 0x0,
		/// <summary>Specifies that the field is accessible only by the parent type.</summary>
		Private = 0x1,
		/// <summary>Specifies that the field is accessible only by subtypes in this assembly.</summary>
		FamANDAssem = 0x2,
		/// <summary>Specifies that the field is accessible throughout the assembly.</summary>
		Assembly = 0x3,
		/// <summary>Specifies that the field is accessible only by type and subtypes.</summary>
		Family = 0x4,
		/// <summary>Specifies that the field is accessible by subtypes anywhere, as well as throughout this assembly.</summary>
		FamORAssem = 0x5,
		/// <summary>Specifies that the field is accessible by any member for whom this scope is visible.</summary>
		Public = 0x6,
		/// <summary>Specifies that the field represents the defined type, or else it is per-instance.</summary>
		Static = 0x10,
		/// <summary>Specifies that the field is initialized only, and can be set only in the body of a constructor. </summary>
		InitOnly = 0x20,
		/// <summary>Specifies that the field's value is a compile-time (static or early bound) constant. Any attempt to set it throws <see cref="T:System.FieldAccessException" />.</summary>
		Literal = 0x40,
		/// <summary>Specifies that the field does not have to be serialized when the type is remoted.</summary>
		NotSerialized = 0x80,
		/// <summary>Specifies that the field has a relative virtual address (RVA). The RVA is the location of the method body in the current image, as an address relative to the start of the image file in which it is located.</summary>
		HasFieldRVA = 0x100,
		/// <summary>Specifies a special method, with the name describing how the method is special.</summary>
		SpecialName = 0x200,
		/// <summary>Specifies that the common language runtime (metadata internal APIs) should check the name encoding.</summary>
		RTSpecialName = 0x400,
		/// <summary>Specifies that the field has marshaling information.</summary>
		HasFieldMarshal = 0x1000,
		/// <summary>Reserved for future use.</summary>
		PinvokeImpl = 0x2000,
		/// <summary>Specifies that the field has a default value.</summary>
		HasDefault = 0x8000,
		/// <summary>Reserved.</summary>
		ReservedMask = 0x9500
	}
}
