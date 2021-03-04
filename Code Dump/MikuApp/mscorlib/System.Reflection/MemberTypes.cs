using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Marks each type of member that is defined as a derived class of MemberInfo.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum MemberTypes
	{
		/// <summary>Specifies that the member is a constructor, representing a <see cref="T:System.Reflection.ConstructorInfo" /> member. Hexadecimal value of 0x01.</summary>
		Constructor = 0x1,
		/// <summary>Specifies that the member is an event, representing an <see cref="T:System.Reflection.EventInfo" /> member. Hexadecimal value of 0x02.</summary>
		Event = 0x2,
		/// <summary>Specifies that the member is a field, representing a <see cref="T:System.Reflection.FieldInfo" /> member. Hexadecimal value of 0x04.</summary>
		Field = 0x4,
		/// <summary>Specifies that the member is a method, representing a <see cref="T:System.Reflection.MethodInfo" /> member. Hexadecimal value of 0x08.</summary>
		Method = 0x8,
		/// <summary>Specifies that the member is a property, representing a <see cref="T:System.Reflection.PropertyInfo" /> member. Hexadecimal value of 0x10.</summary>
		Property = 0x10,
		/// <summary>Specifies that the member is a type, representing a <see cref="F:System.Reflection.MemberTypes.TypeInfo" /> member. Hexadecimal value of 0x20.</summary>
		TypeInfo = 0x20,
		/// <summary>Specifies that the member is a custom member type. Hexadecimal value of 0x40.</summary>
		Custom = 0x40,
		/// <summary>Specifies that the member is a nested type, extending <see cref="T:System.Reflection.MemberInfo" />.</summary>
		NestedType = 0x80,
		/// <summary>Specifies all member types.</summary>
		All = 0xBF
	}
}
