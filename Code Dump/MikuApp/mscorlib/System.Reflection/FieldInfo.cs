using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a field and provides access to field metadata. </summary>
	[Serializable]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_FieldInfo))]
	[ComVisible(true)]
	public abstract class FieldInfo : MemberInfo, _FieldInfo
	{
		/// <summary>Gets the attributes associated with this field.</summary>
		/// <returns>The FieldAttributes for this field.</returns>
		public abstract FieldAttributes Attributes
		{
			get;
		}

		/// <summary>Gets a RuntimeFieldHandle, which is a handle to the internal metadata representation of a field.</summary>
		/// <returns>A handle to the internal metadata representation of a field.</returns>
		public abstract RuntimeFieldHandle FieldHandle
		{
			get;
		}

		/// <summary>Gets the type of this field object.</summary>
		/// <returns>The type of this field object.</returns>
		public abstract Type FieldType
		{
			get;
		}

		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</returns>
		public override MemberTypes MemberType => (MemberTypes)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the value is written at compile time and cannot be changed.</summary>
		/// <returns>true if the field has the Literal attribute set; otherwise, false.</returns>
		public bool IsLiteral => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the field is static.</summary>
		/// <returns>true if this field is static; otherwise, false.</returns>
		public bool IsStatic => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the field is public.</summary>
		/// <returns>true if this field is public; otherwise, false.</returns>
		public bool IsPublic => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the field is private.</summary>
		/// <returns>true if the field is private; otherwise; false.</returns>
		public bool IsPrivate => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether this field has the NotSerialized attribute.</summary>
		/// <returns>true if the field has the NotSerialized attribute set; otherwise, false.</returns>
		public bool IsNotSerialized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Initializes a new instance of the FieldInfo class.</summary>
		protected FieldInfo()
		{
		}

		/// <summary>When overridden in a derived class, returns the value of a field supported by a given object.</summary>
		/// <returns>An object containing the value of the field reflected by this instance.</returns>
		/// <param name="obj">The object whose field value will be returned. </param>
		/// <exception cref="T:System.Reflection.TargetException">The field is non-static and <paramref name="obj" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">A field is marked literal, but the field does not have one of the accepted literal types. </exception>
		/// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.ArgumentException">The method is neither declared nor inherited by the class of <paramref name="obj" />. </exception>
		public abstract object GetValue(object obj);

		/// <summary>When overridden in a derived class, sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object whose field value will be set. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <param name="invokeAttr">A field of Binder that specifies the type of binding that is desired (for example, Binder.CreateInstance or Binder.ExactBinding). </param>
		/// <param name="binder">A set of properties that enables the binding, coercion of argument types, and invocation of members through reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param>
		/// <param name="culture">The software preferences of a particular culture. </param>
		/// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the field is an instance field. </exception>
		/// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		/// <summary>Sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object whose field value will be set. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the field is an instance field. </exception>
		/// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
		[DebuggerStepThrough]
		[DebuggerHidden]
		public void SetValue(object obj, object value)
		{
		}

		[MethodImpl(4096)]
		private static extern FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle);

		/// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle.</summary>
		/// <returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />.</returns>
		/// <param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="handle" /> is invalid.</exception>
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			return (FieldInfo)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
