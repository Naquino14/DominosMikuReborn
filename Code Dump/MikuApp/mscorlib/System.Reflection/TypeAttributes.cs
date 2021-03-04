using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Specifies type attributes.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum TypeAttributes
	{
		/// <summary>Specifies type visibility information.</summary>
		VisibilityMask = 0x7,
		/// <summary>Specifies that the class is not public.</summary>
		NotPublic = 0x0,
		/// <summary>Specifies that the class is public.</summary>
		Public = 0x1,
		/// <summary>Specifies that the class is nested with public visibility.</summary>
		NestedPublic = 0x2,
		/// <summary>Specifies that the class is nested with private visibility.</summary>
		NestedPrivate = 0x3,
		/// <summary>Specifies that the class is nested with family visibility, and is thus accessible only by methods within its own type and any subtypes.</summary>
		NestedFamily = 0x4,
		/// <summary>Specifies that the class is nested with assembly visibility, and is thus accessible only by methods within its assembly.</summary>
		NestedAssembly = 0x5,
		/// <summary>Specifies that the class is nested with assembly and family visibility, and is thus accessible only by methods lying in the intersection of its family and assembly.</summary>
		NestedFamANDAssem = 0x6,
		/// <summary>Specifies that the class is nested with family or assembly visibility, and is thus accessible only by methods lying in the union of its family and assembly.</summary>
		NestedFamORAssem = 0x7,
		/// <summary>Specifies class layout information.</summary>
		LayoutMask = 0x18,
		/// <summary>Specifies that class fields are automatically laid out by the common language runtime.</summary>
		AutoLayout = 0x0,
		/// <summary>Specifies that class fields are laid out sequentially, in the order that the fields were emitted to the metadata.</summary>
		SequentialLayout = 0x8,
		/// <summary>Specifies that class fields are laid out at the specified offsets.</summary>
		ExplicitLayout = 0x10,
		/// <summary>Specifies class semantics information; the current class is contextful (else agile).</summary>
		ClassSemanticsMask = 0x20,
		/// <summary>Specifies that the type is a class.</summary>
		Class = 0x0,
		/// <summary>Specifies that the type is an interface.</summary>
		Interface = 0x20,
		/// <summary>Specifies that the type is abstract.</summary>
		Abstract = 0x80,
		/// <summary>Specifies that the class is concrete and cannot be extended.</summary>
		Sealed = 0x100,
		/// <summary>Specifies that the class is special in a way denoted by the name.</summary>
		SpecialName = 0x400,
		/// <summary>Specifies that the class or interface is imported from another module.</summary>
		Import = 0x1000,
		/// <summary>Specifies that the class can be serialized.</summary>
		Serializable = 0x2000,
		/// <summary>Used to retrieve string information for native interoperability.</summary>
		StringFormatMask = 0x30000,
		/// <summary>LPTSTR is interpreted as ANSI.</summary>
		AnsiClass = 0x0,
		/// <summary>LPTSTR is interpreted as UNICODE.</summary>
		UnicodeClass = 0x10000,
		/// <summary>LPTSTR is interpreted automatically.</summary>
		AutoClass = 0x20000,
		/// <summary>Specifies that calling static methods of the type does not force the system to initialize the type.</summary>
		BeforeFieldInit = 0x100000,
		/// <summary>Attributes reserved for runtime use.</summary>
		ReservedMask = 0x40800,
		/// <summary>Runtime should check name encoding.</summary>
		RTSpecialName = 0x800,
		/// <summary>Type has security associate with it.</summary>
		HasSecurity = 0x40000,
		/// <summary>LPSTR is interpreted by some implementation-specific means, which includes the possibility of throwing a <see cref="T:System.NotSupportedException" />. Not used in the Microsoft implementation of the .NET Framework.</summary>
		CustomFormatClass = 0x30000,
		/// <summary>Used to retrieve non-standard encoding information for native interop. The meaning of the values of these 2 bits is unspecified. Not used in the Microsoft implementation of the .NET Framework.</summary>
		CustomFormatMask = 0xC00000
	}
}
