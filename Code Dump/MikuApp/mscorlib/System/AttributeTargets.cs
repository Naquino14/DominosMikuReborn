using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Specifies the application elements on which it is valid to apply an attribute.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum AttributeTargets
	{
		/// <summary>Attribute can be applied to an assembly.</summary>
		Assembly = 0x1,
		/// <summary>Attribute can be applied to a module.</summary>
		Module = 0x2,
		/// <summary>Attribute can be applied to a class.</summary>
		Class = 0x4,
		/// <summary>Attribute can be applied to a structure; that is, a value type.</summary>
		Struct = 0x8,
		/// <summary>Attribute can be applied to an enumeration.</summary>
		Enum = 0x10,
		/// <summary>Attribute can be applied to a constructor.</summary>
		Constructor = 0x20,
		/// <summary>Attribute can be applied to a method.</summary>
		Method = 0x40,
		/// <summary>Attribute can be applied to a property.</summary>
		Property = 0x80,
		/// <summary>Attribute can be applied to a field.</summary>
		Field = 0x100,
		/// <summary>Attribute can be applied to an event.</summary>
		Event = 0x200,
		/// <summary>Attribute can be applied to an interface.</summary>
		Interface = 0x400,
		/// <summary>Attribute can be applied to a parameter.</summary>
		Parameter = 0x800,
		/// <summary>Attribute can be applied to a delegate.</summary>
		Delegate = 0x1000,
		/// <summary>Attribute can be applied to a return value.</summary>
		ReturnValue = 0x2000,
		/// <summary>Attribute can be applied to a generic parameter.</summary>
		GenericParameter = 0x4000,
		/// <summary>Attribute can be applied to any application element.</summary>
		All = 0x7FFF
	}
}
