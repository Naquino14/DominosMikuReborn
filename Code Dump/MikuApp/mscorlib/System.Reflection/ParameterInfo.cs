using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a parameter and provides access to parameter metadata.</summary>
	[Serializable]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_ParameterInfo))]
	public class ParameterInfo : ICustomAttributeProvider, _ParameterInfo
	{
		/// <summary>The Type of the parameter.</summary>
		protected Type ClassImpl;

		/// <summary>The default value of the parameter.</summary>
		protected object DefaultValueImpl;

		/// <summary>The member in which the field is implemented.</summary>
		protected MemberInfo MemberImpl;

		/// <summary>The name of the parameter.</summary>
		protected string NameImpl;

		/// <summary>The zero-based position of the parameter in the parameter list.</summary>
		protected int PositionImpl;

		/// <summary>The attributes of the parameter.</summary>
		protected ParameterAttributes AttrsImpl;

		/// <summary>Gets the Type of this parameter.</summary>
		/// <returns>The Type object that represents the Type of this parameter.</returns>
		public virtual Type ParameterType => (Type)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the attributes for this parameter.</summary>
		/// <returns>A ParameterAttributes object representing the attributes for this parameter.</returns>
		public virtual ParameterAttributes Attributes => (ParameterAttributes)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether this is an output parameter.</summary>
		/// <returns>true if the parameter is an output parameter; otherwise, false.</returns>
		public bool IsOut => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether this is a Retval parameter.</summary>
		/// <returns>true if the parameter is a Retval; otherwise, false.</returns>
		public bool IsRetval => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating the member in which the parameter is implemented.</summary>
		/// <returns>A MemberInfo object.</returns>
		public virtual MemberInfo Member => (MemberInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the name of the parameter.</summary>
		/// <returns>A String containing the simple name of this parameter.</returns>
		public virtual string Name => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the zero-based position of the parameter in the formal parameter list.</summary>
		/// <returns>An integer representing the position this parameter occupies in the parameter list.</returns>
		public virtual int Position => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the ParameterInfo class.</summary>
		protected ParameterInfo()
		{
		}

		internal ParameterInfo(ParameterInfo pinfo, MemberInfo member)
		{
		}

		/// <summary>Gets the parameter type and name represented as a string.</summary>
		/// <returns>A string containing the type and the name of the parameter.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets all the custom attributes applied to this parameter.</summary>
		/// <returns>An array that contains all the custom attributes applied to this parameter.</returns>
		/// <param name="inherit">This argument is ignored for objects of this type. See Remarks.</param>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the custom attributes of the specified type or its derived types that are applied to this parameter.</summary>
		/// <returns>An array that contains the custom attributes of the specified type or its derived types.</returns>
		/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
		/// <param name="inherit">This argument is ignored for objects of this type. See Remarks.</param>
		/// <exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> is null.</exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the custom attribute of the specified type or its derived types is applied to this parameter.</summary>
		/// <returns>true if one or more instances of <paramref name="attributeType" /> or its derived types are applied to this parameter; otherwise, false.</returns>
		/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
		/// <param name="inherit">This argument is ignored for objects of this type. See Remarks.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the common language runtime.</exception>
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
