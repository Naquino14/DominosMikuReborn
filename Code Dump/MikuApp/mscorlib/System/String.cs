using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	/// <summary>Represents text as a series of Unicode characters.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public sealed class String : IEnumerable<char>, IComparable<string>, IEquatable<string>, IEnumerable, ICloneable, IComparable, IConvertible
	{
		[NonSerialized]
		private int length;

		[NonSerialized]
		private char start_char;

		/// <summary>Represents the empty string. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly string Empty;

		private static readonly char[] WhiteChars;

		/// <summary>Gets the character at a specified character position in the current <see cref="T:System.String" /> object.</summary>
		/// <returns>A Unicode character.</returns>
		/// <param name="index">A character position in the current <see cref="T:System.String" /> object. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> is greater than or equal to the length of this object or less than zero. </exception>
		/// <filterpriority>2</filterpriority>
		[IndexerName("Chars")]
		public char this[int index] => (char)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the number of characters in the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The number of characters in this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public int Length => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters.</summary>
		/// <param name="value">A pointer to a null terminated array of Unicode characters. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current process does not have read access to all the addressed characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> specifies an address less than 64000.</exception>
		[MethodImpl(4096)]
		[CLSCompliant(false)]
		public unsafe extern String(char* value);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of Unicode characters, a starting character position within that array, and a length.</summary>
		/// <param name="value">A pointer to an array of Unicode characters. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero, <paramref name="value" /> + <paramref name="startIndex" /> cause a pointer overflow, or the current process does not have read access to all the addressed characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> specifies an array that contains an invalid Unicode character, or <paramref name="value" /> + <paramref name="startIndex" /> specifies an address less than 64000.</exception>
		[MethodImpl(4096)]
		[CLSCompliant(false)]
		public unsafe extern String(char* value, int startIndex, int length);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a pointer to an array of 8-bit signed integers.</summary>
		/// <param name="value">A pointer to a null-terminated array of 8-bit signed integers. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded in ANSI. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the new string to initialize, which is determined by the null termination character of <paramref name="value" />, is too large to allocate. </exception>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="value" /> specifies an invalid address.</exception>
		[MethodImpl(4096)]
		[CLSCompliant(false)]
		public unsafe extern String(sbyte* value);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting character position within that array, and a length.</summary>
		/// <param name="value">A pointer to an array of 8-bit signed integers. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. -or-The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed. -or-The length of the new string to initialize is too large to allocate.</exception>
		/// <exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.-or- A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded in ANSI. </exception>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
		[MethodImpl(4096)]
		[CLSCompliant(false)]
		public unsafe extern String(sbyte* value, int startIndex, int length);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified pointer to an array of 8-bit signed integers, a starting character position within that array, a length, and an <see cref="T:System.Text.Encoding" /> object.</summary>
		/// <param name="value">A pointer to an array of 8-bit signed integers. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <param name="enc">An <see cref="T:System.Text.Encoding" /> object that specifies how the array referenced by <paramref name="value" /> is encoded. If <paramref name="enc" /> is null, ANSI encoding is assumed.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. -or-The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is too large for the current platform; that is, the address calculation overflowed. -or-The length of the new string to initialize is too large to allocate.</exception>
		/// <exception cref="T:System.ArgumentException">The address specified by <paramref name="value" /> + <paramref name="startIndex" /> is less than 64K.-or- A new instance of <see cref="T:System.String" /> could not be initialized using <paramref name="value" />, assuming <paramref name="value" /> is encoded as specified by <paramref name="enc" />. </exception>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="value" />, <paramref name="startIndex" />, and <paramref name="length" /> collectively specify an invalid address.</exception>
		[MethodImpl(4096)]
		[CLSCompliant(false)]
		public unsafe extern String(sbyte* value, int startIndex, int length, Encoding enc);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters, a starting character position within that array, and a length.</summary>
		/// <param name="value">An array of Unicode characters. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of characters within <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the number of elements in <paramref name="value" />. </exception>
		[MethodImpl(4096)]
		public extern String(char[] value, int startIndex, int length);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by an array of Unicode characters.</summary>
		/// <param name="value">An array of Unicode characters. </param>
		[MethodImpl(4096)]
		public extern String(char[] value);

		/// <summary>Initializes a new instance of the <see cref="T:System.String" /> class to the value indicated by a specified Unicode character repeated a specified number of times.</summary>
		/// <param name="c">A Unicode character. </param>
		/// <param name="count">The number of times <paramref name="c" /> occurs. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> is less than zero. </exception>
		[MethodImpl(4096)]
		public extern String(char c, int count);

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <returns>true if the value of the current <see cref="T:System.String" /> object is <see cref="F:System.Boolean.TrueString" />, or false if the value of the current <see cref="T:System.String" /> object is <see cref="F:System.Boolean.FalseString" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object is not <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />. </exception>
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <returns>The character at index 0 in the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDateTime(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number less than <see cref="F:System.Decimal.MinValue" /> or than <see cref="F:System.Decimal.MaxValue" /> greater. </exception>
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />. </exception>
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="type">The type of the returned object. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.</exception>
		/// <exception cref="T:System.InvalidCastException">The value of the current <see cref="T:System.String" /> object cannot be converted to the type specified by the <paramref name="type" /> parameter. </exception>
		object IConvertible.ToType(Type targetType, IFormatProvider provider)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that provides culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />.</exception>
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. </param>
		/// <exception cref="T:System.FormatException">The value of the current <see cref="T:System.String" /> object cannot be parsed. </exception>
		/// <exception cref="T:System.OverflowException">The value of the current <see cref="T:System.String" /> object is a number greater <see cref="F:System.UInt32.MaxValue" /> or less than <see cref="F:System.UInt32.MinValue" /></exception>
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <returns>The converted value of the current <see cref="T:System.String" /> object.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. </param>
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		IEnumerator<char> IEnumerable<char>.GetEnumerator()
		{
			return (IEnumerator<char>)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an enumerator that iterates through the current <see cref="T:System.String" /> object. </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the current <see cref="T:System.String" /> object.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value.</summary>
		/// <returns>true if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, false.</returns>
		/// <param name="a">A <see cref="T:System.String" /> or null. </param>
		/// <param name="b">A <see cref="T:System.String" /> or null. </param>
		/// <filterpriority>1</filterpriority>
		public static bool Equals(string a, string b)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether this instance of <see cref="T:System.String" /> and a specified object, which must also be a <see cref="T:System.String" /> object, have the same value.</summary>
		/// <returns>true if <paramref name="obj" /> is a <see cref="T:System.String" /> and its value is the same as this instance; otherwise, false.</returns>
		/// <param name="obj">An <see cref="T:System.Object" />. </param>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether this instance and another specified <see cref="T:System.String" /> object have the same value.</summary>
		/// <returns>true if the value of the <paramref name="value" /> parameter is the same as this instance; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.String" />. </param>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public bool Equals(string value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a reference to this instance of <see cref="T:System.String" />.</summary>
		/// <returns>This instance of String.</returns>
		/// <filterpriority>2</filterpriority>
		public object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for class <see cref="T:System.String" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.String" />.</returns>
		/// <filterpriority>2</filterpriority>
		public TypeCode GetTypeCode()
		{
			return (TypeCode)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies a specified number of characters from a specified position in this instance to a specified position in an array of Unicode characters.</summary>
		/// <param name="sourceIndex">The index of the first character in this instance to copy. </param>
		/// <param name="destination">An array of Unicode characters to which characters in this instance are copied. </param>
		/// <param name="destinationIndex">An index in <paramref name="destination" /> at which the copy operation begins. </param>
		/// <param name="count">The number of characters in this instance to copy to <paramref name="destination" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destination" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="sourceIndex" />, <paramref name="destinationIndex" />, or <paramref name="count" /> is negative -or- <paramref name="count" /> is greater than the length of the substring from <paramref name="startIndex" /> to the end of this instance -or- <paramref name="count" /> is greater than the length of the subarray from <paramref name="destinationIndex" /> to the end of <paramref name="destination" /></exception>
		/// <filterpriority>2</filterpriority>
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
		}

		/// <summary>Copies the characters in this instance to a Unicode character array.</summary>
		/// <returns>A Unicode character array whose elements are the individual characters of this instance. If this instance is an empty string, the returned array is empty and has a zero length.</returns>
		/// <filterpriority>1</filterpriority>
		public char[] ToCharArray()
		{
			return (char[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the characters in a specified substring in this instance to a Unicode character array.</summary>
		/// <returns>A Unicode character array whose elements are the <paramref name="length" /> number of characters in this instance starting from character position <paramref name="startIndex" />.</returns>
		/// <param name="startIndex">The starting position of a substring in this instance. </param>
		/// <param name="length">The length of the substring in this instance. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="length" /> is greater than the length of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public char[] ToCharArray(int startIndex, int length)
		{
			return (char[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array.</summary>
		/// <returns>An array whose elements contain the substrings in this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null. </param>
		/// <filterpriority>1</filterpriority>
		public string[] Split(params char[] separator)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array that contains the substrings in this instance that are delimited by elements of a specified Unicode character array. A parameter specifies the maximum number of substrings to return.</summary>
		/// <returns>An array whose elements contain the substrings in this instance that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null. </param>
		/// <param name="count">The maximum number of substrings to return. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> is negative. </exception>
		/// <filterpriority>1</filterpriority>
		public string[] Split(char[] separator, int count)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified Unicode character array. Parameters specify the maximum number of substrings to return and whether to return empty array elements.</summary>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <param name="separator">An array of Unicode characters that delimit the substrings in this string, an empty array that contains no delimiters, or null.</param>
		/// <param name="count">The maximum number of substrings to return. </param>
		/// <param name="options">
		///   <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned, or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
		/// <filterpriority>1</filterpriority>
		[MonoDocumentationNote("code should be moved to managed")]
		[ComVisible(false)]
		public string[] Split(char[] separator, int count, StringSplitOptions options)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified string array. Parameters specify the maximum number of substrings to return and whether to return empty array elements.</summary>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more strings in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <param name="separator">An array of strings that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param>
		/// <param name="count">The maximum number of substrings to return. </param>
		/// <param name="options">Specify <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned, or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(false)]
		public string[] Split(string[] separator, int count, StringSplitOptions options)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified Unicode character array. A parameter specifies whether to return empty array elements.</summary>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <param name="separator">An array of Unicode characters that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param>
		/// <param name="options">Specify <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned, or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(false)]
		public string[] Split(char[] separator, StringSplitOptions options)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array that contains the substrings in this string that are delimited by elements of a specified string array. A parameter specifies whether to return empty array elements.</summary>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by one or more strings in <paramref name="separator" />. For more information, see the Remarks section.</returns>
		/// <param name="separator">An array of strings that delimit the substrings in this string, an empty array that contains no delimiters, or null. </param>
		/// <param name="options">Specify <see cref="F:System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements from the array returned, or <see cref="F:System.StringSplitOptions.None" /> to include empty array elements in the array returned. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not one of the <see cref="T:System.StringSplitOptions" /> values.</exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(false)]
		public string[] Split(string[] separator, StringSplitOptions options)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a substring from this instance. The substring starts at a specified character position.</summary>
		/// <returns>A <see cref="T:System.String" /> object equivalent to the substring that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance.</returns>
		/// <param name="startIndex">The zero-based starting character position of a substring in this instance. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is less than zero or greater than the length of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public string Substring(int startIndex)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.</summary>
		/// <returns>A <see cref="T:System.String" /> equivalent to the substring of length <paramref name="length" /> that begins at <paramref name="startIndex" /> in this instance, or <see cref="F:System.String.Empty" /> if <paramref name="startIndex" /> is equal to the length of this instance and <paramref name="length" /> is zero.</returns>
		/// <param name="startIndex">The zero-based starting character position of a substring in this instance. </param>
		/// <param name="length">The number of characters in the substring. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> plus <paramref name="length" /> indicates a position not within this instance.-or- <paramref name="startIndex" /> or <paramref name="length" /> is less than zero. </exception>
		/// <filterpriority>1</filterpriority>
		public string Substring(int startIndex, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal string SubstringUnchecked(int startIndex, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes all leading and trailing white-space characters from the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The string that remains after all white-space characters are removed from the start and end of the current <see cref="T:System.String" /> object.</returns>
		/// <filterpriority>1</filterpriority>
		public string Trim()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes all leading and trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the start and end of the current <see cref="T:System.String" /> object. If <paramref name="trimChars" /> is null or an empty array, white-space characters are removed instead.</returns>
		/// <param name="trimChars">An array of Unicode characters to remove or null. </param>
		/// <filterpriority>1</filterpriority>
		public string Trim(params char[] trimChars)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes all leading occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The string that remains after all occurrences of characters in the <paramref name="trimChars" /> parameter are removed from the start of the current <see cref="T:System.String" /> object. If <paramref name="trimChars" /> is null or an empty array, white-space characters are removed instead.</returns>
		/// <param name="trimChars">An array of Unicode characters to remove or null. </param>
		/// <filterpriority>2</filterpriority>
		public string TrimStart(params char[] trimChars)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes all trailing occurrences of a set of characters specified in an array from the current <see cref="T:System.String" /> object.</summary>
		/// <returns>The string that remains after all occurrences of the characters in the <paramref name="trimChars" /> parameter are removed from the end of the current <see cref="T:System.String" /> object. If <paramref name="trimChars" /> is null or an empty array, white-space characters are removed instead.</returns>
		/// <param name="trimChars">An array of Unicode characters to remove or null. </param>
		/// <filterpriority>2</filterpriority>
		public string TrimEnd(params char[] trimChars)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private int FindNotWhiteSpace(int pos, int target, int change)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int FindNotInTable(int pos, int target, int change, char[] table)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relationship to one another in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, string strB)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relationship to one another in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <param name="ignoreCase">A <see cref="T:System.Boolean" /> indicating a case-sensitive or insensitive comparison. (true indicates a case-insensitive comparison.) </param>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and using culture-specific information to influence the comparison, and returns an integer that indicates their relationship to one another in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <param name="ignoreCase">A <see cref="T:System.Boolean" /> indicating a case-sensitive or insensitive comparison. (true indicates a case-insensitive comparison.) </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that supplies culture-specific comparison information. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relative position in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="indexA">The position of the substring within <paramref name="strA" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <param name="indexB">The position of the substring within <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is null, and <paramref name="length" /> is greater than zero.</exception>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, int indexA, string strB, int indexB, int length)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects, ignoring or honoring their case, and returns an integer that indicates their relationship to one another in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.ValueCondition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="indexA">The position of the substring within <paramref name="strA" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <param name="indexB">The position of the substring within <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <param name="ignoreCase">A <see cref="T:System.Boolean" /> indicating a case-sensitive or insensitive comparison. (true indicates a case-insensitive comparison.) </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is null, and <paramref name="length" /> is greater than zero.</exception>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects, ignoring or honoring their case and using culture-specific information to influence the comparison. The method returns an integer that indicates their relationship to one another in the sort order.</summary>
		/// <returns>An integer indicating the lexical relationship between the two comparands.Value Condition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="indexA">The position of the substring within <paramref name="strA" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <param name="indexB">The position of the substring within <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <param name="ignoreCase">A <see cref="T:System.Boolean" /> indicating a case-sensitive or insensitive comparison. (true indicates a case-insensitive comparison.) </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that supplies culture-specific comparison information. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="strA" /> or <paramref name="strB" /> is null, and <paramref name="length" /> is greater than zero.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects. A parameter specifies whether the comparison uses the current or invariant culture, honors or ignores case, and uses word or ordinal sort rules. The method returns an integer that indicates the relationship of the two <see cref="T:System.String" /> objects to one another in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> equals <paramref name="strB" />. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" /> object.</param>
		/// <param name="strB">The second <see cref="T:System.String" /> object. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="T:System.StringComparison" /> is not supported.</exception>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects and returns an integer that indicates their relationship to one another in the sort order.</summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.Value Condition Less than zero The substring in the <paramref name="strA" /> parameter is less than the substring in the <paramref name="strB" /> parameter.Zero The substrings are equal, or the <paramref name="length" /> parameter is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns>
		/// <param name="strA">The first string to use in the comparison. </param>
		/// <param name="indexA">The position of the substring within <paramref name="strA" />. </param>
		/// <param name="strB">The second string to use in the comparison.</param>
		/// <param name="indexB">The position of the substring within <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="indexA" /> is greater than <paramref name="strA" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />.<see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. -or-Either <paramref name="indexA" /> or <paramref name="indexB" /> is null, and <paramref name="length" /> is greater than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		/// <filterpriority>1</filterpriority>
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary>
		/// <returns>true if the value of the <paramref name="a" /> parameter is equal to the value of the <paramref name="b" /> parameter; otherwise, false.</returns>
		/// <param name="a">A <see cref="T:System.String" /> object or null. </param>
		/// <param name="b">A <see cref="T:System.String" /> object or null. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool Equals(string a, string b, StringComparison comparisonType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether this string and a specified <see cref="T:System.String" /> object have the same value. A parameter specifies the culture, case, and sort rules used in the comparison.</summary>
		/// <returns>true if the value of the <paramref name="value" /> parameter is the same as this string; otherwise, false.</returns>
		/// <param name="value">A string to compare.</param>
		/// <param name="comparisonType">A value that defines the type of comparison. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value. </exception>
		/// <filterpriority>2</filterpriority>
		public bool Equals(string value, StringComparison comparisonType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects using the specified comparison options and culture-specific information to influence the comparison, and returns an integer that indicates the relationship of the two strings to each other in the sort order.</summary>
		/// <returns>A 32-bit signed integer that indicates the lexical relationship between <paramref name="strA" /> and <paramref name="strB" />, as shown in the following tableValueConditionLess than zero<paramref name="strA" /> is less than <paramref name="strB" />.Zero<paramref name="strA" /> equals <paramref name="strB" />.Greater than zero<paramref name="strA" /> is greater than <paramref name="strB" />.</returns>
		/// <param name="strA">The first string.  </param>
		/// <param name="strB">The second string.</param>
		/// <param name="culture">The culture that supplies culture-specific comparison information.</param>
		/// <param name="options">Options to use when performing the comparison (such as ignoring case or symbols).  </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not a <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> is null.</exception>
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects using the specified comparison options and culture-specific information to influence the comparison, and returns an integer that indicates the relationship of the two substrings to each other in the sort order.</summary>
		/// <returns>An integer that indicates the lexical relationship between the two substrings, as shown in the following table.ValueConditionLess than zeroThe substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />.ZeroThe substrings are equal or <paramref name="length" /> is zero.Greater than zeroThe substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />.</returns>
		/// <param name="strA">The first string.   </param>
		/// <param name="indexA">The starting position of the substring within <paramref name="strA" />.</param>
		/// <param name="strB">The second string.</param>
		/// <param name="indexB">The starting position of the substring within <paramref name="strB" />.</param>
		/// <param name="length">The maximum number of characters in the substrings to compare.</param>
		/// <param name="culture">The culture that supplies culture-specific comparison information.</param>
		/// <param name="options">Options to use when performing the comparison (such as ignoring case or symbols).  </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not a <see cref="T:System.Globalization.CompareOptions" /> value.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="indexA" /> is greater than <paramref name="strA" />.Length.-or-<paramref name="indexB" /> is greater than <paramref name="strB" />.Length.-or-<paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative.-or-Either <paramref name="strA" /> or <paramref name="strB" /> is null, and <paramref name="length" /> is greater than zero.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> is null.</exception>
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance with a specified <see cref="T:System.Object" /> and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary>
		/// <returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="value" /> parameter.Value Condition Less than zero This instance precedes <paramref name="value" />. Zero This instance has the same position in the sort order as <paramref name="value" />. Greater than zero This instance follows <paramref name="value" />.-or- <paramref name="value" /> is null. </returns>
		/// <param name="value">An <see cref="T:System.Object" /> that evaluates to a String. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.String" />. </exception>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance with a specified <see cref="T:System.String" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.String" />.</summary>
		/// <returns>A 32-bit signed integer that indicates whether this instance precedes, follows, or appears in the same position in the sort order as the <paramref name="value" /> parameter.Value Condition Less than zero This instance precedes <paramref name="strB" />. Zero This instance has the same position in the sort order as <paramref name="strB" />. Greater than zero This instance follows <paramref name="strB" />.-or- <paramref name="strB" /> is null. </returns>
		/// <param name="strB">A <see cref="T:System.String" />. </param>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(string strB)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each string.</summary>
		/// <returns>An integer indicating the lexical relationship between the two comparands.ValueCondition Less than zero <paramref name="strA" /> is less than <paramref name="strB" />. Zero <paramref name="strA" /> and <paramref name="strB" /> are equal. Greater than zero <paramref name="strA" /> is greater than <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <filterpriority>2</filterpriority>
		public static int CompareOrdinal(string strA, string strB)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares substrings of two specified <see cref="T:System.String" /> objects by evaluating the numeric values of the corresponding <see cref="T:System.Char" /> objects in each substring. </summary>
		/// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.ValueCondition Less than zero The substring in <paramref name="strA" /> is less than the substring in <paramref name="strB" />. Zero The substrings are equal, or <paramref name="length" /> is zero. Greater than zero The substring in <paramref name="strA" /> is greater than the substring in <paramref name="strB" />. </returns>
		/// <param name="strA">The first <see cref="T:System.String" />. </param>
		/// <param name="indexA">The starting index of the substring in <paramref name="strA" />. </param>
		/// <param name="strB">The second <see cref="T:System.String" />. </param>
		/// <param name="indexB">The starting index of the substring in <paramref name="strB" />. </param>
		/// <param name="length">The maximum number of characters in the substrings to compare. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="indexA" /> is greater than <paramref name="strA" />. <see cref="P:System.String.Length" />.-or- <paramref name="indexB" /> is greater than <paramref name="strB" />. <see cref="P:System.String.Length" />.-or- <paramref name="indexA" />, <paramref name="indexB" />, or <paramref name="length" /> is negative. </exception>
		/// <filterpriority>2</filterpriority>
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static int CompareOrdinalCaseInsensitive(string strA, int indexA, string strB, int indexB, int length)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static int CompareOrdinalCaseInsensitiveUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the end of this instance matches the specified string.</summary>
		/// <returns>true if <paramref name="value" /> matches the end of this instance; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.String" /> to compare to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public bool EndsWith(string value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether the end of this string matches the specified string when compared using the specified culture.</summary>
		/// <returns>true if the <paramref name="value" /> parameter matches the end of this string; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.String" /> object to compare to. </param>
		/// <param name="ignoreCase">true to ignore case when comparing this instance and <paramref name="value" />; otherwise, false.</param>
		/// <param name="culture">Cultural information that determines how this instance and <paramref name="value" /> are compared. If <paramref name="culture" /> is null, the current culture is used.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters.</summary>
		/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; otherwise, -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		public int IndexOfAny(char[] anyOf)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position.</summary>
		/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; otherwise, -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the number of characters in this instance. </exception>
		/// <filterpriority>2</filterpriority>
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <returns>The zero-based index position of the first occurrence in this instance where any character in <paramref name="anyOf" /> was found; otherwise, -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="count" /> + <paramref name="startIndex" /> is greater than the number of characters in this instance. </exception>
		/// <filterpriority>2</filterpriority>
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary>
		/// <returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		public int IndexOf(string value, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string and the type of search to use for the specified string.</summary>
		/// <returns>The zero-based index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is negative, or specifies a position that is not within this instance. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		public int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified string in the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.</summary>
		/// <returns>The zero-based index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="count" /> plus <paramref name="startIndex" /> specify a position that is not within this instance. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int IndexOfOrdinal(string value, int startIndex, int count, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int IndexOfOrdinalUnchecked(string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int IndexOfOrdinalIgnoreCaseUnchecked(string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the last occurrence of a specified string within the current <see cref="T:System.String" /> object. A parameter specifies the type of search to use for the specified string.</summary>
		/// <returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		public int LastIndexOf(string value, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the last occurrence of a specified string within the current <see cref="T:System.String" /> object. Parameters specify the starting search position in the current string, and type of search to use for the specified string.</summary>
		/// <returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="startIndex" /> is less than zero or specifies a position that is not within this instance. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of a specified <see cref="T:System.String" /> object within this instance. Parameters specify the starting search position in the current string, the number of characters in the current string to search, and the type of search to use for the specified string.</summary>
		/// <returns>The index position of the <paramref name="value" /> parameter if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the length of this instance.-or-<paramref name="startIndex" /> + 1 - <paramref name="count" /> specifies a position that is not within this instance. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a valid <see cref="T:System.StringComparison" /> value.</exception>
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int LastIndexOfOrdinal(string value, int startIndex, int count, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int LastIndexOfOrdinalUnchecked(string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int LastIndexOfOrdinalIgnoreCaseUnchecked(string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified Unicode character in this string.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
		/// <param name="value">A Unicode character to seek. </param>
		/// <filterpriority>1</filterpriority>
		public int IndexOf(char value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified Unicode character in this string. The search starts at a specified character position.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
		/// <param name="value">A Unicode character to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is less than zero or specifies a position beyond the end of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int IndexOf(char value, int startIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified character in this instance. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
		/// <param name="value">A Unicode character to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="count" /> + <paramref name="startIndex" /> specifies a position beyond the end of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int IndexOf(char value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int IndexOfUnchecked(char value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int IndexOfOrdinalIgnoreCase(char value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified <see cref="T:System.String" /> in this instance.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is 0.</returns>
		/// <param name="value">The <see cref="T:System.String" /> to seek. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public int IndexOf(string value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified <see cref="T:System.String" /> in this instance. The search starts at a specified character position.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> specifies a position not within this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int IndexOf(string value, int startIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index of the first occurrence of the specified <see cref="T:System.String" /> in this instance. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="count" /> plus <paramref name="startIndex" /> specify a position not within this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int IndexOf(string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence in this instance of one or more characters specified in a Unicode array.</summary>
		/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; otherwise, -1 if no character in <paramref name="anyOf" /> was found.</returns>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		public int LastIndexOfAny(char[] anyOf)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position.</summary>
		/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; otherwise, -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="startIndex" /> specifies a position not within this instance. </exception>
		/// <filterpriority>2</filterpriority>
		public int LastIndexOfAny(char[] anyOf, int startIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence in this instance of one or more characters specified in a Unicode array. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <returns>The index position of the last occurrence in this instance where any character in <paramref name="anyOf" /> was found; -1 if no character in <paramref name="anyOf" /> was found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <param name="anyOf">A Unicode character array containing one or more characters to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="anyOf" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" />, and <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="startIndex" /> minus <paramref name="count" /> specifies a position that is not within this instance. </exception>
		/// <filterpriority>2</filterpriority>
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of a specified Unicode character within this instance.</summary>
		/// <returns>The zero-based index position of <paramref name="value" /> if that character is found, or -1 if it is not.</returns>
		/// <param name="value">A Unicode character to seek. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public int LastIndexOf(char value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of a specified Unicode character within this instance. The search starts at a specified character position.</summary>
		/// <returns>The index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <param name="value">A Unicode character to seek. </param>
		/// <param name="startIndex">The starting position of a substring within this instance. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="startIndex" /> is less than zero or greater than the length of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int LastIndexOf(char value, int startIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of the specified Unicode character in a substring within this instance. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <returns>The index position of <paramref name="value" /> if that character is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />.</returns>
		/// <param name="value">A Unicode character to seek. </param>
		/// <param name="startIndex">The starting position of a substring within this instance. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="startIndex" /> is less than zero, or greater than or equal to the length of this instance.-or-<paramref name="startIndex" /> + 1 - <paramref name="count" /> is less than zero.</exception>
		/// <filterpriority>1</filterpriority>
		public int LastIndexOf(char value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int LastIndexOfUnchecked(char value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int LastIndexOfOrdinalIgnoreCase(char value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of a specified <see cref="T:System.String" /> within this instance.</summary>
		/// <returns>The index position of <paramref name="value" /> if that string is found, or -1 if it is not. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is the last index position in this instance.</returns>
		/// <param name="value">A <see cref="T:System.String" /> to seek. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public int LastIndexOf(string value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of a specified <see cref="T:System.String" /> within this instance. The search starts at a specified character position.</summary>
		/// <returns>The index position of <paramref name="value" /> if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="startIndex" /> is less than zero or specifies a position not within this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int LastIndexOf(string value, int startIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reports the index position of the last occurrence of a specified <see cref="T:System.String" /> within this instance. The search starts at a specified character position and examines a specified number of character positions.</summary>
		/// <returns>The index position of <paramref name="value" /> if that string is found, or -1 if it is not found or if the current instance equals <see cref="F:System.String.Empty" />. If <paramref name="value" /> is <see cref="F:System.String.Empty" />, the return value is <paramref name="startIndex" />.</returns>
		/// <param name="value">The <see cref="T:System.String" /> to seek. </param>
		/// <param name="startIndex">The search starting position. </param>
		/// <param name="count">The number of character positions to examine. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The current instance does not equal <see cref="F:System.String.Empty" /> and <paramref name="count" /> or <paramref name="startIndex" /> is negative.-or- <paramref name="startIndex" /> is greater than the length of this instance.-or-<paramref name="startIndex" /> + 1 - <paramref name="count" /> specifies a position that is not within this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public int LastIndexOf(string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether the specified <see cref="T:System.String" /> object occurs within this string.</summary>
		/// <returns>true if the <paramref name="value" /> parameter occurs within this string, or if <paramref name="value" /> is the empty string (""); otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to seek. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public bool Contains(string value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether the specified string is null or an <see cref="F:System.String.Empty" /> string.</summary>
		/// <returns>true if the <paramref name="value" /> parameter is null or an empty string (""); otherwise, false.</returns>
		/// <param name="value">The string to test.</param>
		/// <filterpriority>1</filterpriority>
		public static bool IsNullOrEmpty(string value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a new string whose textual value is the same as this string, but whose binary representation is in Unicode normalization form C.</summary>
		/// <returns>A new, normalized string whose textual value is the same as this string, but whose binary representation is in normalization form C.</returns>
		/// <exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string Normalize()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new string whose textual value is the same as this string, but whose binary representation is in the specified Unicode normalization form.</summary>
		/// <returns>A new string whose textual value is the same as this string, but whose binary representation is in the normalization form specified by the <paramref name="normalizationForm" /> parameter.</returns>
		/// <param name="normalizationForm">A Unicode normalization form. </param>
		/// <exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string Normalize(NormalizationForm normalizationForm)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Indicates whether this string is in Unicode normalization form C.</summary>
		/// <returns>true if this string is in normalization form C; otherwise, false.</returns>
		/// <exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public bool IsNormalized()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether this string is in the specified Unicode normalization form.</summary>
		/// <returns>true if this string is in the normalization form specified by the <paramref name="normalizationForm" /> parameter; otherwise, false.</returns>
		/// <param name="normalizationForm">A Unicode normalization form. </param>
		/// <exception cref="T:System.ArgumentException">The current instance contains invalid Unicode characters.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public bool IsNormalized(NormalizationForm normalizationForm)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Deletes all the characters from this string beginning at a specified position and continuing through the last position.</summary>
		/// <returns>A new <see cref="T:System.String" /> object that is equivalent to this string less the removed characters.</returns>
		/// <param name="startIndex">The zero-based position to begin deleting characters. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is less than zero.-or- <paramref name="startIndex" /> specifies a position that is not within this string. </exception>
		/// <filterpriority>1</filterpriority>
		public string Remove(int startIndex)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Right-aligns the characters in this instance, padding with spaces on the left for a specified total length.</summary>
		/// <returns>A new <see cref="T:System.String" /> that is equivalent to this instance, but right-aligned and padded on the left with as many spaces as needed to create a length of <paramref name="totalWidth" />. Or, if <paramref name="totalWidth" /> is less than the length of this instance, a new <see cref="T:System.String" /> object that is identical to this instance.</returns>
		/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalWidth" /> is less than zero. </exception>
		/// <filterpriority>2</filterpriority>
		public string PadLeft(int totalWidth)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Right-aligns the characters in this instance, padding on the left with a specified Unicode character for a specified total length.</summary>
		/// <returns>A new <see cref="T:System.String" /> that is equivalent to this instance, but right-aligned and padded on the left with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />. Or, if <paramref name="totalWidth" /> is less than the length of this instance, a new <see cref="T:System.String" /> that is identical to this instance.</returns>
		/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param>
		/// <param name="paddingChar">A Unicode padding character. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalWidth" /> is less than zero. </exception>
		/// <filterpriority>2</filterpriority>
		public string PadLeft(int totalWidth, char paddingChar)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Left-aligns the characters in this string, padding with spaces on the right, for a specified total length.</summary>
		/// <returns>A new <see cref="T:System.String" /> that is equivalent to this instance, but left-aligned and padded on the right with as many spaces as needed to create a length of <paramref name="totalWidth" />. Or, if <paramref name="totalWidth" /> is less than the length of this instance, a new <see cref="T:System.String" /> that is identical to this instance.</returns>
		/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalWidth" /> is less than zero. </exception>
		/// <filterpriority>2</filterpriority>
		public string PadRight(int totalWidth)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Left-aligns the characters in this string, padding on the right with a specified Unicode character, for a specified total length.</summary>
		/// <returns>A new <see cref="T:System.String" /> that is equivalent to this instance, but left-aligned and padded on the right with as many <paramref name="paddingChar" /> characters as needed to create a length of <paramref name="totalWidth" />. Or, if <paramref name="totalWidth" /> is less than the length of this instance, a new <see cref="T:System.String" /> that is identical to this instance.</returns>
		/// <param name="totalWidth">The number of characters in the resulting string, equal to the number of original characters plus any additional padding characters. </param>
		/// <param name="paddingChar">A Unicode padding character. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalWidth" /> is less than zero. </exception>
		/// <filterpriority>2</filterpriority>
		public string PadRight(int totalWidth, char paddingChar)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the beginning of this instance matches the specified string.</summary>
		/// <returns>true if <paramref name="value" /> matches the beginning of this string; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.String" /> to compare. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public bool StartsWith(string value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether the beginning of this string matches the specified string when compared using the specified comparison option.</summary>
		/// <returns>true if the <paramref name="value" /> parameter matches the beginning of this string; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.String" /> object to compare to. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values that determines how this string and <paramref name="value" /> are compared. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
		[ComVisible(false)]
		public bool StartsWith(string value, StringComparison comparisonType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether the end of this string matches the specified string when compared using the specified comparison option.</summary>
		/// <returns>true if the <paramref name="value" /> parameter matches the end of this string; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.String" /> object to compare to. </param>
		/// <param name="comparisonType">One of the <see cref="T:System.StringComparison" /> values that determines how this string and <paramref name="value" /> are compared. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparisonType" /> is not a <see cref="T:System.StringComparison" /> value.</exception>
		[ComVisible(false)]
		public bool EndsWith(string value, StringComparison comparisonType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether the beginning of this string matches the specified string when compared using the specified culture.</summary>
		/// <returns>true if the <paramref name="value" /> parameter matches the beginning of this string; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.String" /> object to compare. </param>
		/// <param name="ignoreCase">true to ignore case when comparing this string and <paramref name="value" />; otherwise, false.</param>
		/// <param name="culture">Cultural information that determines how this string and <paramref name="value" /> are compared. If <paramref name="culture" /> is null, the current culture is used.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.</summary>
		/// <returns>A <see cref="T:System.String" /> equivalent to this instance but with all instances of <paramref name="oldChar" /> replaced with <paramref name="newChar" />.</returns>
		/// <param name="oldChar">A Unicode character to be replaced. </param>
		/// <param name="newChar">A Unicode character to replace all occurrences of <paramref name="oldChar" />. </param>
		/// <filterpriority>1</filterpriority>
		public string Replace(char oldChar, char newChar)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new string in which all occurrences of a specified string in this instance are replaced with another specified string.</summary>
		/// <returns>A <see cref="T:System.String" /> equivalent to this instance but with all instances of <paramref name="oldValue" /> replaced with <paramref name="newValue" />.</returns>
		/// <param name="oldValue">A string to be replaced. </param>
		/// <param name="newValue">A string to replace all occurrences of <paramref name="oldValue" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="oldValue" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="oldValue" /> is the empty string (""). </exception>
		/// <filterpriority>1</filterpriority>
		public string Replace(string oldValue, string newValue)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string ReplaceUnchecked(string oldValue, string newValue)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string ReplaceFallback(string oldValue, string newValue, int testedCount)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Deletes a specified number of characters from this instance beginning at a specified position.</summary>
		/// <returns>A new <see cref="T:System.String" /> that is equivalent to this instance less <paramref name="count" /> number of characters.</returns>
		/// <param name="startIndex">The zero-based position to begin deleting characters. </param>
		/// <param name="count">The number of characters to delete. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="startIndex" /> or <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="count" /> specify a position outside this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public string Remove(int startIndex, int count)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> converted to lowercase, using the casing rules of the current culture.</summary>
		/// <returns>A <see cref="T:System.String" /> in lowercase.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string ToLower()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> converted to lowercase, using the casing rules of the specified culture.</summary>
		/// <returns>A <see cref="T:System.String" /> in lowercase.</returns>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that supplies culture-specific casing rules. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string ToLower(CultureInfo culture)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> object converted to lowercase using the casing rules of the invariant culture.</summary>
		/// <returns>A <see cref="T:System.String" /> object in lowercase.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string ToLowerInvariant()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> converted to uppercase, using the casing rules of the current culture.</summary>
		/// <returns>A <see cref="T:System.String" /> in uppercase.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string ToUpper()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> converted to uppercase, using the casing rules of the specified culture.</summary>
		/// <returns>A <see cref="T:System.String" /> in uppercase.</returns>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> object that supplies culture-specific casing rules. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="culture" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string ToUpper(CultureInfo culture)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a copy of this <see cref="T:System.String" /> object converted to uppercase using the casing rules of the invariant culture.</summary>
		/// <returns>A <see cref="T:System.String" /> object in uppercase.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public string ToUpperInvariant()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary>
		/// <returns>This <see cref="T:System.String" />.</returns>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns this instance of <see cref="T:System.String" />; no actual conversion is performed.</summary>
		/// <returns>This <see cref="T:System.String" />.</returns>
		/// <param name="provider">(Reserved) An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information. </param>
		/// <filterpriority>1</filterpriority>
		public string ToString(IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Replaces one or more format items in a specified string with the string representation of a specified object.</summary>
		/// <returns>A copy of <paramref name="format" /> in which any format items are replaced by the string representation of <paramref name="arg0" />.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">An object to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">The format item in <paramref name="format" /> is invalid.-or- The index of a format item is greater or less than zero. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Format(string format, object arg0)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Replaces the format items in a specified string with the string representations of two specified objects.</summary>
		/// <returns>A copy of <paramref name="format" /> in which format items have been replaced by the string equivalents of <paramref name="arg0" /> and <paramref name="arg1" />.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than one. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Format(string format, object arg0, object arg1)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Replaces the format items in a specified string with the string representation of three specified objects.</summary>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representations of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <param name="arg2">The third object to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than two. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Replaces the format item in a specified string with the string representation of a corresponding object in a specified array.</summary>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="args">An object array that contains zero or more objects to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> or <paramref name="args" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Format(string format, params object[] args)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Replaces the format item in a specified string with the string representation of a corresponding object in a specified array. A specified parameter supplies culture-specific formatting information.</summary>
		/// <returns>A copy of <paramref name="format" /> in which the format items have been replaced by the string representation of the corresponding objects in <paramref name="args" />.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific formatting information. </param>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="args">An <see cref="T:System.Object" /> array containing zero or more objects to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> or <paramref name="args" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the <paramref name="args" /> array. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Format(IFormatProvider provider, string format, params object[] args)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static StringBuilder FormatHelper(StringBuilder result, IFormatProvider provider, string format, params object[] args)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a new instance of <see cref="T:System.String" /> with the same value as a specified <see cref="T:System.String" />.</summary>
		/// <returns>A new <see cref="T:System.String" /> with the same value as <paramref name="str" />.</returns>
		/// <param name="str">The <see cref="T:System.String" /> to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Copy(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates the string representation of a specified object.</summary>
		/// <returns>The string representation of the value of <paramref name="arg0" />, or <see cref="F:System.String.Empty" /> if <paramref name="arg0" /> is null.</returns>
		/// <param name="arg0">The object to represent, or null. </param>
		/// <filterpriority>1</filterpriority>
		public static string Concat(object arg0)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the string representations of two specified objects.</summary>
		/// <returns>The concatenated string representations of the values of <paramref name="arg0" /> and <paramref name="arg1" />.</returns>
		/// <param name="arg0">The first object to concatenate. </param>
		/// <param name="arg1">The second object to concatenate.</param>
		/// <filterpriority>1</filterpriority>
		public static string Concat(object arg0, object arg1)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the string representations of three specified objects.</summary>
		/// <returns>The concatenated string representations of the values of <paramref name="arg0" />, <paramref name="arg1" />, and <paramref name="arg2" />.</returns>
		/// <param name="arg0">The first object to concatenate. </param>
		/// <param name="arg1">The second object to concatenate. </param>
		/// <param name="arg2">The third object to concatenate.</param>
		/// <filterpriority>1</filterpriority>
		public static string Concat(object arg0, object arg1, object arg2)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[CLSCompliant(false)]
		public static string Concat(object arg0, object arg1, object arg2, object arg3, __arglist)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates two specified instances of <see cref="T:System.String" />.</summary>
		/// <returns>The concatenation of <paramref name="str0" /> and <paramref name="str1" />.</returns>
		/// <param name="str0">The first string to concatenate. </param>
		/// <param name="str1">The second string to concatenate. </param>
		/// <filterpriority>1</filterpriority>
		public static string Concat(string str0, string str1)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates three specified instances of <see cref="T:System.String" />.</summary>
		/// <returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, and <paramref name="str2" />.</returns>
		/// <param name="str0">The first <see cref="T:System.String" />. </param>
		/// <param name="str1">The second <see cref="T:System.String" />. </param>
		/// <param name="str2">The third <see cref="T:System.String" />. </param>
		/// <filterpriority>1</filterpriority>
		public static string Concat(string str0, string str1, string str2)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates four specified instances of <see cref="T:System.String" />.</summary>
		/// <returns>The concatenation of <paramref name="str0" />, <paramref name="str1" />, <paramref name="str2" />, and <paramref name="str3" />.</returns>
		/// <param name="str0">The first string to concatenate.</param>
		/// <param name="str1">The second string to concatenate.</param>
		/// <param name="str2">The third string to concatenate.</param>
		/// <param name="str3">The fourth string to concatenate.</param>
		/// <filterpriority>1</filterpriority>
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the string representations of the elements in a specified <see cref="T:System.Object" /> array.</summary>
		/// <returns>The concatenated string representations of the values of the elements in <paramref name="args" />.</returns>
		/// <param name="args">An object array that contains the elements to concatenate.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="args" /> is null. </exception>
		/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
		/// <filterpriority>1</filterpriority>
		public static string Concat(params object[] args)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the elements of a specified <see cref="T:System.String" /> array.</summary>
		/// <returns>The concatenated elements of <paramref name="values" />.</returns>
		/// <param name="values">An array of string instances. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="values" /> is null. </exception>
		/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
		/// <filterpriority>1</filterpriority>
		public static string Concat(params string[] values)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static string ConcatInternal(string[] values, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Inserts a specified instance of <see cref="T:System.String" /> at a specified index position in this instance.</summary>
		/// <returns>A new <see cref="T:System.String" /> equivalent to this instance but with <paramref name="value" /> inserted at position <paramref name="startIndex" />.</returns>
		/// <param name="startIndex">The index position of the insertion. </param>
		/// <param name="value">The <see cref="T:System.String" /> to insert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is negative or greater than the length of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public string Insert(int startIndex, string value)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the system's reference to the specified <see cref="T:System.String" />.</summary>
		/// <returns>If the value of <paramref name="str" /> is already interned, the system's reference is returned; otherwise, a new reference to a string with the value of <paramref name="str" /> is returned.</returns>
		/// <param name="str">A <see cref="T:System.String" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		public static string Intern(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a reference to a specified <see cref="T:System.String" />.</summary>
		/// <returns>A <see cref="T:System.String" /> reference to <paramref name="str" /> if it is in the common language runtime "intern pool"; otherwise null.</returns>
		/// <param name="str">A <see cref="T:System.String" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		public static string IsInterned(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates a specified separator <see cref="T:System.String" /> between each element of a specified <see cref="T:System.String" /> array, yielding a single concatenated string.</summary>
		/// <returns>A <see cref="T:System.String" /> consisting of the elements of <paramref name="value" /> interspersed with the <paramref name="separator" /> string.</returns>
		/// <param name="separator">A <see cref="T:System.String" />. </param>
		/// <param name="value">An array of <see cref="T:System.String" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Join(string separator, string[] value)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates a specified separator <see cref="T:System.String" /> between each element of a specified <see cref="T:System.String" /> array, yielding a single concatenated string. Parameters specify the first array element and number of elements to use.</summary>
		/// <returns>A <see cref="T:System.String" /> object consisting of the strings in <paramref name="value" /> joined by <paramref name="separator" />. Or, <see cref="F:System.String.Empty" /> if <paramref name="count" /> is zero, <paramref name="value" /> has no elements, or <paramref name="separator" /> and all the elements of <paramref name="value" /> are <see cref="F:System.String.Empty" />.</returns>
		/// <param name="separator">A <see cref="T:System.String" />. </param>
		/// <param name="value">An array of <see cref="T:System.String" />. </param>
		/// <param name="startIndex">The first array element in <paramref name="value" /> to use. </param>
		/// <param name="count">The number of elements of <paramref name="value" /> to use. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="count" /> is less than 0.-or- <paramref name="startIndex" /> plus <paramref name="count" /> is greater than the number of elements in <paramref name="value" />. </exception>
		/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
		/// <filterpriority>1</filterpriority>
		public static string Join(string separator, string[] value, int startIndex, int count)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static string JoinUnchecked(string separator, string[] value, int startIndex, int count)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves an object that can iterate through the individual characters in this string.</summary>
		/// <returns>A <see cref="T:System.CharEnumerator" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		public CharEnumerator GetEnumerator()
		{
			return (CharEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		private static void ParseFormatSpecifier(string str, ref int ptr, out int n, out int width, out bool left_align, out string format)
		{
		}

		private static int ParseDecimal(string str, ref int ptr)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal void InternalSetChar(int idx, char val)
		{
		}

		internal void InternalSetLength(int newLength)
		{
		}

		/// <summary>Returns the hash code for this string.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal int GetCaseInsensitiveHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private unsafe string CreateString(sbyte* value)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private unsafe string CreateString(char* value)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private unsafe string CreateString(char* value, int startIndex, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string CreateString(char[] val, int startIndex, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string CreateString(char[] val)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string CreateString(char c, int count)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal unsafe static void memset(byte* dest, int val, int len)
		{
		}

		private unsafe static void memcpy4(byte* dest, byte* src, int size)
		{
		}

		private unsafe static void memcpy2(byte* dest, byte* src, int size)
		{
		}

		private unsafe static void memcpy1(byte* dest, byte* src, int size)
		{
		}

		internal unsafe static void memcpy(byte* dest, byte* src, int size)
		{
		}

		internal unsafe static void CharCopy(char* dest, char* src, int count)
		{
		}

		internal unsafe static void CharCopyReverse(char* dest, char* src, int count)
		{
		}

		internal static void CharCopy(string target, int targetIndex, string source, int sourceIndex, int count)
		{
		}

		internal static void CharCopy(string target, int targetIndex, char[] source, int sourceIndex, int count)
		{
		}

		internal static void CharCopyReverse(string target, int targetIndex, string source, int sourceIndex, int count)
		{
		}

		[MethodImpl(4096)]
		private extern string[] InternalSplit(char[] separator, int count, int options);

		[MethodImpl(4096)]
		internal static extern string InternalAllocateStr(int length);

		[MethodImpl(4096)]
		private static extern string InternalIntern(string str);

		[MethodImpl(4096)]
		private static extern string InternalIsInterned(string str);

		/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have the same value.</summary>
		/// <returns>true if the value of <paramref name="a" /> is the same as the value of <paramref name="b" />; otherwise, false.</returns>
		/// <param name="a">A <see cref="T:System.String" /> or null. </param>
		/// <param name="b">A <see cref="T:System.String" /> or null. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator ==(string a, string b)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether two specified <see cref="T:System.String" /> objects have different values.</summary>
		/// <returns>true if the value of <paramref name="a" /> is different from the value of <paramref name="b" />; otherwise, false.</returns>
		/// <param name="a">A String or null. </param>
		/// <param name="b">A String or null. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator !=(string a, string b)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
