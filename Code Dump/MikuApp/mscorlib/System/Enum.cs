using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Provides the base class for enumerations.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public abstract class Enum : ValueType, IComparable, IConvertible, IFormattable
	{
		private static char[] split_char;

		private object Value => (object)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Enum" /> class. </summary>
		protected Enum()
		{
		}

		/// <summary>Converts the current value to a Boolean value based on the underlying type.</summary>
		/// <returns>This member always throws an exception.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Converts the current value to an 8-bit unsigned integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a Unicode character based on the underlying type.</summary>
		/// <returns>This member always throws an exception.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a <see cref="T:System.DateTime" /> based on the underlying type.</summary>
		/// <returns>This member always throws an exception.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a <see cref="T:System.Decimal" /> based on the underlying type.</summary>
		/// <returns>This member always throws an exception.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a double-precision floating point number based on the underlying type.</summary>
		/// <returns>This member always throws an exception.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a 16-bit signed integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a 32-bit signed integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a 64-bit signed integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to an 8-bit signed integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a single-precision floating point number based on the underlying type.</summary>
		/// <returns>This member always throws an exception.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a specified type based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="type">The type to convert to. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		object IConvertible.ToType(Type targetType, IFormatProvider provider)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a 16-bit unsigned integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a 32-bit unsigned integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current value to a 64-bit unsigned integer based on the underlying type.</summary>
		/// <returns>The converted value.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information.</param>
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the underlying <see cref="T:System.TypeCode" /> for this instance.</summary>
		/// <returns>The <see cref="T:System.TypeCode" /> for this instance.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumeration type is unknown.</exception>
		/// <filterpriority>2</filterpriority>
		public TypeCode GetTypeCode()
		{
			return (TypeCode)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private extern object get_value();

		private static int FindPosition(object value, Array values)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the name of the constant in the specified enumeration that has the specified value.</summary>
		/// <returns>A string containing the name of the enumerated constant in <paramref name="enumType" /> whose value is <paramref name="value" />, or null if no such constant is found.</returns>
		/// <param name="enumType">An enumeration type. </param>
		/// <param name="value">The value of a particular enumerated constant in terms of its underlying type. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> or <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.-or- <paramref name="value" /> is neither of type <paramref name="enumType" /> nor does it have the same underlying type as <paramref name="enumType" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static string GetName(Type enumType, object value)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern Type get_underlying_type(Type enumType);

		/// <summary>Returns the underlying type of the specified enumeration.</summary>
		/// <returns>The underlying <see cref="T:System.Type" /> of <paramref name="enumType" />.</returns>
		/// <param name="enumType">An enumeration type. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static Type GetUnderlyingType(Type enumType)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		private static int FindName(Hashtable name_hash, string[] names, string name, bool ignoreCase)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static ulong GetValue(object value, TypeCode typeCode)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object. A parameter specifies whether the operation is case-sensitive.</summary>
		/// <returns>An object of type <paramref name="enumType" /> whose value is represented by <paramref name="value" />.</returns>
		/// <param name="enumType">The <see cref="T:System.Type" /> of the enumeration. </param>
		/// <param name="value">A string containing the name or value to convert. </param>
		/// <param name="ignoreCase">If true, ignore case; otherwise, regard case. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> or <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.-or- <paramref name="value" /> is either an empty string ("") or only contains white space.-or- <paramref name="value" /> is a name, but not one of the named constants defined for the enumeration. </exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is outside the range of the underlying type of <paramref name="enumType" />.</exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static object Parse(Type enumType, string value, bool ignoreCase)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private extern int compare_value_to(object other);

		/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="target" />.Return Value Description Less than zero The value of this instance is less than the value of <paramref name="target" />. Zero The value of this instance is equal to the value of <paramref name="target" />. Greater than zero The value of this instance is greater than the value of <paramref name="target" />.-or- <paramref name="target" /> is null. </returns>
		/// <param name="target">An object to compare, or null. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> and this instance are not the same type. </exception>
		/// <exception cref="T:System.InvalidOperationException">This instance is not type <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" />, or <see cref="T:System.UInt64" />. </exception>
		/// <exception cref="T:System.NullReferenceException">This instance is null.</exception>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(object target)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of this instance to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		/// <filterpriority>2</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This method overload is obsolete; use <see cref="M:System.Enum.ToString" />.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		/// <param name="provider">(obsolete) </param>
		/// <filterpriority>2</filterpriority>
		[Obsolete("Provider is ignored, just use ToString")]
		public string ToString(IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of this instance to its equivalent string representation using the specified format.</summary>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns>
		/// <param name="format">A format string. </param>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> contains an invalid specification. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="format" /> equals "X", but the enumeration type is unknown.</exception>
		/// <filterpriority>2</filterpriority>
		public string ToString(string format)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This method overload is obsolete; use <see cref="M:System.Enum.ToString(System.String)" />.</summary>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns>
		/// <param name="format">A format specification. </param>
		/// <param name="provider">(obsolete)</param>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> does not contain a valid format specification. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="format" /> equals "X", but the enumeration type is unknown.</exception>
		/// <filterpriority>2</filterpriority>
		[Obsolete("Provider is ignored, just use ToString")]
		public string ToString(string format, IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 8-bit unsigned integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static object ToObject(Type enumType, byte value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 16-bit signed integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static object ToObject(Type enumType, short value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 32-bit signed integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static object ToObject(Type enumType, int value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 64-bit signed integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static object ToObject(Type enumType, long value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration set to the specified value.</summary>
		/// <returns>An enumeration object whose value is <paramref name="value" />.</returns>
		/// <param name="enumType">An enumeration. </param>
		/// <param name="value">The value. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.-or- <paramref name="value" /> is not type <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" />, or <see cref="T:System.UInt64" />. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		[ComVisible(true)]
		public static extern object ToObject(Type enumType, object value);

		/// <summary>Returns an instance of the specified enumeration type set to the specified 8-bit signed integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(Type enumType, sbyte value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 16-bit unsigned integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		[ComVisible(true)]
		public static object ToObject(Type enumType, ushort value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 32-bit unsigned integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		[CLSCompliant(false)]
		public static object ToObject(Type enumType, uint value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an instance of the specified enumeration type set to the specified 64-bit unsigned integer value.</summary>
		/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration for which to create a value. </param>
		/// <param name="value">The value to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="enumType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		[CLSCompliant(false)]
		public static object ToObject(Type enumType, ulong value)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="obj" /> is an <see cref="T:System.Enum" /> with the same underlying type and value as this instance; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance, or null. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		private extern int get_hashcode();

		/// <summary>Returns the hash code for the value of this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static string FormatSpecifier_X(Type enumType, object value, bool upper)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static string FormatFlags(Type enumType, object value)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified value of a specified enumerated type to its equivalent string representation according to the specified format.</summary>
		/// <returns>A string representation of <paramref name="value" />.</returns>
		/// <param name="enumType">The enumeration type of the value to convert. </param>
		/// <param name="value">The value to convert. </param>
		/// <param name="format">The output format to use. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="enumType" />, <paramref name="value" />, or <paramref name="format" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="enumType" /> parameter is not an <see cref="T:System.Enum" /> type.-or- The <paramref name="value" /> is from an enumeration that differs in type from <paramref name="enumType" />.-or- The type of <paramref name="value" /> is not an underlying type of <paramref name="enumType" />. </exception>
		/// <exception cref="T:System.FormatException">The <paramref name="format" /> parameter contains an invalid value. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="format" /> equals "X", but the enumeration type is unknown.</exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static string Format(Type enumType, object value, string format)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
